using PitchWin.Modelo;
using PitchWin.Vista;
using System;
using System.Threading.Tasks;

namespace PitchWin.Presentador
{
    public class DetalleApuestaPresentador
    {
        private readonly IDetalleApuestaView _vista;
        private readonly TicketService _ticketService;
        private readonly Partido _partido;
        private readonly IApiMLBService _apiService; // Servicio para obtener logos de la API

        public DetalleApuestaPresentador(IDetalleApuestaView vista, Partido partido, TicketService ticketService)
        {
            _vista = vista;
            _partido = partido;
            _ticketService = ticketService;
            _apiService = new ApiMLBService(); // Se puede inyectar si se desea
        }

        // Método para cargar los logos de los equipos y asignarlos a la vista
        public async Task CargarLogosAsync()
        {
            try
            {
                string logoLocal = await _apiService.ObtenerLogoEquipo(_partido.EquipoLocal);
                string logoVisitante = await _apiService.ObtenerLogoEquipo(_partido.EquipoVisitante);

                // Llamar a los métodos de la vista para asignar los logos
                _vista.SetLogoEquipoLocal(logoLocal);
                _vista.SetLogoEquipoVisitante(logoVisitante);
            }
            catch (Exception ex)
            {
                await _vista.MostrarError("Error al cargar logos: " + ex.Message);
            }
        }

        // Método para calcular la ganancia estimada según el tipo de apuesta y el monto ingresado
        public void CalcularGanancia()
        {
            try
            {
                decimal multiplicador = 1.0m;
                string tipo = _vista.TipoApuesta;
                switch (tipo)
                {
                    case "Local":
                        multiplicador = 1.8m;
                        break;
                    case "Visitante":
                        multiplicador = 2.0m;
                        break;
                    case "Empate":
                        multiplicador = 3.0m;
                        break;
                }
                decimal gananciaCalculada = _vista.MontoApuesta * multiplicador;
                _vista.GananciaEstimad = gananciaCalculada;
            }
            catch (Exception ex)
            {
                _vista.MostrarError("Error al calcular la ganancia: " + ex.Message).Wait();
            }
        }

        // Método para confirmar la apuesta y guardar el ticket en la base de datos
        public async Task ConfirmarApuesta()
        {
            try
            {
                decimal multiplicador = 1.0m;
                string tipo = _vista.TipoApuesta;
                switch (tipo)
                {
                    case "Local":
                        multiplicador = 1.8m;
                        break;
                    case "Visitante":
                        multiplicador = 2.0m;
                        break;
                    case "Empate":
                        multiplicador = 3.0m;
                        break;
                }
                decimal gananciaCalculada = _vista.MontoApuesta * multiplicador;

                var ticket = new Ticket
                {
                    UsuarioId = 1, // Ajusta según el usuario actual
                    EquipoLocal = _partido.EquipoLocal,
                    EquipoVisitante = _partido.EquipoVisitante,
                    TipoCuota = _vista.TipoApuesta,
                    Monto = _vista.MontoApuesta,
                    GananciaEstimada = gananciaCalculada,
                    FechaApuesta = DateTime.Now,
                    Estado = "Pendiente",
                    FechaPago = null
                };

                int ticketId = await _ticketService.GuardarTicketAsync(ticket);

                string mensajeTicket = $"Ticket generado:\nID: {ticketId}\n" +
                                         $"Partido: {_partido.EquipoLocal} vs {_partido.EquipoVisitante}\n" +
                                         $"Tipo de Apuesta: {_vista.TipoApuesta}\n" +
                                         $"Monto apostado: {_vista.MontoApuesta:C}\n" +
                                         $"Ganancia estimada: {gananciaCalculada:C}";

                _vista.MostrarTicket(mensajeTicket);

                // Navegar al formulario de Apuestas
                _vista.NavegarAFrmApuestas();
            }
            catch (Exception ex)
            {
                await _vista.MostrarError("Error al confirmar la apuesta: " + ex.Message);
            }
        }
    }
}
