using System.Collections.Generic;
using System.Threading.Tasks;

namespace PitchWin.Modelo
{
    public interface IApiMLBService
    {
        Task<List<Partido>> ObtenerPartidosDelDia();
        Task<string> ObtenerLogoEquipo(string nombreEquipo);
    }
}
