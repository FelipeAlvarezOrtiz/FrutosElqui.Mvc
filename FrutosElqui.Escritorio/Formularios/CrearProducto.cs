using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrutosElqui.Negocio.Misc.Extras;
using FrutosElqui.Negocio.Productos;
using FrutosElqui.Negocio.Proveedores;
using MediatR;

namespace FrutosElqui.Escritorio.Formularios
{
    public partial class CrearProducto : Form
    {
        private readonly IMediator _mediator;

        public CrearProducto(IMediator mediator)
        {
            _mediator = mediator;
            InitializeComponent();
        }

        private async void AgregarProductoClick(object sender, EventArgs e)
        {
            try
            {
                var result = await _mediator.Send(new NuevoProducto.Command
                {
                    Categoria = int.Parse(CategoriasCombo.SelectedValue.ToString() ?? string.Empty),
                    Costo = int.Parse(CostoInput.Text ?? 0.ToString()),
                    DescripcionProducto = string.Empty,
                    Medida = int.Parse(MedidasCombo.SelectedValue.ToString() ?? string.Empty),
                    NombreProducto = NombreProductoInput.Text,
                    Proveedor = int.Parse(ProveedoresCombo.SelectedValue.ToString() ?? string.Empty),
                    Sabor = int.Parse(SaborCombo.SelectedValue.ToString() ?? string.Empty),
                    PrecioMayorista = int.Parse(PrecioMayoristaInput.Text),
                    PrecioTotal = int.Parse(PrecioDetalleInput.Text)
                });
                var dialogResult = MessageBox.Show("Ha ingresado correctamente, ¿desea ingresar otro?", "Confirmación",
                    MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    CostoInput.Text = string.Empty;
                    NombreProductoInput.Text = string.Empty;
                    PrecioMayoristaInput.Text = string.Empty;
                    PrecioDetalleInput.Text = string.Empty;
                }
                else
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

        private async void LoadForm(object sender, EventArgs e)
        {
            await CargarProveedores();
            await CargarMedidas();
            await CargarCategorias();
            await CargarSabores();
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

        private void SalirNuevoProductoClick(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
