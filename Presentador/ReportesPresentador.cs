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
                    // Usamos solo la parte de la fecha para filtrar
                    DateTime fecha = _vista.FechaSeleccionada.Date;

                    // Se invoca el procedimiento almacenado y se materializa la lista
                    var resultados = await context.Reportes
                        .FromSqlRaw("EXEC GenerarReporte @Fecha = {0}", fecha)
                        .ToListAsync();

                    var reporte = resultados.FirstOrDefault();

                    if (reporte != null)
                    {
                        _vista.MostrarReporte(reporte);
                    }
                    else
                    {
                        await _vista.MostrarError("No se encontraron datos de reporte para la fecha seleccionada.");
                        _vista.LimpiarReportes();
                    }
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
