﻿//------------------------------------------------------------------------------
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
    using System.Configuration;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_BOUTIQUEEntities : DbContext
    {
        static string con = ConfigurationManager.ConnectionStrings["DB_BOUTIQUEEntities"].ConnectionString;
        public DB_BOUTIQUEEntities()
            : base(con)
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CONTROL> CONTROL { get; set; }
        public DbSet<CONTROL_PERMISO> CONTROL_PERMISO { get; set; }
        public DbSet<EMPLEADO> EMPLEADO { get; set; }
        public DbSet<ESTADO> ESTADO { get; set; }
        public DbSet<MODULO> MODULO { get; set; }
        public DbSet<MODULO_PERMISO> MODULO_PERMISO { get; set; }
        public DbSet<PERSONA> PERSONA { get; set; }
        public DbSet<PUESTO> PUESTO { get; set; }
        public DbSet<ROL> ROL { get; set; }
        public DbSet<USUARIO> USUARIO { get; set; }
    }
}
