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
    
    public partial class PROVEEDOR
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; }
        public string Clave { get; set; }
        public int PERSONAIdRepresentante { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public int ESTADOId { get; set; }
    
        public virtual PERSONA PERSONA { get; set; }
        public virtual ESTADO ESTADO { get; set; }
    }
}
