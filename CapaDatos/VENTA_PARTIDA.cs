//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class VENTA_PARTIDA
    {
        public int Id { get; set; }
        public int PRODUCTOId { get; set; }
        public int VENTAId { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Impuestos { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }
        public bool Baja { get; set; }
    
        public virtual PRODUCTO PRODUCTO { get; set; }
        public virtual VENTA VENTA { get; set; }
    }
}
