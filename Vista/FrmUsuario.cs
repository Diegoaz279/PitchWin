using PitchWin;
using PitchWin.Presentador;
using PitchWin.Vista;

namespace PitchWin
{
    public partial class FrmUsuario : Form, ILoginVista
    {
        private readonly LoginPresentador _presentador;
        public FrmUsuario()
        {
            InitializeComponent();
            _presentador = new LoginPresentador(this); // Crear una instancia del presentador
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuarioo = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            _presentador.IniciarSesion(usuarioo, contrasena); // Llamar al presentador para validar las credenciales
        }
        // Método para mostrar mensajes en la vista (como mensajes de error o éxito)
        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
        public void CerrarFormulario()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
