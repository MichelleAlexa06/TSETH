using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuSaludEnTusHuesos.Modelo
{
    internal class CitasModelo
    {
        public int IdCita { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string TipoCita { get; set; }
        public string Doctor { get; set; }
        public string Especialidad { get; set; }
        public string Paciente { get; set; }
    }
}
