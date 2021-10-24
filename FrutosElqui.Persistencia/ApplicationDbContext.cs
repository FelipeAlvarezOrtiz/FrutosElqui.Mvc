using FrutosElqui.Core.Clientes;
using FrutosElqui.Core.Cotizaciones;
using FrutosElqui.Core.Misc;
using FrutosElqui.Core.Productos;
using FrutosElqui.Core.Proveedores;
using FrutosElqui.Core.Usuarios;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Persistencia
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<AppUser> Usuarios { get; set; }
        public DbSet<Banco> Bancos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Comuna> Comunas { get; set; }
        public DbSet<Cuenta> Cuentas { get; set; }
        public DbSet<DocumentoTributario> DocumentosTributarios { get; set; }
        public DbSet<Giro> Giros { get; set; }
        public DbSet<Medida> Medidas { get; set; }
        public DbSet<Region> Regiones { get; set; }
        public DbSet<Sabor> Sabores { get; set; }
        public DbSet<Sector> Sectores { get; set; }
        public DbSet<TipoCuenta> TipoCuentas { get; set; }
        public DbSet<TipoPago> TipoPagos { get; set; }
        public DbSet<TipoSucursal> TipoSucursales { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<EstadoCotizacion> EstadoCotizaciones { get; set; }
        public DbSet<Courrier> Courriers { get; set; }
        public DbSet<DetalleCotizacion> DetallesDeCotizaciones { get; set; }
    }
}
