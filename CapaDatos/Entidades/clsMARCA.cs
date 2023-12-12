using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public class clsMARCA
    {
        public int Id { get; set; }
        public string Clave { get; set; }
        public string Marca { get; set; }
        public string Proveedor { get; set; }
        public string Estado { get; set; }
        public int EstadoId { get; set; }


    }
}
