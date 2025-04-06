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
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            // Crea una instancia del formulario FrmApuestas
            FrmInicioo frmInicio = new FrmInicioo();

            // Establecer el formulario como hijo del panel PanelInicio
            frmInicio.TopLevel = false;  // Evita que se abra en una nueva ventana
            frmInicio.FormBorderStyle = FormBorderStyle.None; // Opcional: quita los bordes del formulario
            frmInicio.Dock = DockStyle.Fill;  // Asegura que el formulario ocupe todo el panel
            PanelInicio.Controls.Clear(); // Limpia cualquier control que esté previamente en el panel
            PanelInicio.Controls.Add(frmInicio);  // Añade el formulario al panel
            frmInicio.Show(); // Muestra el formulario dentro del panel


        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            FrmInicioo frmInicio = new FrmInicioo();

            // Establecer el formulario como hijo del panel PanelInicio
            frmInicio.TopLevel = false;  // Evita que se abra en una nueva ventana
            frmInicio.FormBorderStyle = FormBorderStyle.None; // Opcional: quita los bordes del formulario
            frmInicio.Dock = DockStyle.Fill;  // Asegura que el formulario ocupe todo el panel
            PanelInicio.Controls.Clear(); // Limpia cualquier control que esté previamente en el panel
            PanelInicio.Controls.Add(frmInicio);  // Añade el formulario al panel
            frmInicio.Show(); // Muestra el formulario dentro del panel

        }

        private void btnApuestas_Click(object sender, EventArgs e)
        {
            FrmApuestas frmapuestas = new FrmApuestas();

            // Establecer el formulario como hijo del panel PanelInicio
            frmapuestas.TopLevel = false;  // Evita que se abra en una nueva ventana
            frmapuestas.FormBorderStyle = FormBorderStyle.None; // Opcional: quita los bordes del formulario
            frmapuestas.Dock = DockStyle.Fill;  // Asegura que el formulario ocupe todo el panel
            PanelInicio.Controls.Clear(); // Limpia cualquier control que esté previamente en el panel
            PanelInicio.Controls.Add(frmapuestas);  // Añade el formulario al panel
            frmapuestas.Show(); // Muestra el formulario dentro del panel
        }

        private void btnPagarTicket_Click(object sender, EventArgs e)
        {
            FrmPagarTicket frmapuestas = new FrmPagarTicket();

            // Establecer el formulario como hijo del panel PanelInicio
            frmapuestas.TopLevel = false;  // Evita que se abra en una nueva ventana
            frmapuestas.FormBorderStyle = FormBorderStyle.None; // Opcional: quita los bordes del formulario
            frmapuestas.Dock = DockStyle.Fill;  // Asegura que el formulario ocupe todo el panel
            PanelInicio.Controls.Clear(); // Limpia cualquier control que esté previamente en el panel
            PanelInicio.Controls.Add(frmapuestas);  // Añade el formulario al panel
            frmapuestas.Show(); // Muestra el formulario dentro del panel
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FrmReportes frmapuestas = new FrmReportes();

            // Establecer el formulario como hijo del panel PanelInicio
            frmapuestas.TopLevel = false;  // Evita que se abra en una nueva ventana
            frmapuestas.FormBorderStyle = FormBorderStyle.None; // Opcional: quita los bordes del formulario
            frmapuestas.Dock = DockStyle.Fill;  // Asegura que el formulario ocupe todo el panel
            PanelInicio.Controls.Clear(); // Limpia cualquier control que esté previamente en el panel
            PanelInicio.Controls.Add(frmapuestas);  // Añade el formulario al panel
            frmapuestas.Show(); // Muestra el formulario dentro del panel
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            FrmAyuda frmapuestas = new FrmAyuda();

            // Establecer el formulario como hijo del panel PanelInicio
            frmapuestas.TopLevel = false;  // Evita que se abra en una nueva ventana
            frmapuestas.FormBorderStyle = FormBorderStyle.None; // Opcional: quita los bordes del formulario
            frmapuestas.Dock = DockStyle.Fill;  // Asegura que el formulario ocupe todo el panel
            PanelInicio.Controls.Clear(); // Limpia cualquier control que esté previamente en el panel
            PanelInicio.Controls.Add(frmapuestas);  // Añade el formulario al panel
            frmapuestas.Show(); // Muestra el formulario dentro del panel
        }
    }
}
