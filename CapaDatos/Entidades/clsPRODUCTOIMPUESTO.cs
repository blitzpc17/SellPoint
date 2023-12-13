using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public class clsPRODUCTOIMPUESTO
    {
        public int Id { get; set; } 
        public string Nombre { get; set; }
        public decimal Porcentaje { get; set; } 
        public int ProductoId { get; set; } 
        public int ImpuestoId { get; set; }
        public bool Baja { get; set; }
    }
}
