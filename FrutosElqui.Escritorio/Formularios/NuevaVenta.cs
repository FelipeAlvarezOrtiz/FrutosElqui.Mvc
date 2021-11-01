using System;
using System.Windows.Forms;
using FrutosElqui.Negocio.Productos;
using FrutosElqui.Persistencia;
using MediatR;

namespace FrutosElqui.Escritorio.Formularios
{
    public partial class NuevaVenta : Form
    {
        private string _tipoVenta = string.Empty;
        private string _tipoPago = string.Empty;
        private readonly int _rutUsuario;
        private readonly IMediator _mediator;
        private readonly ApplicationDbContext _context;

        public NuevaVenta(int rutUsuario, IMediator mediator, ApplicationDbContext context)
        {
            _rutUsuario = rutUsuario;
            _mediator = mediator;
            _context = context;
            InitializeComponent();
            TipoVentaCombo.SelectedIndex = 0;
            TipoPagoCombo.SelectedIndex = 0;
            CodigoBarraInput.Focus();
        }

        private async void IntroKeyInput(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)13) return;
            if (CodigoBarraInput.Text != string.Empty)
            {
                if (int.TryParse(CodigoBarraInput.Text, out var result))
                {
                    //Venta(result);
                    //CodigoBarraInput.Text = _carro.TotalCarro.ToString("C0");
                    var productoEncontrado = await _mediator.Send(new ObtenerProducto.Query{IdProducto = result});
                    if (productoEncontrado is null)
                    {
                        MessageBox.Show(this, "Ese código no está asociado a ningún producto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CodigoBarraInput.Text = string.Empty;
                        CodigoBarraInput.Focus();
                        return;
                    }
                    Console.WriteLine(productoEncontrado.NombreBusqueda);
                    CodigoBarraInput.Text = string.Empty;
                    CodigoBarraInput.Focus();
                }
                else
                {
                    MessageBox.Show(this, "Ingrese un codigo de Barra válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(this, "Ingrese un valor Númerico no vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ResetBuscadorClick(object sender, EventArgs e)
        {
            CodigoBarraInput.Text = string.Empty;
            CodigoBarraInput.Focus();
        }

        private void BorrarProductoClick(object sender, EventArgs e)
        {
            try
            {
                //Aqui borramos de la lista en productos
                //_carro.RemoverProducto(int.Parse(datosVentaGrid[0, _posicion].Value.ToString()));
                //totalTextBox.Text = _carro.RefreshPrecioCarro().ToString("C0");
                if (productoCanasta.CurrentRow != null) productoCanasta.Rows.RemoveAt(productoCanasta.CurrentRow.Index);
                CodigoBarraInput.Focus();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show(this, "Debe hacer click en el Nombre del producto para eliminarlo", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show(this, "Debe seleccionar un producto válido para Eliminar.", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

    }
}
