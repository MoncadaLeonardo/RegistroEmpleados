using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Horarios
    {
        public int IdHorario { get; set; }
        public string HorarioColaborador { get; set; }  // O podrías usar DateTime HoraInicio y HoraFin
        public bool Activo { get; set; } // Cambio de 'Vigente' a 'Activo' por consistencia
        public int IdUsuarioRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? IdUsuarioActualiza { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }

}
