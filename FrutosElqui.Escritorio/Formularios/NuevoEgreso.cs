using System;
using System.Windows.Forms;
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

        private void InsertarEgresoClick(object sender, System.EventArgs e)
        {

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
