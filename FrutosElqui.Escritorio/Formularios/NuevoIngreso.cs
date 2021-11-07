using System;
using System.Windows.Forms;
using FrutosElqui.Negocio.Misc.IngresosDinero;
using FrutosElqui.Negocio.Misc.Sucursales;
using MediatR;

namespace FrutosElqui.Escritorio.Formularios
{
    public partial class NuevoIngreso : Form
    {
        private readonly IMediator _mediator;
        private readonly int _idSucursal;

        public NuevoIngreso(IMediator mediator, int idSucursal)
        {
            _mediator = mediator;
            _idSucursal = idSucursal;
            InitializeComponent();
        }

        private async void CargarFormIngreso(object sender, EventArgs e)
        {
            var sucursal = await _mediator.Send(new ObtenerSucursal.Query { IdSucursal = _idSucursal});
            if (sucursal is null)
            {
                MessageBox.Show(this, "La sucursal ingresada no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SucursalBox.Text = sucursal.NombreSucursal;
            SucursalBox.ReadOnly = true;
        }

        private async void InsertarIngresoClick(object sender, EventArgs e)
        {
            var cantidad = CantidadInput.Text.Replace("$", "").Replace(".","").Replace(".", "");
            if (!int.TryParse(cantidad, out var resultCantidad))
            {
                MessageBox.Show(this, "Debe ingresar caracteres válidos.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                var request = new CrearIngresoDinero.Command
                {
                    SucursalOrigen = _idSucursal,
                    CantidadIngresado = resultCantidad,
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

        private void CerrarFormClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CantidadChangedEvent(object sender, EventArgs e)
        {
            
        }
    }
}
