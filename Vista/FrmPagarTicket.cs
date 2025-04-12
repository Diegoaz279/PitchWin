using PitchWin.Modelo;
using PitchWin.Presentador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PitchWin.Vista
{
    public partial class FrmPagarTicket : Form
    {
        private ValidarTicketPresentador _presentador;

        public FrmPagarTicket()
        {
            InitializeComponent();
            
        }

        public void LimpiarControles()
        {
            txtPagarTicketIdTicket.Clear();
            txtPagarTicketEquipo.Clear();
            txtPagarTicketTipoCuota.Clear();
            txtPagarTicketMonto.Clear();
            txtPagarTicketGanancia.Clear();
            txtPagarTicketFecha.Clear();
        }

        // Botón para verificar el ticket
        private async void btnVerificarTicket_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que se ingrese un ID numérico
                if (!int.TryParse(txtPagarTicketIdTicket.Text, out int ticketId))
                {
                    MessageBox.Show("Ingrese un ID de apuesta válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var context = new PitchWinDbContext())
                {
                    // Buscar el ticket en la base de datos
                    var ticket = await context.Tickets.FindAsync(ticketId);
                    if (ticket == null)
                    {
                        MessageBox.Show("Apuesta no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Usar la API de estadísticas para obtener los juegos de la fecha del ticket
                    var statsService = new StatsApiService();
                    var juegos = await statsService.ObtenerJuegosPorFecha(ticket.FechaApuesta);

                    // Buscar el juego que coincida con el partido del ticket
                    var juego = juegos.Find(g =>
                        string.Equals(g.Teams.Home.Team.Name, ticket.EquipoLocal, StringComparison.OrdinalIgnoreCase) &&
                        string.Equals(g.Teams.Away.Team.Name, ticket.EquipoVisitante, StringComparison.OrdinalIgnoreCase));

                    if (juego == null)
                    {
                        MessageBox.Show("No se encontró el juego para la fecha y equipos indicados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Validar la apuesta según el tipo de cuota (cuota)
                    bool esGanador = false;
                    switch (ticket.TipoCuota.ToLower())
                    {
                        case "local":
                            esGanador = juego.Teams.Home.Score > juego.Teams.Away.Score;
                            break;
                        case "visitante":
                            esGanador = juego.Teams.Away.Score > juego.Teams.Home.Score;
                            break;
                        case "empate":
                            esGanador = juego.Teams.Home.Score == juego.Teams.Away.Score;
                            break;
                    }

                    if (!esGanador)
                    {
                        MessageBox.Show("La apuesta no es ganadora o El juego aún está en Curso.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (ticket.Estado == "Pagado")
                    {
                        MessageBox.Show("El ticket ya se pago y no se puede pagar 2 veces.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        // Si la apuesta es ganadora, actualizar el estado del ticket a "Ganador"
                        ticket.Estado = "Ganador";
                        await context.SaveChangesAsync();
                    }

                    // Cargar la información del ticket en los controles:
                    txtPagarTicketEquipo.Text = $"{ticket.EquipoLocal} vs {ticket.EquipoVisitante}";
                    txtPagarTicketTipoCuota.Text = ticket.TipoCuota;
                    txtPagarTicketMonto.Text = ticket.Monto.ToString("C");
                    txtPagarTicketGanancia.Text = ticket.GananciaEstimada.ToString("C");
                    txtPagarTicketFecha.Text = ticket.FechaApuesta.ToShortDateString();

                    MessageBox.Show("El ticket es ganador.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar la apuesta: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }  

        // Botón para pagar el ticket (si es ganador)
        private async void btnPagarTicket_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtPagarTicketIdTicket.Text, out int ticketId))
                {
                    MessageBox.Show("Ingrese un ID de apuesta válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var context = new PitchWinDbContext())
                {
                    var ticket = await context.Tickets.FindAsync(ticketId);
                    if (ticket == null)
                    {
                        MessageBox.Show("Apuesta no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    //Si no es ganador, no permitir pago
                    if (ticket.Estado != "Ganador")
                    {
                        MessageBox.Show("La apuesta no es ganadora y no puede ser pagada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    //Actualizar a Pagado
                    ticket.Estado = "Pagado";
                    ticket.FechaPago = DateTime.Now;
                    await context.SaveChangesAsync();

                    MessageBox.Show("Apuesta pagada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al pagar la apuesta: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
    

