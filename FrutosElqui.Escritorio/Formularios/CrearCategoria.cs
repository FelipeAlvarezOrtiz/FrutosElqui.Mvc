using MediatR;
using System;
using System.Windows.Forms;

namespace FrutosElqui.Escritorio.Formularios
{
    public partial class CrearCategoria : Form
    {
        private readonly CrearProducto _crearProductoForm;
        private readonly IMediator _mediator;

        public CrearCategoria(CrearProducto crearProductoForm, IMediator mediator)
        {
            InitializeComponent();
            _crearProductoForm = crearProductoForm;
            _mediator = mediator;
        }

        
        private void CerrarClick(object sender, EventArgs e)
        {
            Close();
        }

        private async void ClosingFormEvent(object sender, FormClosingEventArgs e)
        {
            await _crearProductoForm.CargarCategorias();
        }

        private async void AgregarCategoriaClick(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(NuevaCategoriaInput.Text))
                {
                    MessageBox.Show(this, "Debe ingresar caracteres válidos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                await _mediator.Send(new FrutosElqui.Negocio.Misc.Categorias.CrearCategoria.Command { NombreCategoria = NuevaCategoriaInput.Text });
                MessageBox.Show(this, "Se ha guardado de manera correcta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(this, "Ha ocurrido un error " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
