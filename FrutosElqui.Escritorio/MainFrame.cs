using System;
using System.Windows.Forms;
using FrutosElqui.Escritorio.Formularios;
using FrutosElqui.Persistencia;
using MediatR;

namespace FrutosElqui.Escritorio
{
    public partial class MainFrame : Form
    {
        protected IMediator Mediator;
        private readonly ApplicationDbContext _context;
        private int rutUsuario = 18823970;

        public MainFrame(IMediator mediator, ApplicationDbContext context)
        {
            Mediator = mediator;
            _context = context;
            InitializeComponent();
        }

        private void NuevaVentaClick(object sender, EventArgs e)
        {
            new NuevaVenta(rutUsuario,Mediator,_context).Show(this);
        }

        private void ProductosClick(object sender, EventArgs e)
        {
            new Productos(ref this.Mediator).Show();
        }
    }

}
