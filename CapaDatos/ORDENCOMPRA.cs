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
    
    public partial class ORDENCOMPRA
    {
        public int Id { get; set; }
        public System.DateTime FechaEmision { get; set; }
        public int USUARIOIdGenero { get; set; }
        public int PROVEEDORId { get; set; }
        public int MARCAId { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Impuestos { get; set; }
        public decimal Total { get; set; }
        public int ESTADOId { get; set; }
    
        public virtual USUARIO USUARIO { get; set; }
        public virtual PROVEEDOR PROVEEDOR { get; set; }
        public virtual MARCA MARCA { get; set; }
        public virtual ESTADO ESTADO { get; set; }
    }
}