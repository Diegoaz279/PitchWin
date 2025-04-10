using System;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using PitchWin.Presentador;
using PlayerUI;

namespace PitchWin.Vista
{
    public partial class FrmInicioo : Form, IFrmInicioo
    {
        private readonly FrmIniciooPresenter _presentador;
       


        public FrmInicioo()
        {
            InitializeComponent();
            _presentador = new FrmIniciooPresenter(this);
            _ = _presentador.CargarPartidosDelDia();
        }

        public void SetEquipoLocal(string equipoLocal)
        {
            lblInicio1.Text = equipoLocal;
        }

        public void SetEquipoVisitante(string equipoVisitante)
        {
            lblInicio2.Text = equipoVisitante;
        }

        public void SetHoraPartido(string horaPartido)
        {

        }

        public void SetLogoEquipoLocal(string logoUrl)
        {
            pictureBoxInicio1.Load(logoUrl);
        }

        public void SetLogoEquipoVisitante(string logoUrl)
        {
            pictureBoxInicio2.Load(logoUrl);
        }

        public async Task ShowError(string mensaje)
        {
            await Task.Run(() =>
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            });
        }
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

        private void btnApostarInicio_Click(object sender, EventArgs e)
        {
            NavegarAFrmApuestas();
        }
    }
}
