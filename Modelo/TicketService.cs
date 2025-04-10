using PitchWin.Modelo;
using System;
using System.Threading.Tasks;

namespace PitchWin.Presentador
{
    public class TicketService
    {
        private readonly PitchWinDbContext _context;

        public TicketService(PitchWinDbContext context)
        {
            _context = context;
        }

        public async Task<int> GuardarTicketAsync(Ticket ticket)
        {
            try
            {
                _context.Tickets.Add(ticket);
                await _context.SaveChangesAsync();
                return ticket.Id;
            }
            catch (Exception ex)
            {
                // Extraer y lanzar el mensaje de la inner exception para depuración
                string errorMsg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error al guardar el ticket: " + errorMsg, ex);
            }
        }
    }
}
