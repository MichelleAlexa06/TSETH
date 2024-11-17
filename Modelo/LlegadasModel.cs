using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuSaludEnTusHuesos.Modelo
{
    internal class LlegadasModel
    {
        public int IdRegistro { get; set; }
        public int IdCita { get; set; }
        public DateTime FechaLlegada { get; set; }
        public TimeSpan HoraLlegada { get; set; }
    }
}
