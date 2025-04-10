using System;
using System.Windows.Forms;
using PitchWin.Vista;
using PlayerUI; // Aseg�rate de incluir el namespace adecuado

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
                // Se asume que FrmUsuario asignar� DialogResult.OK al iniciar sesi�n exitosamente
                if (login.ShowDialog() == DialogResult.OK)
                {
                    // Si el login es correcto, se lanza el formulario principal
                    Application.Run(new FrmMenuPrincipal());
                }
                else
                {
                    // Si se cierra el login sin autenticaci�n, se cierra la aplicaci�n.
                    Application.Exit();
                }
            }
        }
    }
}
