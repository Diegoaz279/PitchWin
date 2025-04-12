using PitchWin.Modelo;
using PitchWin.Vista;
using PlayerUI;
using System;

namespace PitchWin.Presentador
{   
    //Esta clase tiene una única responsabilidad: gestionar el inicio de sesión.
    public class LoginPresentador
    {
    private readonly ILoginVista _vista;
    private readonly RepositorioUsuario _repositorioUsuario;

    public LoginPresentador(ILoginVista vista)
    {
        _vista = vista;
        _repositorioUsuario = new RepositorioUsuario(); // Crear una instancia del repositorio
    }
        
        // Método para manejar el inicio de sesión
        public void IniciarSesion(string usuarioo, string contrasena)
        {
            if (_repositorioUsuario.ValidarUsuario(usuarioo, contrasena))
            {
                _vista.MostrarMensaje("Inicio de sesión exitoso");
                // Cerrar el formulario de login.
                _vista.CerrarFormulario();

            }
            else
            {
                _vista.MostrarMensaje("Usuario o contraseña incorrectos");
            }
        }

    }
}
