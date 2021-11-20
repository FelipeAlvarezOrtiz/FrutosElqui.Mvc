using MediatR;
using System;
using System.Windows.Forms;

namespace FrutosElqui.Escritorio.Formularios
{
    public partial class CrearSabor : Form
    {
        private readonly CrearProducto _crearProductoForma;
        private readonly IMediator _mediator;

        public CrearSabor(IMediator mediator, CrearProducto CrearProductoForm)
        {
            InitializeComponent();
            _crearProductoForma = CrearProductoForm;
            _mediator = mediator;
        }

        private async void FormClosingEvent(object sender, FormClosingEventArgs e)
        {
            await _crearProductoForma.CargarSabores();
        }

        private void CerrarFormClick(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private async void CrearSaborClick(object sender, System.EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(NuevoSaborInput.Text))
                {
                    MessageBox.Show(this, "Debe ingresar caracteres válidos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                await _mediator.Send(new FrutosElqui.Negocio.Misc.Sabores.CrearSabor.Command { NombreSabor = NuevoSaborInput.Text });
                MessageBox.Show(this, "Se ha guardado de manera correcta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(this,"Ha ocurrido un error "+error.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
