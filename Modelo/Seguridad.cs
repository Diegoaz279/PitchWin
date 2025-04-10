using System.Security.Cryptography;
using System.Text;

public class Seguridad
{
    // Método para cifrar la contraseña con SHA-256
    public static string CifrarContrasena(string contrasena)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(contrasena));
            return BitConverter.ToString(hashBytes).Replace("-", "").ToLower(); // Convierte a formato hexadecimal
        }
    }
}