using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FrutosElqui.Negocio.Productos;
using MediatR;

namespace FrutosElqui.Escritorio.Formularios
{
    public partial class CrearOferta : Form
    {
        private readonly IMediator _mediator;

        protected Negocio.Ofertas.CrearOferta.Command CarroComprasCabecera = new();
        protected Dictionary<int,Negocio.Ofertas.CrearOferta.CommandDetalle> DiccionarioDetalles = new();

        public CrearOferta(IMediator mediator)
        {
            _mediator = mediator;
            InitializeComponent();
            CodigoProductoInput.Focus();
        }

        private async void CrearOfertaClick(object sender, EventArgs e)
        {
            // Obtener el nombre -- validar
            if (string.IsNullOrEmpty(NombreOfertaInput.Text))
            {
                MessageBox.Show(this, "El nombre de la oferta no puede estar vacio.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // obtener el precio -- validar
            if (string.IsNullOrEmpty(PrecioOfertaInput.Text) ||
                !int.TryParse(PrecioOfertaInput.Text, out var precioOferta))
            {
                MessageBox.Show(this, "El precio de la oferta no puede estar vacio ni tener caracteres invalidos.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                CarroComprasCabecera.NombreOferta = NombreOfertaInput.Text;
                CarroComprasCabecera.PrecioOferta = precioOferta;
                var listaDetalles = new List<Negocio.Ofertas.CrearOferta.CommandDetalle>(DiccionarioDetalles.Count);
                listaDetalles.AddRange(DiccionarioDetalles.Select(detalle => 
                    new Negocio.Ofertas.CrearOferta.CommandDetalle()
                    {
                        IdProducto = detalle.Key, 
                        Cantidad = detalle.Value.Cantidad
                    }));
                CarroComprasCabecera.ProductosEnOferta = listaDetalles;
                await _mediator.Send(CarroComprasCabecera);
                MessageBox.Show(this, $"Se ha agregado la nueva oferta al sistema.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(this, $"Ha ocurrido un error con mensaje {error.Message}.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void KeyBusquedaPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)13) return;
            if (string.IsNullOrEmpty(CodigoProductoInput.Text)) return;
            
            if (int.TryParse(CodigoProductoInput.Text, out var result))
            {
                var productoEncontrado = await _mediator.Send(new ObtenerProducto.Query { IdProducto = result });
                if (productoEncontrado is null)
                {
                    MessageBox.Show(this, "Ese código no está asociado a ningún producto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CodigoProductoInput.Text = string.Empty;
                    CodigoProductoInput.Focus();
                    return;
                }

                var idProductoEncontrado = productoEncontrado.IdProducto;
                //ver si el producto ya esta en el carro
                if (!DiccionarioDetalles.ContainsKey(idProductoEncontrado))
                {
                    productosEnOfertaView.Rows.Add(idProductoEncontrado,
                        productoEncontrado.NombreBusqueda,
                        1,
                        productoEncontrado.PrecioTotal.ToString("C0"));

                    DiccionarioDetalles.Add(idProductoEncontrado, new Negocio.Ofertas.CrearOferta.CommandDetalle()
                    {
                        Cantidad = 1,
                        IdProducto = idProductoEncontrado
                    });
                }
                else
                {
                    foreach (DataGridViewRow row in productosEnOfertaView.Rows)
                    {
                        var idCodigo = int.Parse(row.Cells["CodeID"].Value.ToString() ?? 0.ToString());
                        
                        if (idCodigo != idProductoEncontrado) continue;

                        var index = row.Index;
                        var cantidadActual = int.Parse(productosEnOfertaView[2, index].Value.ToString() ?? 0.ToString());
                        var nuevaCantidad = cantidadActual + 1;
                        //[columna,row] -- 
                        productosEnOfertaView[3, index].Value = (nuevaCantidad * productoEncontrado.PrecioTotal).ToString("C0");
                        productosEnOfertaView[2, index].Value = nuevaCantidad;
                        ModificarCantidad(idProductoEncontrado, nuevaCantidad);
                    }
                }
                
                CodigoProductoInput.Text = string.Empty;
                CodigoProductoInput.Focus();
            }
            else
            {
                MessageBox.Show(this, "Ingrese un codigo de Barra válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModificarCantidad(int id, int nuevaCantidad)
        {
            if (DiccionarioDetalles.TryGetValue(id, out var productoDetalle))
            {
                productoDetalle.Cantidad = nuevaCantidad;
                DiccionarioDetalles[id] = productoDetalle;
            }
            else
            {
                MessageBox.Show(this, "Error al obtener el producto del diccionario de datos.", "Error", 
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
