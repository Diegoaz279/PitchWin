using System;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Data.SqlClient;

public class RepositorioUsuario
{
    private string _conexionString;

    public RepositorioUsuario()
    {
        _conexionString = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;
    }

    // Método para validar el usuario con la contraseña cifrada
    public bool ValidarUsuario(string usuarioo, string contrasena)
    {
        // Cifra la contraseña proporcionada por el usuario
        string contrasenaCifrada = Seguridad.CifrarContrasena(contrasena);

        using (SqlConnection conexion = new SqlConnection(_conexionString))
        {
            string query = "SELECT COUNT(*) FROM Usuario WHERE Usuarioo = @Usuarioo AND Contrasena = @Contrasena";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@Usuarioo", usuarioo);
            command.Parameters.AddWithValue("@Contrasena", contrasenaCifrada); // Compara con la contraseña cifrada

            conexion.Open();
            int count = (int)command.ExecuteScalar();

            // Si count > 0, las credenciales son correctas
            return count > 0;
        }
    }
}
