using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using PitchWin.Presentador;
using PitchWin.Modelo;
using PlayerUI;


namespace PitchWin.Vista
{
    public partial class FrmApuestas : Form, IFrmApuestas
    {
        private readonly ApuestasPresentador _presentador;

        public FrmApuestas()
        {
            InitializeComponent();
            // Se asume que creaste e inyectaste la implementación de ApiMLBService
            _presentador = new ApuestasPresentador(this, new ApiMLBService());
            _ = _presentador.CargarPartidosDelDia();
        }

        // Implementación de IFrmApuestas para actualizar la información de los partidos
        public void SetPartidoData(int partidoNumero, string equipoLocal, string equipoVisitante, string horaPartido, string logoLocalUrl, string logoVisitanteUrl)
        {
            switch (partidoNumero)
            {
                case 1:
                    lblPartido1_1.Text = equipoLocal;
                    lblPartido1_2.Text = equipoVisitante;
                    lblHoraPartido1.Text = horaPartido;
                    pictureBoxPartido1_1.Load(logoLocalUrl);
                    pictureBoxPartido1_2.Load(logoVisitanteUrl);
                    break;
                case 2:
                    lblPartido2_1.Text = equipoLocal;
                    lblPartido2_2.Text = equipoVisitante;
                    lblHoraPartido2.Text = horaPartido;
                    pictureBoxPartido2_1.Load(logoLocalUrl);
                    pictureBoxPartido2_2.Load(logoVisitanteUrl);
                    break;
                case 3:
                    lblPartido3_1.Text = equipoLocal;
                    lblPartido3_2.Text = equipoVisitante;
                    lblHoraPartido3.Text = horaPartido;
                    pictureBoxPartido3_1.Load(logoLocalUrl);
                    pictureBoxPartido3_2.Load(logoVisitanteUrl);
                    break;
                case 4:
                    lblPartido4_1.Text = equipoLocal;
                    lblPartido4_2.Text = equipoVisitante;
                    lblHoraPartido4.Text = horaPartido;
                    pictureBoxPartido4_1.Load(logoLocalUrl);
                    pictureBoxPartido4_2.Load(logoVisitanteUrl);
                    break;
                default:
                    break;
            }
        }

        public async Task ShowError(string mensaje)
        {
            await Task.Run(() =>
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            );
        } 
        private void btnApostar1_Click(object sender, EventArgs e)
        {
            // Crear el objeto Partido con los datos del primer partido.
            // Asegúrate de que lblPartido1_1, lblPartido1_2 y lblHoraPartido1 contengan la información correcta.
            var partidoSeleccionado = new Partido
            {
                EquipoLocal = lblPartido1_1.Text,
                EquipoVisitante = lblPartido1_2.Text,
                // Si lblHoraPartido1 solo contiene la hora (ej. "10:30 AM"), podrías combinarla con la fecha actual:
                HoraPartido = DateTime.Parse(lblHoraPartido1.Text) // O ajustar según tu formato de fecha/hora
            };

            // Instanciar el DbContext (sin usar 'using' para evitar que se deseche antes de usarlo en FrmDetallesApuesta).
            var dbContext = new PitchWinDbContext();

            // Crear la instancia del formulario de Detalle de Apuesta.
            FrmDetallesApuesta frmDetalle = new FrmDetallesApuesta(partidoSeleccionado, dbContext);

            // Configurar el formulario para que se muestre incrustado (no modal).
            frmDetalle.TopLevel = false;
            frmDetalle.FormBorderStyle = FormBorderStyle.None;
            frmDetalle.Dock = DockStyle.Fill;

            // Verificar si este formulario (FrmApuestas) tiene asignado un Owner que sea FrmMenuPrincipal.
            if (this.Owner is FrmMenuPrincipal frmMenu)
            {
                // Usar el método del formulario principal para abrir el formulario hijo.
                frmMenu.AbrirFormularioHijo(frmDetalle);
            }
            else
            {
                MessageBox.Show("No se puedo Seleccionar el partido");
            }
        }
        private void btnApostar2_Click(object sender, EventArgs e)
        {
            var partidoSeleccionado = new Partido
            {
                EquipoLocal = lblPartido2_1.Text,
                EquipoVisitante = lblPartido2_2.Text,

                HoraPartido = DateTime.Parse(lblHoraPartido2.Text)
            };

            var dbContext = new PitchWinDbContext();
            // Crear la instancia del formulario de Detalle de Apuesta.
            FrmDetallesApuesta frmDetalle = new FrmDetallesApuesta(partidoSeleccionado, dbContext);

            // Configurar el formulario para que se muestre incrustado (no modal).
            frmDetalle.TopLevel = false;
            frmDetalle.FormBorderStyle = FormBorderStyle.None;
            frmDetalle.Dock = DockStyle.Fill;

            // Verificar si este formulario (FrmApuestas) tiene asignado un Owner que sea FrmMenuPrincipal.
            if (this.Owner is FrmMenuPrincipal frmMenu)
            {
                // Usar el método del formulario principal para abrir el formulario hijo.
                frmMenu.AbrirFormularioHijo(frmDetalle);
            }
            else
            {
                MessageBox.Show("No se puedo Seleccionar el partido");
            }
        }

        private void btnApostar3_Click(object sender, EventArgs e)
        {
            var partidoSeleccionado = new Partido
            {
                EquipoLocal = lblPartido3_1.Text,
                EquipoVisitante = lblPartido3_2.Text,

                HoraPartido = DateTime.Parse(lblHoraPartido3.Text)
            };

            var dbContext = new PitchWinDbContext();
            // Crear la instancia del formulario de Detalle de Apuesta.
            FrmDetallesApuesta frmDetalle = new FrmDetallesApuesta(partidoSeleccionado, dbContext);

            // Configurar el formulario para que se muestre incrustado (no modal).
            frmDetalle.TopLevel = false;
            frmDetalle.FormBorderStyle = FormBorderStyle.None;
            frmDetalle.Dock = DockStyle.Fill;

            // Verificar si este formulario (FrmApuestas) tiene asignado un Owner que sea FrmMenuPrincipal.
            if (this.Owner is FrmMenuPrincipal frmMenu)
            {
                // Usar el método del formulario principal para abrir el formulario hijo.
                frmMenu.AbrirFormularioHijo(frmDetalle);
            }
            else
            {
                MessageBox.Show("No se puedo Seleccionar el partido");
            }
        }

        private void btnApostar4_Click(object sender, EventArgs e)
        {          
            var partidoSeleccionado = new Partido
            {
                EquipoLocal = lblPartido4_1.Text,
                EquipoVisitante = lblPartido4_2.Text,
               
                HoraPartido = DateTime.Parse(lblHoraPartido4.Text) 
            };
       
            var dbContext = new PitchWinDbContext();
            // Crear la instancia del formulario de Detalle de Apuesta.
            FrmDetallesApuesta frmDetalle = new FrmDetallesApuesta(partidoSeleccionado, dbContext);

            // Configurar el formulario para que se muestre incrustado (no modal).
            frmDetalle.TopLevel = false;
            frmDetalle.FormBorderStyle = FormBorderStyle.None;
            frmDetalle.Dock = DockStyle.Fill;

            // Verificar si este formulario (FrmApuestas) tiene asignado un Owner que sea FrmMenuPrincipal.
            if (this.Owner is FrmMenuPrincipal frmMenu)
            {
                // Usar el método del formulario principal para abrir el formulario hijo.
                frmMenu.AbrirFormularioHijo(frmDetalle);
            }
            else
            {
                MessageBox.Show("No se puedo Seleccionar el partido");
            }
        }

       
    }
}
    