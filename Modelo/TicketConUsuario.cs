namespace PitchWin.Modelo
{
    public class TicketConUsuario
    {
        public string NombreUsuario { get; set; }
        public string EquipoLocal { get; set; }
        public string EquipoVisitante { get; set; }
        public string TipoCuota { get; set; }
        public decimal Monto { get; set; }
        public decimal GananciaEstimada { get; set; }
        public DateTime FechaApuesta { get; set; }
        public string Estado { get; set; }
    }
}
