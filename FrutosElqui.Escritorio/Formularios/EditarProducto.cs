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
            //cargar los datos a editar

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

        private void CerrarButtonClick(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
