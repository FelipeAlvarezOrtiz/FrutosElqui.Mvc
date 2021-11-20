using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FrutosElqui.Negocio.Misc.TipoPago;
using FrutosElqui.Negocio.Ofertas;
using FrutosElqui.Negocio.Productos;
using FrutosElqui.Negocio.Ventas;
using FrutosElqui.Persistencia;
using MediatR;

namespace FrutosElqui.Escritorio.Formularios
{
    public partial class NuevaVenta : Form
    {
        private readonly int _rutUsuario;
        private readonly IMediator _mediator;
        private readonly ApplicationDbContext _context;

        private CrearVenta.Command _nuevaVenta = new();
        private Dictionary<int, CrearVenta.CommandDetalle> _detallesVenta = new();
        private Dictionary<int,CrearVenta.CommandOfertasDetalle> _ofertasVenta = new();

        public NuevaVenta(int rutUsuario, IMediator mediator, ApplicationDbContext context)
        {
            _rutUsuario = rutUsuario;
            _mediator = mediator;
            _context = context;
            InitializeComponent();
            TipoVentaCombo.SelectedIndex = 0;
            TipoPagoCombo.SelectedIndex = 0;
            TotalVentaTextbox.Text = ObtieneTotalDeCarro();
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
                        var ofertaEncontrada = await _mediator.Send(new ObtenerOfertaPorId.Query { IdOferta = result });
                        if(ofertaEncontrada is null)
                        {
                            MessageBox.Show(this, "Ese código no está asociado a ningún producto u oferta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CodigoBarraInput.Text = string.Empty;
                            CodigoBarraInput.Focus();
                            return;
                        }
                        else
                        {
                            var idOfertaEncontrada = ofertaEncontrada.IdOferta;
                            if (!_ofertasVenta.ContainsKey(idOfertaEncontrada))
                            {
                                productoCanasta.Rows.Add(ofertaEncontrada.IdOferta,
                                    ofertaEncontrada.NombreOferta+" (Oferta)",
                                    1,
                                    ofertaEncontrada.PrecioOferta.ToString("C0"));

                                _ofertasVenta.Add(idOfertaEncontrada, new CrearVenta.CommandOfertasDetalle()
                                {
                                    IdOferta = ofertaEncontrada.GuidOferta,
                                    CantidadOferta = 1
                                });
                            }
                            else
                            {
                                foreach (DataGridViewRow row in productoCanasta.Rows)
                                {
                                    var idCodigo = int.Parse(row.Cells["CodeID"].Value.ToString() ?? 0.ToString());

                                    if (idCodigo != idOfertaEncontrada) continue;

                                    var index = row.Index;
                                    var cantidadActual = int.Parse(productoCanasta[2, index].Value.ToString() ?? 0.ToString());
                                    var nuevaCantidad = cantidadActual + 1;
                                    //[columna,row] -- 
                                    productoCanasta[3, index].Value = (nuevaCantidad * ofertaEncontrada.PrecioOferta).ToString("C0");
                                    productoCanasta[2, index].Value = nuevaCantidad;
                                    ModificarCantidadOferta(idOfertaEncontrada, nuevaCantidad);
                                }
                            }
                        }
                    }
                    else {
                        var idProductoEncontrado = productoEncontrado.IdProducto;
                        if (!_detallesVenta.ContainsKey(idProductoEncontrado))
                        {
                            productoCanasta.Rows.Add(productoEncontrado.IdProducto,
                                productoEncontrado.NombreBusqueda,
                                1,
                                productoEncontrado.PrecioTotal.ToString("C0"));

                            _detallesVenta.Add(idProductoEncontrado, new CrearVenta.CommandDetalle()
                            {
                                CantidadProducto = 1,
                                IdProducto = idProductoEncontrado,
                                IdProveedor = productoEncontrado.ProveedorProducto.IdProveedor
                            });

                        }
                        else
                        {
                            foreach (DataGridViewRow row in productoCanasta.Rows)
                            {
                                var idCodigo = int.Parse(row.Cells["CodeID"].Value.ToString() ?? 0.ToString());

                                if (idCodigo != idProductoEncontrado) continue;

                                var index = row.Index;
                                var cantidadActual = int.Parse(productoCanasta[2, index].Value.ToString() ?? 0.ToString());
                                var nuevaCantidad = cantidadActual + 1;
                                //[columna,row] -- 
                                productoCanasta[3, index].Value = (nuevaCantidad * productoEncontrado.PrecioTotal).ToString("C0");
                                productoCanasta[2, index].Value = nuevaCantidad;
                                ModificarCantidad(idProductoEncontrado, nuevaCantidad);
                            }
                        }
                    }
                    TotalVentaTextbox.Text = ObtieneTotalDeCarro();
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

        private void ModificarCantidad(int id, int nuevaCantidad)
        {
            if (_detallesVenta.TryGetValue(id, out var productoDetalle))
            {
                productoDetalle.CantidadProducto = nuevaCantidad;
                _detallesVenta[id] = productoDetalle;
            }
            else
            {
                MessageBox.Show(this, "Error al obtener el producto del diccionario de datos.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModificarCantidadOferta(int id, int nuevaCantidad)
        {
            if (_ofertasVenta.TryGetValue(id, out var productoDetalle))
            {
                productoDetalle.CantidadOferta = nuevaCantidad;
                _ofertasVenta[id] = productoDetalle;
            }
            else
            {
                MessageBox.Show(this, "Error al obtener el producto del diccionario de datos.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void GuardarVentaClick(object sender, EventArgs e)
        {
            try
            {
                var valorTipoPago = TipoPagoCombo.SelectedItem.ToString();
                var tipoPago = await _mediator.Send(new ObtenerTipoPagoPorNombre.Query { NombreTipoPago = valorTipoPago });
                if (tipoPago is null)
                {
                    MessageBox.Show(this, "No existe el tipo de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _nuevaVenta.IdTipoPago = tipoPago.IdTipoPago;
                #region Codigo descontinuado
                // obtener las ofertas y ordenar por la que tiene el precio más bajo y mayor cantidad de productos
                //var listaOfertas = await _mediator.Send(new ObtenerListaDeOfertas.Query());
                // hacer una lista de preview (productos y su cantidad)
                //List<Tuple<int,int>> listaPreview = new();
                //foreach (var item in _detallesVenta)
                //{
                //    var idProducto = item.Value.IdProducto;
                //    var cantidad = item.Value.CantidadProducto;
                //    listaPreview.Add(Tuple.Create(idProducto,cantidad));
                //}
                // ir descontando los productos de la preview según la oferta e iterar hasta que no hayan ofertas disponibles
                // para aplicar o no haya productos en la lista

                // Sumar todas las ofertas y los productos que quedaron en la lista preview y actualizar el total
                // agregar a la lista alterna de ofertas aplicadas
                // agregar todos los productos en la compra y agregar el descuento (Cuanto debería haber salido y cuanto salió)
                // enviar la venta
                #endregion
                var listaDetalles = new List<CrearVenta.CommandDetalle>(_detallesVenta.Count);
                foreach (var key in _detallesVenta)
                {
                    listaDetalles.Add(new CrearVenta.CommandDetalle
                    {
                        CantidadProducto = key.Value.CantidadProducto,
                        IdProducto = key.Value.IdProducto,
                        IdProveedor = key.Value.IdProveedor
                    });
                }
                var listaOfertas = new List<CrearVenta.CommandOfertasDetalle>(_ofertasVenta.Count);
                foreach(var key in _ofertasVenta)
                {
                    listaOfertas.Add(new CrearVenta.CommandOfertasDetalle
                    {
                        CantidadOferta = key.Value.CantidadOferta,
                        IdOferta = key.Value.IdOferta
                    });
                }
                _nuevaVenta.Total = ObtieneTotalCarro();
                _nuevaVenta.IdSucursal = 4;
                _nuevaVenta.DetallesVentas = listaDetalles;
                _nuevaVenta.DetallesVentaOfertas = listaOfertas;
                await _mediator.Send(_nuevaVenta);
                MessageBox.Show(this, "Venta generada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(this, "Ha ocurrido un error "+error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private string ObtieneTotalDeCarro()
        {
            var total = 0;
            if (productoCanasta.Rows.Count <= 0) return total.ToString("C0");
            foreach (DataGridViewRow row in productoCanasta.Rows)
            {
                var index = row.Index;
                total += int.Parse(productoCanasta[3, index].Value.ToString().Replace(".","").Replace("$",""));
            }
            return total.ToString("C0");
        }

        private int ObtieneTotalCarro()
        {
            var total = 0;
            if (productoCanasta.Rows.Count <= 0) return total;
            foreach (DataGridViewRow row in productoCanasta.Rows)
            {
                var index = row.Index;
                total += int.Parse(productoCanasta[3, index].Value.ToString().Replace(".", "").Replace("$", ""));
            }
            return total;
        }

        private void SalirButtonClcik(object sender, EventArgs e)
        {
            Close();
        }
    }
}
