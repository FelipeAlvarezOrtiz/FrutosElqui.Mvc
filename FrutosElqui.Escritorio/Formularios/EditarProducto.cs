using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrutosElqui.Negocio.Misc.Extras;
using FrutosElqui.Negocio.Productos;
using FrutosElqui.Negocio.Proveedores;
using MediatR;

namespace FrutosElqui.Escritorio.Formularios
{
    public partial class EditarProducto : Form
    {
        private readonly int _idProducto;
        private readonly IMediator _mediator;

        public EditarProducto(int idProducto, IMediator mediator)
        {
            _idProducto = idProducto;
            _mediator = mediator;
            InitializeComponent();
        }

        private async void CargarFormLoad(object sender, System.EventArgs e)
        {
            await CargarProveedores();
            await CargarMedidas();
            await CargarCategorias();
            await CargarSabores();

            var productoEditar = await _mediator.Send(new ObtenerProducto.Query { IdProducto = _idProducto});
            if (productoEditar is null)
                MessageBox.Show(this, "El producto a editar no existe", "Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

            NombreProductoInput.Text = productoEditar.NombreProducto;
            CostoInput.Text = productoEditar.Costo.ToString("C0");
            IdentificadorInput.Text = _idProducto.ToString();
            PrecioDetalleInput.Text = productoEditar.PrecioTotal.ToString("C0");
        }

        private async Task CargarProveedores()
        {
            var proveedores = await _mediator.Send(new ListaProveedores.Query());
            ProveedoresCombo.DataSource = proveedores;
            ProveedoresCombo.DisplayMember = "NombreProveedor";
            ProveedoresCombo.ValueMember = "IdProveedor";
        }

        private async Task CargarMedidas()
        {
            var medidas = await _mediator.Send(new ListaMedidas.Query());
            MedidasCombo.DataSource = medidas;
            MedidasCombo.DisplayMember = "NombreMedida";
            MedidasCombo.ValueMember = "IdMedida";
        }

        private async Task CargarCategorias()
        {
            var categorias = await _mediator.Send(new ListaCategorias.Query());
            CategoriasCombo.DataSource = categorias;
            CategoriasCombo.DisplayMember = "NombreCategoria";
            CategoriasCombo.ValueMember = "IdCategoria";
        }

        private async Task CargarSabores()
        {
            var sabores = await _mediator.Send(new ListaSabores.Query());
            SaborCombo.DataSource = sabores;
            SaborCombo.DisplayMember = "NombreSabor";
            SaborCombo.ValueMember = "IdSabor";
        }

        private void CerrarButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void EditarProductoClick(object sender, EventArgs e)
        {
            var nuevoPrecioMayorista = (PrecioMayoristaInput.Text ?? 0.ToString()).Replace("$", "").Replace(".", "");
            var nuevoCosto = CostoInput.Text.Replace("$", "").Replace(".", "");
            var nuevoPrecioTotal = PrecioDetalleInput.Text.Replace("$", "").Replace(".", "");
            var nuevaMedida = MedidasCombo.SelectedValue.ToString() ?? 1.ToString();
            var nuevoProveedor = ProveedoresCombo.SelectedValue.ToString() ?? 1.ToString();
            var nuevoSabor = SaborCombo.SelectedValue.ToString() ?? 1.ToString();
            
            var ActualizarDto = new ActualizarProducto.Command()
            {
                IdProducto = _idProducto,
                Categoria = int.Parse(CategoriasCombo.SelectedValue.ToString() ?? string.Empty),
                Costo = int.Parse(nuevoCosto),
                DescripcionProducto = string.Empty,
                Medida = int.Parse(nuevaMedida),
                NombreProducto = NombreProductoInput.Text,
                Proveedor = int.Parse(nuevoProveedor),
                Sabor = int.Parse(nuevoSabor),
                PrecioMayorista = int.Parse(nuevoPrecioMayorista),
                PrecioTotal = int.Parse(nuevoPrecioTotal)
            };
            try
            {
                await _mediator.Send(ActualizarDto);
                var result = MessageBox.Show(this, "Producto actualizado con éxito,recuerde refrescar la tabla de productos para ver reflejado el cambio",
                    "Confirmación",MessageBoxButtons.OK,MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(this, $"Ha ocurrido un error {error.Message}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
