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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_BOUTIQUEEntities : DbContext
    {
        public DB_BOUTIQUEEntities()
            : base("name=DB_BOUTIQUEEntities")
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
        public DbSet<PRODUCTO> PRODUCTO { get; set; }
        public DbSet<PROVEEDOR> PROVEEDOR { get; set; }
        public DbSet<MARCA> MARCA { get; set; }
        public DbSet<ORDENCOMPRA> ORDENCOMPRA { get; set; }
        public DbSet<VENTA> VENTA { get; set; }
        public DbSet<VENTA_PARTIDA> VENTA_PARTIDA { get; set; }
        public DbSet<CLIENTE> CLIENTE { get; set; }
        public DbSet<MOVIMIENTO> MOVIMIENTO { get; set; }
        public DbSet<IMPUESTO> IMPUESTO { get; set; }
        public DbSet<PRODUCTO_IMPUESTO> PRODUCTO_IMPUESTO { get; set; }
        public DbSet<ORDENCOMPRA_PARTIDA> ORDENCOMPRA_PARTIDA { get; set; }
        public DbSet<TIPO_MOVIMIENTO> TIPO_MOVIMIENTO { get; set; }
        public DbSet<METODOPAGO> METODOPAGO { get; set; }
        public DbSet<FORMAPAGO> FORMAPAGO { get; set; }
        public DbSet<VARIABLEGLOBAL> VARIABLEGLOBAL { get; set; }
    }
}