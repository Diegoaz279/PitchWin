using Newtonsoft.Json.Linq;

public class ApiEquipos
{
    public async Task<string> ObtenerLogoEquipoAsync(string nombreEquipo)
    {
        string logoUrl = string.Empty;
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

                // Verificación para ver si el nombre del equipo es correcto
                Console.WriteLine($"Buscando logo para: {nombre}");

                if (nombre.Equals(nombreEquipo, StringComparison.OrdinalIgnoreCase))
                {
                    logoUrl = team["logos"][0]["href"].ToString();
                    break;
                }
            }
        }

        return logoUrl;
    }
}