using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public class clsCLIENTE
    {
        public int  Id { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }  
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; } 
        public string Estado { get; set; } 
        public string RFC { get; set; } 
        public string RazonSocial { get; set; } 
        public int PersonaId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaNacimiento { get; set; } 
        public int EstadoId { get; set; }   


    }
}
