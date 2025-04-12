using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace PitchWin.Modelo
{
    public class ApiMLBService : IApiMLBService
    {
        private readonly HttpClient _client;
        private readonly string _apiKey = "183299f8ef0bba52382876bb7745c3e6";  //API key
        private readonly string _urlPartidos = "https://api.the-odds-api.com/v4/sports/baseball_mlb/odds/";
        private readonly string _urlEquipos = "https://site.api.espn.com/apis/site/v2/sports/baseball/mlb/teams";

        public ApiMLBService()
        {
            _client = new HttpClient();
        }

        // Devuelve TODOS los partidos del día
        public async Task<List<Partido>> ObtenerPartidosDelDia()
        {
            try
            {
                string url = $"{_urlPartidos}?regions=us&markets=h2h&apiKey={_apiKey}";
                var response = await _client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string jsonResponse = await response.Content.ReadAsStringAsync();
                JArray array = JArray.Parse(jsonResponse);

                List<Partido> partidos = new List<Partido>();

                foreach (var p in array)
                {
                    Partido partido = new Partido
                    {
                        EquipoLocal = p["home_team"].ToString(),
                        EquipoVisitante = p["away_team"].ToString(),
                        HoraPartido = DateTime.Parse(p["commence_time"].ToString()).ToLocalTime()
                    };
                    partidos.Add(partido);
                }
                return partidos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los partidos del día", ex);
            }
        }

        // Obtiene la URL del logo de un equipo dado su nombre
        public async Task<string> ObtenerLogoEquipo(string nombreEquipo)
        {
            try
            {
                var response = await _client.GetAsync(_urlEquipos);
                response.EnsureSuccessStatusCode();
                string jsonResponse = await response.Content.ReadAsStringAsync();
                JObject root = JObject.Parse(jsonResponse);
                var equipos = root["sports"][0]["leagues"][0]["teams"];

                foreach (var equipo in equipos)
                {
                    var team = equipo["team"];
                    if (team["displayName"].ToString().Equals(nombreEquipo, StringComparison.OrdinalIgnoreCase))
                    {
                        return team["logos"]?[0]?["href"]?.ToString() ?? string.Empty;
                    }
                }

                // Si no se encuentra el equipo, devuelve string vacío
                return string.Empty;
            }
            catch
            {
                // Si ocurre un error, también devuelve string vacío
                return string.Empty;
            }
        }

    }
}
