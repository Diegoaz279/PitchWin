using PitchWin.Modelo;
using PitchWin.Vista;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PitchWin.Presentador
{
    public class ValidarTicketPresentador
    {
        private readonly IValidarTicketView _vista;
        private readonly IApiStatsService _statsService;

        public ValidarTicketPresentador(IValidarTicketView vista, IApiStatsService statsService)
        {
            _vista = vista;
            _statsService = statsService;
        }

        public async Task ValidarTicketAsync()
        {
            try
            {
                // Obtener la lista de juegos para la fecha del ticket
                var juegos = await _statsService.ObtenerJuegosPorFecha(_vista.FechaJuego);

                // Buscar el juego que coincida con los equipos del ticket (usando nombres de equipo)
                var juego = juegos.FirstOrDefault(g =>
                    string.Equals(g.Teams.Home.Team.Name, _vista.EquipoLocal, StringComparison.OrdinalIgnoreCase) &&
                    string.Equals(g.Teams.Away.Team.Name, _vista.EquipoVisitante, StringComparison.OrdinalIgnoreCase));

                if (juego == null)
                {
                    _vista.MostrarMensaje("No se encontró el juego para la fecha y equipos indicados.");
                    return;
                }

                // Validar el ticket según el tipo de apuesta
                bool esGanador = false;
                switch (_vista.TipoApuestaSeleccionado)
                {
                    case "Local":
                        esGanador = juego.Teams.Home.Score > juego.Teams.Away.Score;
                        break;
                    case "Visitante":
                        esGanador = juego.Teams.Away.Score > juego.Teams.Home.Score;
                        break;
                    case "Empate":
                        esGanador = juego.Teams.Home.Score == juego.Teams.Away.Score;
                        break;
                }

                if (esGanador)
                    _vista.MostrarMensaje("El ticket es ganador.");
                else
                    _vista.MostrarMensaje("El ticket no es ganador.");
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje("Error al validar el ticket: " + ex.Message);
            }
        }
    }
}
