using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FrutosElqui.Core.Misc;
using FrutosElqui.Core.Productos;
using FrutosElqui.Negocio.Inventarios;
using FrutosElqui.Negocio.Misc.Sucursales;
using FrutosElqui.Negocio.Productos;
using FrutosElqui.Negocio.Proveedores;
using MediatR;

namespace FrutosElqui.Escritorio.Formularios
{
    public partial class AgregarProductoEnSucursal : Form
    {
        private readonly IMediator _mediator;
        private readonly int _idSucursal;
        private Producto ProductoAgregar;
        private Sucursal SucursalAgregar;

        public AgregarProductoEnSucursal(IMediator mediator, int idSucursal)
        {
            _mediator = mediator;
            _idSucursal = idSucursal;
            InitializeComponent();
        }

        private async void CargarSucursal(object sender, System.EventArgs e)
        {
            var sucursales = await _mediator.Send(new ObtenerSucursal.Query { IdSucursal = _idSucursal});
            if (sucursales is null)
            {
                MessageBox.Show(this, "No existen la sucursal para ese id", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SucursalAgregar = sucursales;

            var listaSource = new List<Sucursal>(1) { sucursales };
            SucursalBox.DataSource = listaSource;
            SucursalBox.DisplayMember = "NombreSucursal";
            SucursalBox.ValueMember = "IdSucursal";
            SucursalBox.Enabled = false;
        }

        private void CerrarFormClick(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private async void CheckProductoClick(object sender, System.EventArgs e)
        {
            var idProducto = IdProductoInput.Text;
            if (string.IsNullOrEmpty(idProducto) || !int.TryParse(idProducto, out var resultParse))
            {
                MessageBox.Show(this,"Debe ingresar un valor válido","Información",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            var producto = await _mediator.Send(new ObtenerProducto.Query{IdProducto = resultParse});
            if (producto is null)
            {
                MessageBox.Show(this, "El producto buscado no existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            ProductoAgregar = producto;
            NombreProductoInput.Text = producto.NombreBusqueda;
            ProveedorNombreInput.Text = producto.ProveedorProducto.NombreProveedor;
        }

        private async void IngresarProductoEnSucursal(object sender, System.EventArgs e)
        {
            var idProducto = IdProductoInput.Text;
            var cantidad = CantidadInput.Text;
            if (string.IsNullOrEmpty(idProducto) || !int.TryParse(idProducto, out var resultParse))
            {
                MessageBox.Show(this, "Debe ingresar un valor válido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(idProducto) || !int.TryParse(cantidad, out var resultCantidad))
            {
                MessageBox.Show(this, "Debe ingresar una cantidad válida", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (resultCantidad == 0)
            {
                MessageBox.Show(this, "Debe ingresar una cantidad mayor a 0", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                var requestAgregar = new AgregarProductoConSucursal.Command
                {
                    IdProducto = resultParse,
                    Cantidad = resultCantidad,
                    IdSucursal = _idSucursal
                };
                await _mediator.Send(requestAgregar);
                var resultDialog = MessageBox.Show(this, "Producto agregado con exito,¿Desea agregar otro más?",
                    "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resultDialog == DialogResult.Yes)
                {
                    NombreProductoInput.Text = string.Empty;
                    ProveedorNombreInput.Text = string.Empty;
                    ProductoAgregar = null;
                    IdProductoInput.Text = string.Empty;
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(this, error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
