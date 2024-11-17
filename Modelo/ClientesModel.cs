using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuSaludEnTusHuesos.Modelo
{
    internal class ExpedienteModel
    {
        public int IdExpediente { get; set; }
        public int IdRegistroLlegada { get; set; }
        public int IdPaciente { get; set; }
        public int? IdRecepcionista { get; set; } // Puede ser nulo
        public int? IdDoctor { get; set; } // Puede ser nulo
        public int? Edad { get; set; } // Puede ser nulo
        public string? Sexo { get; set; } // Puede ser nulo
        public string? EstadoCivil { get; set; } // Puede ser nulo
        public string? GrupoSanguineo { get; set; } // Puede ser nulo
        public string? FactorRH { get; set; } // Puede ser nulo
        public string? AlergiasConocidas { get; set; } // Puede ser nulo
        public string? CondicionesPreexistentes { get; set; } // Puede ser nulo
        public string? MedicamentosActuales { get; set; } // Puede ser nulo
        public string? VacunasRecibidas { get; set; } // Puede ser nulo
        public string? HistorialEnfermedades { get; set; } // Puede ser nulo
        public string? CirugiasPrevias { get; set; } // Puede ser nulo
        public string? HospitalizacionesPrevias { get; set; } // Puede ser nulo
        public string? HistorialFamiliar { get; set; } // Puede ser nulo
        public string? NombreContactoEmergencia { get; set; } // Puede ser nulo
        public string? RelacionContactoEmergencia { get; set; } // Puede ser nulo
        public string? TelefonoContactoEmergencia { get; set; } // Puede ser nulo
        public string? DireccionContactoEmergencia { get; set; } // Puede ser nulo
        public string? MotivoConsulta { get; set; } // Puede ser nulo
        public string? SintomasActuales { get; set; } // Puede ser nulo
        public string? DiagnosticoPreliminar { get; set; } // Puede ser nulo
        public string? TratamientoRecomendaciones { get; set; } // Puede ser nulo
        public DateTime? FechaCreacion { get; set; } // Puede ser nulo
    }
}
