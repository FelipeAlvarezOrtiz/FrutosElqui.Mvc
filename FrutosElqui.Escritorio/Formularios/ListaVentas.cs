using FrutosElqui.Core.Ventas;
using FrutosElqui.Negocio.Misc.Sucursales;
using FrutosElqui.Negocio.Ofertas;
using FrutosElqui.Negocio.Proveedores;
using FrutosElqui.Negocio.Ventas;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrutosElqui.Escritorio.Formularios
{
    public partial class ListaVentas : Form
    {
        private readonly IMediator _mediator;

        public ListaVentas(IMediator mediator)
        {
            _mediator = mediator;  
            InitializeComponent();
        }

        private async void LoadFrame(object sender, System.EventArgs e)
        {
            await CargarSucursales();
            await CargarProveedores();
        }

        private async Task CargarSucursales()
        {
            var sucursales = await _mediator.Send(new ObtenerSucursales.Query { });
            if (sucursales.Count == 0)
            {
                MessageBox.Show(this, "No existen sucursales creadas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SucursalesBox.DataSource = sucursales;
                SucursalesBox.DisplayMember = "NombreSucursal";
                SucursalesBox.ValueMember = "IdSucursal";
                FechaDesdePicker.Value = DateTime.Now.AddDays(-1);
                FechaHastaPicker.Value = DateTime.Now.AddDays(1);
            }
        }

        private async Task CargarProveedores()
        {
            var proveedores = await _mediator.Send(new ListaProveedores.Query { });
            if(proveedores.Count == 0)
            {
                MessageBox.Show(this, "No existen proveedores creados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ProveedoresBox.DataSource = proveedores;
                ProveedoresBox.DisplayMember = "NombreProveedor";
                ProveedoresBox.ValueMember = "IdProveedor";
            }
        }
        
        private async void BuscarVentas(object sender, EventArgs e)
        {
            try
            {
                var idSucursal = int.Parse(SucursalesBox.SelectedValue.ToString() ?? 0.ToString());
                var idProveedor = int.Parse(ProveedoresBox.SelectedValue.ToString() ?? 0.ToString());
                var listaVentas = await _mediator.Send(new ObtenerVentasDelProveedor.Query
                {
                    FechaDesde = FechaDesdePicker.Value,
                    FechaHasta = FechaHastaPicker.Value,
                    IdSucursal = idSucursal,
                    IdProveedor = idProveedor
                });
                if (listaVentas.Count == 0)
                {
                    VentasView.Rows.Clear();
                    TotalProveedorInput.Text = 0.ToString("C0");
                    TotalVentaInput.Text = 0.ToString("C0");
                    MessageBox.Show(this, "No existen datos para los criterios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                VentasView.Rows.Clear();   
                foreach(var item in listaVentas)
                {
                    VentasView.Rows.Add(item.IdVenta,
                        item.FechaVenta.ToShortDateString(),
                        item.Total.ToString("C0"),
                        item.DetallesVenta.Count);
                }
                await CalcularMontoTotal(listaVentas,idProveedor);
            }
            catch (Exception error)
            {
                MessageBox.Show(this, "Ha ocurrido un error con mensaje " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CalcularMontoTotal(List<Venta> ventas, int idProveedor)
        {
            if(ventas.Count == 0)
            {
                TotalVentaInput.Text = 0.ToString("C0");
            }
            else
            {
                var ventasTotales = 0;
                var ventasProveedor = 0;
                foreach(var venta in ventas)
                {
                    foreach (var item in venta.DetallesVenta)
                    {
                        if (item.IdProveedor != idProveedor) continue;
                        ventasProveedor += item.TotalProducto;
                    }
                    foreach(var item in venta.OfertasEnVenta)
                    {
                        var oferta = await _mediator.Send(new ObtenerOferta.Query
                        {
                            IdOferta = item.GuidOferta
                        });
                        foreach(var detalles in oferta.ProductosEnOferta)
                        {
                            if (detalles.Producto.ProveedorProducto.IdProveedor != idProveedor) continue;
                            ventasProveedor += detalles.CantidadProducto * detalles.Producto.PrecioTotal;
                        }
                    }
                    ventasTotales += venta.Total;
                }
                TotalProveedorInput.Text = ventasProveedor.ToString("C0");
                TotalVentaInput.Text = ventasTotales.ToString("C0");
            }
        }
    
    }
}
