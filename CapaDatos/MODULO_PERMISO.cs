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
    
    public partial class MODULO_PERMISO
    {
        public int Id { get; set; }
        public System.DateTime FechaAsignacion { get; set; }
        public bool Baja { get; set; }
        public int MODULOId { get; set; }
        public int USUARIOSolicitaId { get; set; }
        public int USUARIOAutorizaId { get; set; }
        public int USUARIOAsignaId { get; set; }
    
        public virtual MODULO MODULO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual USUARIO USUARIO1 { get; set; }
        public virtual USUARIO USUARIO2 { get; set; }
    }
}
