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
    
    public partial class VENTA
    {
        public int Id { get; set; }
        public string NumeroReferencia { get; set; }
        public int ESTADOId { get; set; }
        public int CLIENTEId { get; set; }
        public string NombreCliente0 { get; set; }
        public int METODOPAGOId { get; set; }
        public int FORMAPAGOId { get; set; }
        public System.DateTime FechaEmision { get; set; }
        public int USUARIOIdGenero { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Impuestos { get; set; }
        public decimal Total { get; set; }
    
        public virtual USUARIO USUARIO { get; set; }
        public virtual ESTADO ESTADO { get; set; }
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual METODOPAGO METODOPAGO { get; set; }
        public virtual FORMAPAGO FORMAPAGO { get; set; }
    }
}
