using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace PitchWin.Modelo
{
    public class StatsApiService : IApiStatsService
    {
        private readonly HttpClient _client;
        private const string BaseUrl = "https://statsapi.mlb.com/api/v1/schedule?sportId=1&date=";

        public StatsApiService()
        {
            _client = new HttpClient();
        }

        public async Task<List<GameInfo>> ObtenerJuegosPorFecha(DateTime fecha)
        {
            string url = BaseUrl + fecha.ToString("yyyy-MM-dd");
            var response = await _client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string jsonResponse = await response.Content.ReadAsStringAsync();

            var schedule = JsonConvert.DeserializeObject<ScheduleResponse>(jsonResponse);
            if (schedule != null && schedule.Dates != null && schedule.Dates.Count > 0)
            {
                return schedule.Dates[0].Games;
            }
            return new List<GameInfo>();
        }
    }
}
