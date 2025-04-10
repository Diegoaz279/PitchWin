using PitchWin.Modelo;
using System;
using System.Threading.Tasks;

namespace PitchWin.Vista
{
    public interface IReportesView
    {
        DateTime FechaSeleccionada { get; }
        void MostrarReporte(Reporte reporte);
        Task MostrarError(string mensaje);
        void LimpiarReportes();
    }
}
