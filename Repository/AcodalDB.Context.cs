﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repository
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CongresoAcodalEntities : DbContext
    {
        public CongresoAcodalEntities()
            : base("name=CongresoAcodalEntities")
        {
            //this.Database.Connection.ConnectionString = "Data Source=192.185.7.204;Initial Catalog=alejosoft_Acodal;User ID=alejo_Acodal;Password=Acod4l_pa$$2016; providerName=System.Data.SqlClient";
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ciudade> Ciudades { get; set; }
        public virtual DbSet<Conferencia> Conferencias { get; set; }
        public virtual DbSet<Empresa> Empresas { get; set; }
        public virtual DbSet<Expositor> Expositors { get; set; }
        public virtual DbSet<Lugar> Lugars { get; set; }
        public virtual DbSet<Pai> Pais { get; set; }
        public virtual DbSet<Perfile> Perfiles { get; set; }
        public virtual DbSet<Salone> Salones { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
    
        public virtual ObjectResult<ValidaUsuario_Result> ValidaUsuario(string alias, string email, string pass, Nullable<int> empresa)
        {
            var aliasParameter = alias != null ?
                new ObjectParameter("Alias", alias) :
                new ObjectParameter("Alias", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("Pass", pass) :
                new ObjectParameter("Pass", typeof(string));
    
            var empresaParameter = empresa.HasValue ?
                new ObjectParameter("Empresa", empresa) :
                new ObjectParameter("Empresa", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ValidaUsuario_Result>("ValidaUsuario", aliasParameter, emailParameter, passParameter, empresaParameter);
        }
    }
}
