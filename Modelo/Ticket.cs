using System;
using System.Collections.Generic;

namespace PitchWin.Modelo
{
    public class Ticket
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }  // Clave foránea hacia Usuario
        public Usuario Usuario { get; set; } // Relación de navegación

        public string EquipoLocal { get; set; }
        public string EquipoVisitante { get; set; }
        public decimal Monto { get; set; }
        public string TipoCuota { get; set; }

        // Usamos Estado en lugar de Pagado
        public string Estado { get; set; } = "Pendiente";

        // Fecha de pago, es null si no se ha pagado
        public DateTime? FechaPago { get; set; }

        public DateTime FechaApuesta { get; set; }
        public decimal GananciaEstimada { get; set; }

        public ICollection<Apuesta> Apuestas { get; set; }
    }
}
