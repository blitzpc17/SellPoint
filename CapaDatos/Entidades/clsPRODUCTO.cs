using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public class clsPRODUCTO
    {
        public int Id { get; set; }        
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public string CodigoBarras { get; set; }
        public int MarcaId { get; set; }
        public string Marca { get; set; }
        public int ProveedorId { get; set; }
        public string Proveedor { get; set; }
        public decimal PrecioCompraBruto { get; set; }
        public decimal PrecioVentaBruto { get; set; }
        public decimal? MontoImpuestoVenta { get; set; }
        public decimal? MontoImpuestoCompra { get; set; }
        public decimal? PrecioFinalCompra { get; set; }
        public decimal? PrecioFinalVenta { get; set; }
        public bool Impuesto { get; set; }
        public int EstadoId { get; set; } 
        public string Estado { get; set; }
       

        




    }
}
