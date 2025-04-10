using PitchWin.Presentador;
using PitchWin.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class FrmMenuPrincipal : Form
    {
        // Instancia del presentador del menú principal
        public MenuPrincipalPresentador menu;

        public FrmMenuPrincipal()
        {
            InitializeComponent();

        }

        // Este método se utiliza para cargar un formulario hijo en el panel contenedor (PanelInicio)
        // En FrmMenuPrincipal, método para abrir un formulario hijo en el panel contenedor.
        public void AbrirFormularioHijo(Form formHijo)
        {
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            PanelInicio.Controls.Clear();
            PanelInicio.Controls.Add(formHijo);
            PanelInicio.Tag = formHijo;
            // No asignamos Owner aquí porque el formulario queda incrustado.
            formHijo.Show();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            // Inicializar el presentador cuando el formulario se carga
            menu = new MenuPrincipalPresentador(this);

            // Llamar al método para cargar automáticamente el formulario de inicio
            menu.CargarFrmInicioo();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            menu.CerrarSesion(this);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            menu.CargarFrmInicioo();
        }

        private void btnApuestas_Click(object sender, EventArgs e)
        {
            FrmApuestas frmApuestas = new FrmApuestas();
            frmApuestas.Owner = this; // Asigna FrmMenuPrincipal como Owner
            AbrirFormularioHijo(frmApuestas);
        }

        private void btnPagarTicket_Click(object sender, EventArgs e)
        {
            menu.CargarFrmPagarTicket();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            menu.CargarFrmReportes();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            menu.CargarFrmAyuda();
        }
    }   }
