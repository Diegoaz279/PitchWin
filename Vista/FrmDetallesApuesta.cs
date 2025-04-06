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
    public partial class FrmDetallesApuesta : Form
    {
        // Cuotas de ejemplo para cada tipo de apuesta
        private decimal cuotaEquipoLocal = 1.8m;
        private decimal cuotaEquipoVisitante = 2.0m;
        private decimal cuotaEmpate = 3.0m;
        public FrmDetallesApuesta()
        {
            InitializeComponent();
            // Llamamos al método para cargar los detalles de la apuesta
            CargarEquipos();
            
        }
        // Método para cargar los equipos disponibles para apostar en los ComboBox
        private void CargarEquipos()
        {
            try
            {
                // Aquí deberías tener la lógica para obtener dinámicamente los equipos disponibles de la API o de la base de datos
                // Para este ejemplo, vamos a usar nombres estáticos de equipos
                cmbConfirmacionDeApuestaEquipo.Items.Clear();
                cmbConfirmacionDeApuestaEquipo.Items.Add("New York Yankees");
                cmbConfirmacionDeApuestaEquipo.Items.Add("Boston Red Sox");
                cmbConfirmacionDeApuestaEquipo.Items.Add("Chicago Cubs");
                cmbConfirmacionDeApuestaEquipo.Items.Add("Los Angeles Dodgers");

                // Si ya hay un equipo seleccionado, cargamos los tipos de apuesta correspondientes
                if (cmbConfirmacionDeApuestaEquipo.SelectedItem != null)
                {
                    CargarTiposDeApuesta();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los equipos: " + ex.Message);
            }
        }
        // Método para cargar los tipos de apuesta según el equipo seleccionado
        private void CargarTiposDeApuesta()
        {
            try
            {
                cmbConfirmacionDeApuestaTipoApuesta.Items.Clear();
                string equipoSeleccionado = cmbConfirmacionDeApuestaEquipo.SelectedItem.ToString();

                // Lógica para cargar los tipos de apuesta basados en el equipo seleccionado
                if (equipoSeleccionado == "New York Yankees" || equipoSeleccionado == "Boston Red Sox")
                {
                    cmbConfirmacionDeApuestaTipoApuesta.Items.Add("Equipo Local");
                    cmbConfirmacionDeApuestaTipoApuesta.Items.Add("Equipo Visitante");
                    cmbConfirmacionDeApuestaTipoApuesta.Items.Add("Empate");
                }
                else
                {
                    cmbConfirmacionDeApuestaTipoApuesta.Items.Add("Equipo Local");
                    cmbConfirmacionDeApuestaTipoApuesta.Items.Add("Equipo Visitante");
                }

                cmbConfirmacionDeApuestaTipoApuesta.SelectedIndex = 0; // Seleccionamos el primer tipo de apuesta por defecto
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los tipos de apuesta: " + ex.Message);
            }
        }
        private void txtConfirmacionApuestaMonto_TextChanged(object sender, EventArgs e)
        {
            CalcularGananciaEstimada();
        }

        private void cmbConfirmacionDeApuestaTipoApuesta_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularGananciaEstimada();
        }
        private void cmbConfirmacionDeApuestaEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarTiposDeApuesta();
            CalcularGananciaEstimada();
            CargarDetallesApuesta();
        }
        // Método para calcular la ganancia estimada en tiempo real
        // Método para calcular la ganancia estimada en tiempo real
        private void CalcularGananciaEstimada()
        {
            try
            {
                // Validamos que los campos estén completos
                if (cmbConfirmacionDeApuestaEquipo.SelectedItem != null &&
                    cmbConfirmacionDeApuestaTipoApuesta.SelectedItem != null &&
                    !string.IsNullOrEmpty(txtConfirmacionApuestaMonto.Text))
                {
                    // Recuperamos el monto de la apuesta
                    decimal montoApuesta = decimal.Parse(txtConfirmacionApuestaMonto.Text);

                    // Calculamos la ganancia estimada dependiendo del tipo de apuesta
                    string tipoApuesta = cmbConfirmacionDeApuestaTipoApuesta.SelectedItem.ToString();
                    decimal gananciaEstimada = 0;

                    // Comprobamos el tipo de apuesta seleccionada
                    if (tipoApuesta == "Equipo Local")
                    {
                        gananciaEstimada = montoApuesta * cuotaEquipoLocal;
                    }
                    else if (tipoApuesta == "Equipo Visitante")
                    {
                        gananciaEstimada = montoApuesta * cuotaEquipoVisitante;
                    }
                    else if (tipoApuesta == "Empate")
                    {
                        gananciaEstimada = montoApuesta * cuotaEmpate;
                    }

                    // Mostramos la ganancia estimada en el TextBox
                    txtConfirmacionApuestaGnanciaEstimada.Text = gananciaEstimada.ToString("C");
                }
                else
                {
                    // Limpiamos la ganancia estimada si falta algún dato
                    txtConfirmacionApuestaGnanciaEstimada.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular la ganancia estimada: " + ex.Message);
            }
        }

        // Método para cargar los detalles de la apuesta (equipos, logos, etc.)
        private async void CargarDetallesApuesta()
        {
            try
            {
                // Ejemplo de equipos seleccionados
                string equipoLocal = cmbConfirmacionDeApuestaEquipo.SelectedItem.ToString();
                string equipoVisitante = "Boston Red Sox"; // Esto debería ser dinámico, dependiendo de la selección

                lbldetalleapuesta1.Text = equipoLocal;
                lbldetalleapuesta2.Text = equipoVisitante;

                // Cargar los logos de los equipos en los PictureBox
                await CargarLogoEquipo(equipoLocal, pictureBoxDetalleApuestas1);
                await CargarLogoEquipo(equipoVisitante, pictureBoxDetalleApuestas2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los detalles de la apuesta: " + ex.Message);
            }
        }

        // Método para cargar el logo de los equipos (usando la API de ESPN)
        private async Task CargarLogoEquipo(string nombreEquipo, PictureBox pictureBox)
        {
            try
            {
                string urlEquipos = "https://site.api.espn.com/apis/site/v2/sports/baseball/mlb/teams";
                using (System.Net.Http.HttpClient client = new System.Net.Http.HttpClient())
                {
                    var response = await client.GetAsync(urlEquipos);
                    var json = await response.Content.ReadAsStringAsync();
                    Newtonsoft.Json.Linq.JObject root = Newtonsoft.Json.Linq.JObject.Parse(json);

                    var equipos = root["sports"][0]["leagues"][0]["teams"];
                    foreach (var equipo in equipos)
                    {
                        var team = equipo["team"];
                        var nombre = team["displayName"].ToString();

                        if (nombre.Equals(nombreEquipo, StringComparison.OrdinalIgnoreCase))
                        {
                            string logoUrl = team["logos"][0]["href"].ToString();
                            pictureBox.Load(logoUrl);
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar logo: " + ex.Message);
            }
        }
        private void btnConfirmarApuesta_Click(object sender, EventArgs e)
        {

            // Aquí puedes agregar la lógica para guardar la apuesta o procesarla
            MessageBox.Show("Apuesta confirmada!");
        }

        
    }
}
