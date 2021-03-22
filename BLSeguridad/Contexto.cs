using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLFacturacionSB
{
    public class Contexto : DbContext
    {
        public Contexto() : base("FacturacionSB")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new DatosdeInicio());
        }

     public DbSet<Cliente> Clientes { get; set; }
     public DbSet<Producto> Productos { get; set; }
     public DbSet<Categoria> Categorias { get; set; }
     public DbSet<Empresa> Empresas { get; set; }
     public DbSet<Usuario> Usuarios { get; set; }
     public DbSet<TipoCliente> TipoClientes { get; set; }
     public DbSet<TermPago> TermPagos { get; set; }
     public DbSet<Factura> Facturas { get; set; }

    }
        
 }
    

