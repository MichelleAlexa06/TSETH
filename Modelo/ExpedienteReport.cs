using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuSaludEnTusHuesos.Modelo
{
    internal class ExpedienteReport
    {
        public int IdExpediente { get; set; }
        public string NombrePaciente { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string EstadoCivil { get; set; }
        public string GrupoSanguineo { get; set; }
        public string FactorRH { get; set; }
        public string MotivoConsulta { get; set; }
    }
}
