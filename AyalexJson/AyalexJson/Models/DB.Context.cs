﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AyalexJson.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class yalexrentacarEntities : DbContext
    {
        public yalexrentacarEntities()
            : base("name=yalexrentacarEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<alquilere> alquileres { get; set; }
        public virtual DbSet<cliente> clientes { get; set; }
        public virtual DbSet<contrato> contratos { get; set; }
        public virtual DbSet<empleado> empleadoes { get; set; }
        public virtual DbSet<entrega> entregas { get; set; }
        public virtual DbSet<reserva> reservas { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<vehiculo> vehiculoes { get; set; }
    }
}
