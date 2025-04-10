using PitchWin.Vista;
using PlayerUI;
using System.Windows.Forms;

namespace PitchWin.Presentador
{
    public class MenuPrincipalPresentador
    {
        private readonly FrmMenuPrincipal _vista;

        public MenuPrincipalPresentador(FrmMenuPrincipal vista)
        {
            _vista = vista;
        }

        // Método para cerrar sesión y volver al formulario de login.
        public void CerrarSesion(Form currentForm)
        {
            currentForm.Close();
        }

        // Método para cargar FrmInicioo en el panel contenedor
        public void CargarFrmInicioo()
        {
            FrmInicioo frmInicioo = new FrmInicioo();
            _vista.AbrirFormularioHijo(frmInicioo);
        }

        // Método para cargar FrmApuestas en el panel contenedor
        public void CargarFrmApuestas()
        {
            FrmApuestas frmApuestas = new FrmApuestas();
            _vista.AbrirFormularioHijo(frmApuestas);
        }

        // Método para cargar FrmPagarTicket en el panel contenedor
        public void CargarFrmPagarTicket()
        {
            FrmPagarTicket frmPagarTicket = new FrmPagarTicket();
            _vista.AbrirFormularioHijo(frmPagarTicket);
        }

        // Método para cargar FrmReportes en el panel contenedor
        public void CargarFrmReportes()
        {
            FrmReportes frmReportes = new FrmReportes();
            _vista.AbrirFormularioHijo(frmReportes);
        }

        // Método para cargar FrmAyuda en el panel contenedor
        public void CargarFrmAyuda()
        {
            FrmAyuda frmAyuda = new FrmAyuda();
            _vista.AbrirFormularioHijo(frmAyuda);
        }
    }
}
