using System;
using System.Linq;
using System.Windows.Forms;
using FrutosElqui.Negocio.Misc.IngresosDinero;
using FrutosElqui.Negocio.Misc.Sucursales;
using MediatR;

namespace FrutosElqui.Escritorio.Formularios
{
    public partial class IngresosDeDinero : Form
    {
        private readonly IMediator _mediator;
        
        public IngresosDeDinero(IMediator mediator)
        {
            _mediator = mediator;
            InitializeComponent();
        }

        private async void CargarFormLoad(object sender, System.EventArgs e)
        {
            var sucursales = await _mediator.Send(new ObtenerSucursales.Query { });
            if (sucursales.Count == 0)
            {
                MessageBox.Show(this, "No existen sucursales creadas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SucursalesBox.DataSource = sucursales;
            SucursalesBox.DisplayMember = "NombreSucursal";
            SucursalesBox.ValueMember = "IdSucursal";
            FechaDesdePicker.Value = DateTime.Now.AddDays(-1);
            FechaHastaPicker.Value = DateTime.Now.AddDays(1);
            TotalBox.Text = 0.ToString("C0");
            TotalBox.ReadOnly = true;
        }

        private async void BuscarIngresos(object sender, EventArgs e)
        {
            var fechaDesde = FechaDesdePicker.Value;
            var fechaHasta = FechaHastaPicker.Value;
            if (DateTime.Compare(fechaDesde, fechaHasta) > 0)
            {
                MessageBox.Show(this, "La fecha desde no puede ser mayor a la final.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var idSucursal = int.Parse(SucursalesBox.SelectedValue.ToString()?? 0.ToString());
                var request = new ObtenerIngresosDineroEntreFechas.Query
                {
                    FechaFin = fechaHasta.AddHours(23),
                    FechaInicio = fechaDesde,
                    IdSucursal = idSucursal
                };
                var ingresosDinero = await _mediator.Send(request);
                if (ingresosDinero.Count == 0)
                {
                    MessageBox.Show(this, "No existen ingresos para los criterios ingresados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TotalBox.Text = 0.ToString("C0");
                    IngresosView.Rows.Clear();
                    return;
                }
                IngresosView.Rows.Clear();
                foreach (var ingreso in ingresosDinero)
                {
                    IngresosView.Rows.Add(ingreso.IdIngreso, 
                        ingreso.FechaIngreso.ToShortDateString(),
                        ingreso.CantidadIngresado.ToString("C0"),
                        ingreso.Observacion);
                }
                TotalBox.Text = ingresosDinero.Sum(ingreso => ingreso.CantidadIngresado).ToString("C0");
                TotalBox.ReadOnly = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(this, $"Ha ocurrido un error con mensaje {error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NuevoIngresoForm(object sender, EventArgs e)
        {
            new NuevoIngreso(this._mediator, int.Parse(SucursalesBox.SelectedValue.ToString() ?? 0.ToString())).Show(this);
        }
    }
}
