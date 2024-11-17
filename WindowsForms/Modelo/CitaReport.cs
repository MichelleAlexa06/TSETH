using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuSaludEnTusHuesos.Modelo
{
    internal class CitaReport
    {
        public int IdCita { get; set; }
        public string NombrePaciente { get; set; }
        public DateTime FechaCita { get; set; }
        public TimeSpan HoraCita { get; set; }
        public string NombreDoctor { get; set; }
        public string TipoCita { get; set; }
    }
}
