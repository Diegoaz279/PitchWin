using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PitchWin.Modelo
{
    public interface IApiStatsService
    {
        Task<List<GameInfo>> ObtenerJuegosPorFecha(DateTime fecha);
    }
}
