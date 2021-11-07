using System;
using System.Windows.Forms;
using FrutosElqui.Negocio.Inventarios;
using FrutosElqui.Negocio.Misc.Sucursales;
using MediatR;

namespace FrutosElqui.Escritorio.Formularios
{
    public partial class Inventarios : Form
    {
        private readonly IMediator _mediator;

        public Inventarios(IMediator mediator)
        {
            _mediator = mediator;
            InitializeComponent();
        }

        private async void CargarInventariosLoad(object sender, System.EventArgs e)
        {
            var sucursales = await _mediator.Send(new ObtenerSucursales.Query{});
            if (sucursales.Count == 0)
            {
                MessageBox.Show(this, "No existen sucursales creadas","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            SucursalesCombo.DataSource = sucursales;
            SucursalesCombo.DisplayMember = "NombreSucursal";
            SucursalesCombo.ValueMember = "IdSucursal";
        }

        private async void CargarProductosDeSucursal(object sender, EventArgs e)
        {
            var idSucursal = int.Parse(SucursalesCombo.SelectedValue.ToString()?? 0.ToString());
            var resultProductos = await _mediator.Send(new ObtenerInventariosDeSucursal.Query{IdSucursal = idSucursal});
            if (resultProductos.Count == 0)
            {
                var dialogResult = MessageBox.Show(this, "No existen productos en esa sucursal, ¿Desea agregar productos?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    new AgregarProductoEnSucursal(this._mediator,idSucursal).Show();
                }
                else
                {
                    return;
                }
            }
            ProductosInventarioView.Rows.Clear();
            foreach (var detalle in resultProductos)
            {
                var producto = detalle.Producto;
                ProductosInventarioView.Rows.Add(producto.IdProducto, producto.NombreProducto,
                    producto.CategoriaProducto.NombreCategoria,
                    producto.MedidaProducto.NombreMedida, producto.ProveedorProducto.NombreProveedor,
                    detalle.CantidadDisponible);
            }
        }

        private void IngresarProductoClick(object sender, EventArgs e)
        {
            var idSucursal = int.Parse(SucursalesCombo.SelectedValue.ToString() ?? 0.ToString());
            new AgregarProductoEnSucursal(this._mediator, idSucursal).Show();
        }

        private void CerrarForm(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
