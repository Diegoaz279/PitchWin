using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Newtonsoft.Json.Linq;


namespace PitchWin.Vista
{
    public partial class FrmApuestas : Form
    {
        public FrmApuestas()
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
                        // Cargar el primer partido.
                        var partido1 = partidos[0];
                        string equipoLocal1 = partido1["home_team"].ToString();
                        string equipoVisitante1 = partido1["away_team"].ToString();
                        string horaPartido1 = DateTime.Parse(partido1["commence_time"].ToString()).ToLocalTime().ToString("hh:mm tt");

                        // Cargar el segundo partido.
                        var partido2 = partidos[1];
                        string equipoLocal2 = partido2["home_team"].ToString();
                        string equipoVisitante2 = partido2["away_team"].ToString();
                        string horaPartido2 = DateTime.Parse(partido2["commence_time"].ToString()).ToLocalTime().ToString("hh:mm tt");

                        // Cargar el tercer partido.
                        var partido3 = partidos[2];
                        string equipoLocal3 = partido3["home_team"].ToString();
                        string equipoVisitante3 = partido3["away_team"].ToString();
                        string horaPartido3 = DateTime.Parse(partido3["commence_time"].ToString()).ToLocalTime().ToString("hh:mm tt");

                        // Cargar el cuarto partido.
                        var partido4 = partidos[3];
                        string equipoLocal4 = partido4["home_team"].ToString();
                        string equipoVisitante4 = partido4["away_team"].ToString();
                        string horaPartido4 = DateTime.Parse(partido4["commence_time"].ToString()).ToLocalTime().ToString("hh:mm tt");

                        // Asignar los logos y datos a los PictureBox y Labels
                        await CargarLogoEquipo(equipoLocal1, pictureBoxPartido1_1);
                        await CargarLogoEquipo(equipoVisitante1, pictureBoxPartido1_2);
                        lblPartido1_1.Text = equipoLocal1;
                        lblPartido1_2.Text = equipoVisitante1;
                        lblHoraPartido1.Text = horaPartido1;

                        await CargarLogoEquipo(equipoLocal2, pictureBoxPartido2_1);
                        await CargarLogoEquipo(equipoVisitante2, pictureBoxPartido2_2);
                        lblPartido2_1.Text = equipoLocal2;
                        lblPartido2_2.Text = equipoVisitante2;
                        lblHoraPartido2.Text = horaPartido2;

                        await CargarLogoEquipo(equipoLocal3, pictureBoxPartido3_1);
                        await CargarLogoEquipo(equipoVisitante3, pictureBoxPartido3_2);
                        lblPartido3_1.Text = equipoLocal3;
                        lblPartido3_2.Text = equipoVisitante3;
                        lblHoraPartido3.Text = horaPartido3;

                        await CargarLogoEquipo(equipoLocal4, pictureBoxPartido4_1);
                        await CargarLogoEquipo(equipoVisitante4, pictureBoxPartido4_2);
                        lblPartido4_1.Text = equipoLocal4;
                        lblPartido4_2.Text = equipoVisitante4;
                        lblHoraPartido4.Text = horaPartido4;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los partidos: " + ex.Message);
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

        private void btnApostarIncio1_Click(object sender, EventArgs e)
        {
            FrmDetallesApuesta frmDetallesApuesta = new FrmDetallesApuesta();
            frmDetallesApuesta.ShowDialog();
        }
    }
}
    