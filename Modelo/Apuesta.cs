namespace PitchWin.Modelo
{
    public class Apuesta
    {
        public int Id { get; set; }
        public int TicketId { get; set; }  // Clave foránea hacia Ticket
        public Ticket Ticket { get; set; } // Relación de navegación

        public string TipoApuesta { get; set; } // Por ejemplo, "Local", "Visitante", "Empate"
        public decimal GananciaEstimad { get; set; }
    }
}
