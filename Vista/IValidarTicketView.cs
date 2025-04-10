using System;

namespace PitchWin.Vista
{
    public interface IValidarTicketView
    {
        // Los datos que se mostrarán o se usarán para validar el ticket:
        // Por ejemplo, los datos contenidos en el ticket que se quiere validar.
        string EquipoLocal { get; }
        string EquipoVisitante { get; }
        DateTime FechaJuego { get; }  // Fecha del juego (para la consulta en la API)
        string TipoApuestaSeleccionado { get; } // "Local", "Visitante" o "Empate" (lo que se apostó)

        // Métodos para mostrar el resultado de la validación
        void MostrarMensaje(string mensaje);
    }
}
