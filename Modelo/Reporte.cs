public class Reporte
{
    public int Id { get; set; }
    public DateTime FechaReporte { get; set; }
    public int TotalTickets { get; set; }
    public int Ganadores { get; set; }
    public int Perdedores { get; set; }
    public decimal VentaTotal { get; set; }
    public decimal GananciaTotal { get; set; }
    public int TicketsSinPagar { get; set; }
    public decimal MontoTicketsSinPagar { get; set; }
}
