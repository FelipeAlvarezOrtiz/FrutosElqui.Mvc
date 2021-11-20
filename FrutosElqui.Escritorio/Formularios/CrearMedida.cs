using MediatR;
using System;
using System.Windows.Forms;

namespace FrutosElqui.Escritorio.Formularios
{
    public partial class CrearMedida : Form
    {
        private readonly CrearProducto _crearProductoForm;
        private readonly IMediator _mediator;
        public CrearMedida(CrearProducto crearProductoForm, IMediator mediator)
        {
            InitializeComponent();
            _crearProductoForm = crearProductoForm;
            _mediator = mediator;
        }

        private void CerrarButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void FormClosingEvent(object sender, FormClosingEventArgs e)
        {
            await _crearProductoForm.CargarMedidas();
        }

        private async void CrearMedidaClick(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(NuevaMedidaInput.Text))
                {
                    MessageBox.Show(this, "Debe ingresar caracteres válidos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                await _mediator.Send(new FrutosElqui.Negocio.Misc.Medidas.CrearMedida.Command { NombreMedida = NuevaMedidaInput.Text });
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
