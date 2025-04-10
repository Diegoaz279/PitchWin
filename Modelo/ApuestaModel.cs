// Modelo: ApuestaModel.cs
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PitchWin.Modelo
{
    public class ApuestaModel
    {
        public async Task<JArray> ObtenerPartidosDelDiaAsync()
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
                    return partidos;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar los partidos: " + ex.Message);
            }
        }

        public async Task<string> ObtenerLogoEquipoAsync(string nombreEquipo)
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
                            return logoUrl;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar logo: " + ex.Message);
            }

            return string.Empty;
        }
    }
}
