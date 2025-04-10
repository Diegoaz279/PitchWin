using System.Threading.Tasks;

namespace PitchWin.Vista
{
    public interface IFrmInicioo
    {
        void SetEquipoLocal(string equipoLocal);
        void SetEquipoVisitante(string equipoVisitante);
        void SetHoraPartido(string horaPartido);
        void SetLogoEquipoLocal(string logoUrl);
        void SetLogoEquipoVisitante(string logoUrl);
        Task ShowError(string mensaje);
    }
}
