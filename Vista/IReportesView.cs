using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PitchWin.Modelo;

namespace PitchWin.Vista
{
    public interface IReportesView
    {
        DateTime FechaSeleccionada { get; }
        void MostrarReporte(Reporte reporte);

        void MostrarTicketsConUsuario(List<TicketConUsuario> tickets); // ✅ nuevo método

        Task MostrarError(string mensaje);
        void LimpiarReportes();
    }
}
