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
    
    public partial class EMPLEADO
    {
        public EMPLEADO()
        {
            this.USUARIO = new HashSet<USUARIO>();
        }
    
        public int Id { get; set; }
        public string Rfc { get; set; }
        public System.DateTime FechaIngreso { get; set; }
        public int ESTADOId { get; set; }
        public int PUESTOId { get; set; }
        public int PERSONAId { get; set; }
    
        public virtual ICollection<USUARIO> USUARIO { get; set; }
        public virtual ESTADO ESTADO { get; set; }
        public virtual PUESTO PUESTO { get; set; }
        public virtual PERSONA PERSONA { get; set; }
    }
}
