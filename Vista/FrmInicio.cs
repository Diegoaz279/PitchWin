using Newtonsoft.Json.Linq;
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
    public partial class FrmInicioo : Form
    {
        public FrmInicioo()
        {
            InitializeComponent();
            _ = CargarPartidoDelDia();

        }
        private async Task CargarPartidoDelDia()
        {
            try
            {
                string apiKey = "acb63c7f1d05bed289bb8be033d5dc5b";
                string url = $"https://api.the-odds-api.com/v4/sports/baseball_mlb/odds/?regions=us&markets=h2h&apiKey={apiKey}";

                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync(url);
                    var json = await response.Content.ReadAsStringAsync();
                    JArray partidos = JArray.Parse(json);

                    if (partidos.Count > 0)
                    {
                        var partido = partidos[1];
                        string equipoLocal = partido["home_team"].ToString();
                        string equipoVisitante = partido["away_team"].ToString();
                        string horaPartido = DateTime.Parse(partido["commence_time"].ToString()).ToLocalTime().ToString("hh:mm tt");

                        // Cargar los nombres de los equipos en los labels
                        lblInicio1.Text = equipoLocal;
                        lblInicio2.Text = equipoVisitante;

                        await CargarLogoEquipo(equipoLocal, pictureBoxInicio1);
                        await CargarLogoEquipo(equipoVisitante, pictureBoxInicio2);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el partido: " + ex.Message);
            }
        }

        private async Task CargarLogoEquipo(string nombreEquipo, PictureBox pictureBox)
        {
            try
            {
                string urlEquipos = "https://site.api.espn.com/apis/site/v2/sports/baseball/mlb/teams";
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync(urlEquipos);
                    var json = await response.Content.ReadAsStringAsync();
                    JObject root = JObject.Parse(json);

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
        private void btnApostarIncio_Click(object sender, EventArgs e)
        {
           FrmApuestas frmApuestas = new FrmApuestas();
            frmApuestas.ShowDialog();
        }

    }
}
