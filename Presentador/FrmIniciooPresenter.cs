using Newtonsoft.Json.Linq;
using PitchWin.Modelo;
using PitchWin.Vista;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace PitchWin.Presentador
{
    public class FrmIniciooPresenter
    {
        private readonly IFrmInicioo _vista;
        private readonly IApiMLBService _apiService;

        public FrmIniciooPresenter(IFrmInicioo vista)
        {
            _vista = vista;
            _apiService = new ApiMLBService();
        }

        public async Task CargarPartidosDelDia()
        {
            try
            {
                var partidos = await _apiService.ObtenerPartidosDelDia();
                if (partidos.Count > 0)
                {
                    // Por ejemplo, usamos el primer partido de la lista.
                    var partido = partidos[0];
                    string equipoLocal = partido.EquipoLocal;
                    string equipoVisitante = partido.EquipoVisitante;
                    string horaPartido = partido.HoraPartido.ToString("hh:mm tt");

                    // Actualiza la vista
                    _vista.SetEquipoLocal(equipoLocal);
                    _vista.SetEquipoVisitante(equipoVisitante);
                    _vista.SetHoraPartido(horaPartido);

                    // Cargar logos
                    string logoLocal = await _apiService.ObtenerLogoEquipo(equipoLocal);
                    string logoVisitante = await _apiService.ObtenerLogoEquipo(equipoVisitante);
                    _vista.SetLogoEquipoLocal(logoLocal);
                    _vista.SetLogoEquipoVisitante(logoVisitante);
                }
            }
            catch (Exception ex)
            {
                await _vista.ShowError("Error al cargar partidos: " + ex.Message);
            }
        }
    }
}
