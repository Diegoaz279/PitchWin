using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitchWin.Vista
{
    public interface ILoginVista
    {
        // Otros métodos (como MostrarMensaje, etc.)
        void MostrarMensaje(string mensaje);

        // Método para cerrar el formulario de login
        void CerrarFormulario();
    }
}
