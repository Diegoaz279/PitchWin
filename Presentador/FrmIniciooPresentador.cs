using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using PitchWin.Vista;

namespace PitchWin.Presentador
{
    public class FrmIniciooPresentador
    {
        private readonly IFrmInicioo _vista;

        public FrmIniciooPresentador(IFrmInicioo vista)
        {
            _vista = vista;
        }

        public async Task CargarPartidosDelDia()
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
                        var partido = partidos[1]; // Suponiendo que el índice 1 contiene el primer partido

                        string equipoLocal = partido["home_team"].ToString();
                        string equipoVisitante = partido["away_team"].ToString();

                        _vista.SetEquipoLocal(equipoLocal);
                        _vista.SetEquipoVisitante(equipoVisitante);         

                        // Cargar los logos de los equipos
                        await CargarLogoEquipo(equipoLocal, equipoVisitante);
                    }
                }
            }
            catch (Exception ex)
            {
                await _vista.ShowError("Error al cargar el partido: " + ex.Message);
            }
        }

        private async Task CargarLogoEquipo(string equipoLocal, string equipoVisitante)
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
                        string logoUrl = team["logos"][0]["href"].ToString();

                        // Si es el equipo local
                        if (nombre.Equals(equipoLocal, StringComparison.OrdinalIgnoreCase))
                        {
                            _vista.SetLogoEquipoLocal(logoUrl);
                        }

                        // Si es el equipo visitante
                        if (nombre.Equals(equipoVisitante, StringComparison.OrdinalIgnoreCase))
                        {
                            _vista.SetLogoEquipoVisitante(logoUrl);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                await _vista.ShowError("Error al cargar logo: " + ex.Message);
            }
        }
    }
}
