using System;
using System.Windows.Forms;
using PitchWin.Vista;
using PlayerUI; // Asegúrate de incluir el namespace adecuado

namespace PitchWin
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Mostrar el formulario de login como modal
            using (FrmUsuario login = new FrmUsuario())
            {
                // Se asume que FrmUsuario asignará DialogResult.OK al iniciar sesión exitosamente
                if (login.ShowDialog() == DialogResult.OK)
                {
                    // Si el login es correcto, se lanza el formulario principal
                    Application.Run(new FrmMenuPrincipal());
                }
                else
                {
                    // Si se cierra el login sin autenticación, se cierra la aplicación.
                    Application.Exit();
                }
            }
        }
    }
}
