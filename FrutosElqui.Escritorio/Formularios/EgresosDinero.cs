using System;
using System.Linq;
using System.Windows.Forms;
using FrutosElqui.Negocio.Misc.EgresosDinero;
using FrutosElqui.Negocio.Misc.Sucursales;
using MediatR;

namespace FrutosElqui.Escritorio.Formularios
{
    public partial class EgresosDinero : Form
    {
        private readonly IMediator _mediator;

        public EgresosDinero(IMediator mediator)
        {
            _mediator = mediator;
            InitializeComponent();
        }

        private void NuevoEgresoClick(object sender, EventArgs e)
        {
            new NuevoEgreso(this._mediator, int.Parse(SucursalesBox.SelectedValue.ToString() ?? 0.ToString())).Show(this);
        }

        private async void BuscarEgresosClick(object sender, EventArgs e)
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
                var idSucursal = int.Parse(SucursalesBox.SelectedValue.ToString() ?? 0.ToString());
                var request = new ObtenerEgresosDineroEntreFechas.Query
                {
                    FechaFin = fechaHasta.AddHours(23),
                    FechaInicio = fechaDesde,
                    IdSucursal = idSucursal
                };
                var egresoDinero = await _mediator.Send(request);
                if (egresoDinero.Count == 0)
                {
                    MessageBox.Show(this, "No existen ingresos para los criterios ingresados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TotalBox.Text = 0.ToString("C0");
                    EgresosView.Rows.Clear();
                    return;
                }
                EgresosView.Rows.Clear();
                foreach (var egreso in egresoDinero)
                {
                    EgresosView.Rows.Add(egreso.IdEgreso,
                        egreso.FechaEgreso.ToShortDateString(),
                        egreso.CantidadEgresada.ToString("C0"),
                        egreso.Observacion);
                }
                TotalBox.Text = egresoDinero.Sum(egreso => egreso.CantidadEgresada).ToString("C0");
                TotalBox.ReadOnly = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(this, $"Ha ocurrido un error con mensaje {error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CargaEgresosLoad(object sender, EventArgs e)
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
    }
}
