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
{   //Este formulario solo gestiona la parte visual (UI) de los reportes.
    //Puede ser usado como una implementación de IReportesView sin afectar al presentador.
    public partial class FrmReportes : Form, IReportesView
    {
        private ReportesPresentador _presentador;

        public FrmReportes()
        {
            InitializeComponent();
            _presentador = new ReportesPresentador(this);
            EstilizarDataGrid();
        }
        private void EstilizarDataGrid()
        {
            dgvTicketsDelDia.EnableHeadersVisualStyles = false;
            dgvTicketsDelDia.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            dgvTicketsDelDia.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTicketsDelDia.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvTicketsDelDia.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvTicketsDelDia.DefaultCellStyle.BackColor = Color.White;
            dgvTicketsDelDia.DefaultCellStyle.ForeColor = Color.Black;
            dgvTicketsDelDia.DefaultCellStyle.SelectionBackColor = Color.FromArgb(60, 120, 200);
            dgvTicketsDelDia.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvTicketsDelDia.GridColor = Color.LightGray;
            dgvTicketsDelDia.BorderStyle = BorderStyle.None;
        }
        public void MostrarTicketsConUsuario(List<TicketConUsuario> tickets)
        {
            dgvTicketsDelDia.DataSource = null;
            dgvTicketsDelDia.DataSource = tickets;

            // Estilo personalizado
            dgvTicketsDelDia.Columns["NombreUsuario"].HeaderText = "Usuario";
            dgvTicketsDelDia.Columns["EquipoLocal"].HeaderText = "Equipo Local";
            dgvTicketsDelDia.Columns["EquipoVisitante"].HeaderText = "Equipo Visitante";
            dgvTicketsDelDia.Columns["TipoCuota"].HeaderText = "Tipo de Cuota";
            dgvTicketsDelDia.Columns["Monto"].DefaultCellStyle.Format = "C";
            dgvTicketsDelDia.Columns["GananciaEstimada"].DefaultCellStyle.Format = "C";
            dgvTicketsDelDia.Columns["FechaApuesta"].DefaultCellStyle.Format = "g";
            dgvTicketsDelDia.Columns["Estado"].HeaderText = "Estado";
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
           
        }
        public void MostrarTicketsDelDia(List<Ticket> tickets)
        {
            dgvTicketsDelDia.DataSource = null;
            dgvTicketsDelDia.DataSource = tickets;
        }
    
}   }
