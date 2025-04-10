using System;
using System.Threading.Tasks;
using PitchWin.Modelo;
using PitchWin.Vista;

namespace PitchWin.Presentador
{
    public class PartidoPresentador
    {
        private readonly IFrmInicioo _vista;
        private readonly ApuestaModel _apiPartidos;
        private readonly ApiEquipos _apiEquipos;

        public PartidoPresentador(IFrmInicioo vista)
        {
            _vista = vista;
            _apiPartidos = new ApuestaModel();
            _apiEquipos = new ApiEquipos();
        }

        // Método para cargar el partido del día y los logos de los equipos
        public async Task CargarPartidosDelDia()
        {
            try
            {
                // Obtener los partidos del día desde la API
                var partidos = await _apiPartidos.ObtenerPartidosDelDiaAsync();

                if (partidos != null && partidos.Count > 0)
                {
                    // Tomamos los primeros 4 partidos (si hay suficientes)
                    for (int i = 0; i < 4 && i < partidos.Count; i++)
                    {
                    }
                }
                else
                {
                    _vista.ShowError("No se pudo cargar los partidos del día.");
                }
            }
            catch (Exception ex)
            {
                _vista.ShowError("Error al cargar los datos: " + ex.Message);
            }
        }
    }
}
