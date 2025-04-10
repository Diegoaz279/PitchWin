public class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Usuarioo { get; set; }
    public string Contrasena { get; set; }
    public DateTime FechaRegistro { get; set; }

    // Constructor
    public Usuario(int id, string nombre, string usuarioo, string contrasena, DateTime fechaRegistro)
    {
        Id = id;
        Nombre = nombre;
        Usuarioo = usuarioo;
        Contrasena = contrasena;
        FechaRegistro = fechaRegistro;
    }
}