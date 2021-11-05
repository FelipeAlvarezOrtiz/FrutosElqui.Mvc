using System;
using System.Windows.Forms;
using FrutosElqui.Negocio.Misc.Sucursales;
using MediatR;

namespace FrutosElqui.Escritorio.Formularios
{
    public partial class Inventarios : Form
    {
        private readonly IMediator _mediator;

        public Inventarios(IMediator mediator)
        {
            _mediator = mediator;
            InitializeComponent();
        }

        private void NuevoProductoAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Console.WriteLine("Holasxd");
        }

        private async void CargarInventariosLoad(object sender, System.EventArgs e)
        {
            var sucursales = await _mediator.Send(new ObtenerSucursales.Query{});
            if (sucursales.Count == 0)
            {
                MessageBox.Show(this, "No existen sucursales creadas","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            SucursalesCombo.DataSource = sucursales;
            SucursalesCombo.DisplayMember = "NombreSucursal";
            SucursalesCombo.ValueMember = "IdSucursal";
        }

        private async void CargarProductosDeSucursal(object sender, EventArgs e)
        {
            var idSucursal = int.Parse(SucursalesCombo.SelectedValue.ToString()?? 0.ToString());

        }

        private void NuevoProductoAdded(object sender, DataGridViewRowEventArgs e)
        {
            Console.WriteLine("Se agrego a una wea");
        }
    }
}
