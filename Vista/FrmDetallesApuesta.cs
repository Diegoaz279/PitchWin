using PitchWin.Modelo;
using PitchWin.Presentador;
using PlayerUI;
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
    public partial class FrmDetallesApuesta : Form, IDetalleApuestaView
    {
        private readonly DetalleApuestaPresentador _presentador;

        public FrmDetallesApuesta(Partido partido, PitchWinDbContext dbContext)
        {
            InitializeComponent();

            // Rellenar los datos del partido en los controles.
            EquipoLocal = partido.EquipoLocal;
            EquipoVisitante = partido.EquipoVisitante;
            HoraPartido = partido.HoraPartido.ToString("hh:mm tt");

            // Cargar la fecha del juego en el TextBox correspondiente.
            txtConfirmacionApuestaFecha.Text = partido.HoraPartido.ToShortDateString();

            // Inicializar controles para seleccionar el tipo de apuesta y el equipo apostado.
            cmbConfirmacionDeApuestaTipoApuesta.Items.AddRange(new string[] { "Local", "Visitante", "Empate" });
            cmbConfirmacionDeApuestaTipoApuesta.SelectedIndex = 0;
            cmbConfirmacionDeApuestaEquipo.Items.Add(EquipoLocal);
            cmbConfirmacionDeApuestaEquipo.Items.Add(EquipoVisitante);
            cmbConfirmacionDeApuestaEquipo.SelectedIndex = 0;

            // Suscribir el evento TextChanged para recalcular la ganancia en tiempo real.
            txtConfirmacionApuestaMonto.TextChanged += txtConfirmacionApuestaMonto_TextChanged;

            // Inicializar el presentador.
            _presentador = new DetalleApuestaPresentador(this, partido, new TicketService(dbContext));

            // Cuando el formulario se muestre, cargamos los logos.
            this.Shown += async (s, e) => { await _presentador.CargarLogosAsync(); };
        }

        private void txtConfirmacionApuestaMonto_TextChanged(object sender, EventArgs e)
        {
            _presentador.CalcularGanancia();
        }

        #region Implementación de IDetalleApuestaView

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public string EquipoLocal
        {
            get => lbldetalleapuesta1.Text;
            set => lbldetalleapuesta1.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public string EquipoVisitante
        {
            get => lbldetalleapuesta2.Text;
            set => lbldetalleapuesta2.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public string HoraPartido
        {
            get => lblHora.Text;
            set => lblHora.Text = value;
        }

        public string TipoApuesta => cmbConfirmacionDeApuestaTipoApuesta.SelectedItem.ToString();
        public string EquipoApostado => cmbConfirmacionDeApuestaEquipo.SelectedItem.ToString();

        public decimal MontoApuesta
        {
            get
            {
                if (decimal.TryParse(txtConfirmacionApuestaMonto.Text, out decimal monto))
                    return monto;
                return 0;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public decimal GananciaEstimad
        {
            get
            {
                if (decimal.TryParse(txtConfirmacionApuestaGnanciaEstimada.Text, out decimal ganancia))
                    return ganancia;
                return 0;
            }
            set => txtConfirmacionApuestaGnanciaEstimada.Text = value.ToString("C");
        }

        public async Task MostrarError(string mensaje)
        {
            await Task.Run(() =>
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            });
        }

        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MostrarTicket(string mensajeTicket)
        {
            MessageBox.Show(mensajeTicket, "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Implementación del método para navegar a FrmApuestas.
        public void NavegarAFrmApuestas()
        {
            // Intentar obtener la instancia de FrmMenuPrincipal:
            FrmMenuPrincipal frmMenu = null;
            if (this.Owner is FrmMenuPrincipal)
            {
                frmMenu = (FrmMenuPrincipal)this.Owner;
            }
            else
            {
                frmMenu = Application.OpenForms.OfType<FrmMenuPrincipal>().FirstOrDefault();
            }

            // Crear la instancia del formulario de apuestas.
            FrmApuestas frmApuestas = new FrmApuestas();

            if (frmMenu != null)
            {
                // Asigna FrmMenuPrincipal como Owner de FrmApuestas para que puedas seguir apostando.
                frmApuestas.Owner = frmMenu;
                // Abre FrmApuestas dentro del contenedor PanelInicio.
                frmMenu.AbrirFormularioHijo(frmApuestas);
            }
            else
            {
                // En caso de no encontrar FrmMenuPrincipal, muestra FrmApuestas de forma convencional.
                frmApuestas.Show();
            }

            // Cierra el formulario actual.
            this.Close();
        }

        // Métodos para asignar logos. Se usan bloques try/catch para mantener la imagen predeterminada en caso de error.
        public void SetLogoEquipoLocal(string logoUrl)
        {
            if (string.IsNullOrEmpty(logoUrl))
                return;

            try
            {
                pictureBoxDetalleApuestas1.Load(logoUrl);
            }
            catch
            {
                // Si falla, no se modifica la imagen predeterminada.
            }
        }

        public void SetLogoEquipoVisitante(string logoUrl)
        {
            if (string.IsNullOrEmpty(logoUrl))
                return;

            try
            {
                pictureBoxDetalleApuestas2.Load(logoUrl);
            }
            catch
            {
                // Si falla, se mantiene la imagen predeterminada.
            }
        }

        #endregion


        // Evento del botón "Confirmar Apuesta"
        private async void btnConfirmarApuesta_Click_1(object sender, EventArgs e)
        {
            _presentador.CalcularGanancia();
            await _presentador.ConfirmarApuesta();
        }

       
       
    }
}
