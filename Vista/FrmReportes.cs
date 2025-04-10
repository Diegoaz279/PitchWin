using PitchWin.Modelo;
using PitchWin.Presentador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PitchWin.Vista
{
    public partial class FrmReportes : Form, IReportesView
    {
        private ReportesPresentador _presentador;

        public FrmReportes()
        {
            InitializeComponent();
            _presentador = new ReportesPresentador(this);
        }

        // La propiedad fecha seleccionada proviene del DateTimePicker (por ejemplo, dtpReportesFecha)
        public DateTime FechaSeleccionada => dtpReportesFecha.Value;
        private async void btnReportesBuscar_Click(object sender, EventArgs e)
        {
            await _presentador.GenerarReporteAsync();
        }
        // Muestra los datos del reporte en los TextBox correspondientes
        public void MostrarReporte(Reporte reporte)
        {
            txtReportesTicket.Text = reporte.TotalTickets.ToString();
            txtReportesGanadores.Text = reporte.Ganadores.ToString();
            txtReportesPerdedores.Text = reporte.Perdedores.ToString();
            txtReportesVentaTotal.Text = reporte.VentaTotal.ToString("C");
            txtReportesGananciaTotal.Text = reporte.GananciaTotal.ToString("C");

            // Si decides mostrar los pendientes:
            // txtReportesTicketsSinPagar.Text = reporte.TicketsSinPagar.ToString();
            // txtReportesMontoTicketsSinPagar.Text = reporte.MontoTicketsSinPagar.ToString("C");
        }

        public async Task MostrarError(string mensaje)
        {
            await Task.Run(() =>
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            });
        }

        public void LimpiarReportes()
        {
            txtReportesTicket.Clear();
            txtReportesGanadores.Clear();
            txtReportesPerdedores.Clear();
            txtReportesVentaTotal.Clear();
            txtReportesGananciaTotal.Clear();

            // Si se usan los controles de pendientes:
            // txtReportesTicketsSinPagar.Clear();
            // txtReportesMontoTicketsSinPagar.Clear();
        }
}   }
