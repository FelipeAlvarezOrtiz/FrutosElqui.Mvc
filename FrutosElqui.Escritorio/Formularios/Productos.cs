using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrutosElqui.Core.Productos;
using FrutosElqui.Negocio.Productos;
using MediatR;

namespace FrutosElqui.Escritorio.Formularios
{
    public partial class Productos : Form
    {
        private readonly IMediator _mediator;
        public List<Producto> ProductosEnSistema = new();
        public Productos(ref IMediator mediator)
        {
            _mediator = mediator;
            InitializeComponent();
        }

        private async Task CargarProductos()
        {
            ProductosView.Rows.Clear();
            var productos = await _mediator.Send(new ListaProductos.Query());
            foreach (var producto in productos)
            {
                ProductosView.Rows.Add(producto.IdProducto, producto.NombreProducto,
                    producto.CategoriaProducto.NombreCategoria,
                    producto.MedidaProducto.NombreMedida,producto.ProveedorProducto.NombreProveedor);
            }
        }

        private async void LoadFormEvent(object sender, EventArgs e)
        {
            await CargarProductos();
        }

        private void NuevoProductoFormClick(object sender, EventArgs e)
        {
            new CrearProducto(this._mediator).Show();
        }

        private async void RefrescarListaClick(object sender, EventArgs e)
        {
            await CargarProductos();
        }

        private void EditarProductoClick(object sender, EventArgs e)
        {
            try
            {
                if (ProductosView.CurrentRow != null)
                {
                    var indexSeleccionado = ProductosView.CurrentRow.Index;
                    var valorIdProducto = int.Parse(ProductosView[0, indexSeleccionado].Value.ToString() ??
                                                    throw new Exception("Debe seleccionar un producto para editar"));
                    //Abrir form para editar producto
                    new EditarProducto(valorIdProducto, this._mediator).Show(this);
                }
                else
                {
                    MessageBox.Show(this, "Debe seleccionar un producto para editar.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}
