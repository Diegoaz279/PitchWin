using PitchWin.Modelo;
using PitchWin.Vista;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PitchWin.Presentador
{
    public class ApuestasPresentador
    {
        private readonly IFrmApuestas _vista;
        private readonly IApiMLBService _apiService;

        public ApuestasPresentador(IFrmApuestas vista, IApiMLBService apiService)
        {
            _vista = vista;
            _apiService = apiService;
        }

        public async Task CargarPartidosDelDia()
        {
            try
            {
                List<Partido> partidos = await _apiService.ObtenerPartidosDelDia();
                // Asumamos que la vista dispone de controles para 4 partidos.
                int totalPartidos = Math.Min(partidos.Count, 4);

                for (int i = 0; i < totalPartidos; i++)
                {
                    Partido p = partidos[i];
                    string horaPartido = p.HoraPartido.ToString("hh:mm tt");

                    // Obtener logos de ambos equipos
                    string logoLocal = await _apiService.ObtenerLogoEquipo(p.EquipoLocal);
                    string logoVisitante = await _apiService.ObtenerLogoEquipo(p.EquipoVisitante);

                    // Enviar la información a la vista, indicando el número del partido (i+1)
                    _vista.SetPartidoData(i + 1, p.EquipoLocal, p.EquipoVisitante, horaPartido, logoLocal, logoVisitante);
                }
            }
            catch (Exception ex)
            {
                await _vista.ShowError("Error al cargar los partidos: " + ex.Message);
            }
        }
    }
}
