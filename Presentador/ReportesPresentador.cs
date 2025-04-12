using Microsoft.EntityFrameworkCore;
using PitchWin.Modelo;
using PitchWin.Vista;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PitchWin.Presentador
{
    public class ReportesPresentador
    {
        private readonly IReportesView _vista;

        public ReportesPresentador(IReportesView vista)
        {
            _vista = vista;
        }

        public async Task GenerarReporteAsync()
        {
            try
            {
                using (var context = new PitchWinDbContext())
                {
                    var tickets = await (from t in context.Tickets
                                         join u in context.Usuarios on t.UsuarioId equals u.Id
                                         where t.FechaApuesta.Date == _vista.FechaSeleccionada.Date
                                         select new TicketConUsuario
                                         {
                                             NombreUsuario = u.Nombre,
                                             EquipoLocal = t.EquipoLocal,
                                             EquipoVisitante = t.EquipoVisitante,
                                             TipoCuota = t.TipoCuota,
                                             Monto = t.Monto,
                                             GananciaEstimada = t.GananciaEstimada,
                                             FechaApuesta = t.FechaApuesta,
                                             Estado = t.Estado
                                         }).ToListAsync();

                    // Llamamos al nuevo método
                    _vista.MostrarTicketsConUsuario(tickets);
                }
            }
            catch (Exception ex)
            {
                await _vista.MostrarError("Error al generar el reporte: " + ex.Message);
                _vista.LimpiarReportes();
            }
        }
    }
}
