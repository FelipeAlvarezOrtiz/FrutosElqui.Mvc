using System;
using System.Windows.Forms;
using FrutosElqui.Negocio.Misc.EgresosDinero;
using FrutosElqui.Negocio.Misc.Sucursales;
using MediatR;

namespace FrutosElqui.Escritorio.Formularios
{
    public partial class NuevoEgreso : Form
    {
        private readonly IMediator _mediator;
        private readonly int _idSucursal;

        public NuevoEgreso(IMediator mediator, int idSucursal)
        {
            _mediator = mediator;
            _idSucursal = idSucursal;
            InitializeComponent();
        }

        private async void InsertarEgresoClick(object sender, System.EventArgs e)
        {
            var cantidad = CantidadInput.Text.Replace("$", "").Replace(".", "").Replace(".", "");
            if (!int.TryParse(cantidad, out var resultCantidad))
            {
                MessageBox.Show(this, "Debe ingresar caracteres válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (resultCantidad < 0)
            {
                MessageBox.Show(this, "No puedes ingresar cantidades negativas", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                if (string.IsNullOrEmpty(SucursalBox.Text))
                {
                    MessageBox.Show(this, "Debe ingresar la sucursal", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var request = new CrearEgresoDinero.Command
                {
                    SucursalOrigen = _idSucursal,
                    CantidadEgresada = resultCantidad,
                    Observacion = ObservacionInput.Text
                };
                await _mediator.Send(request);
                MessageBox.Show(this, "Ingreso registrado correctamente", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(this, error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CargarFormEgreso(object sender, EventArgs e)
        {
            var sucursal = await _mediator.Send(new ObtenerSucursal.Query { IdSucursal = _idSucursal });
            if (sucursal is null)
            {
                MessageBox.Show(this, "La sucursal ingresada no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SucursalBox.Text = sucursal.NombreSucursal;
            SucursalBox.ReadOnly = true;
        }
    }
}
