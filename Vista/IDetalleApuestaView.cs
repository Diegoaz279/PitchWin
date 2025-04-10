using System.Threading.Tasks;

namespace PitchWin.Vista
{
    public interface IDetalleApuestaView
    {
        // Datos del partido
        string EquipoLocal { get; set; }
        string EquipoVisitante { get; set; }
        string HoraPartido { get; set; }

        // Datos ingresados por el usuario para la apuesta
        string TipoApuesta { get; }        // Ejemplo: "Local", "Visitante", "Empate"
        string EquipoApostado { get; }       // Seleccionado en un ComboBox, por ejemplo
        decimal MontoApuesta { get; }        // Ingresado en un TextBox

        // Propiedad para mostrar la ganancia estimada en la vista
        decimal GananciaEstimad { get; set; }

        // Métodos para mostrar mensajes en la vista
        Task MostrarError(string mensaje);
        void MostrarMensaje(string mensaje);
        void MostrarTicket(string mensajeTicket);

        // Método para navegar al formulario de Apuestas
        void NavegarAFrmApuestas();

        // *** Nuevos métodos agregados para cargar logos ***
        void SetLogoEquipoLocal(string logoUrl);
        void SetLogoEquipoVisitante(string logoUrl);
    }
}
