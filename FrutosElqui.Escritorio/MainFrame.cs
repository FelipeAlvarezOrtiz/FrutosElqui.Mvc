using System;
using System.Windows.Forms;
using FrutosElqui.Core.Usuarios;
using FrutosElqui.Escritorio.Formularios;
using FrutosElqui.Persistencia;
using MediatR;

namespace FrutosElqui.Escritorio
{
    public partial class MainFrame : Form
    {
        protected IMediator Mediator;
        private readonly ApplicationDbContext _context;
        private readonly int _rutUsuario;
        private readonly AppUser _usuario;
        private readonly Form loginForm;

        public MainFrame(IMediator mediator, ApplicationDbContext context, AppUser usuario,Form loginForm)
        {
            Mediator = mediator;
            _context = context;
            _usuario = usuario;
            this.loginForm = loginForm;
            _rutUsuario = int.Parse(_usuario.Rut);
            InitializeComponent();
            UserNameText.Text = usuario.Nombre;
            CargoLabel.Text = usuario.Role;
        }

        private void NuevaVentaClick(object sender, EventArgs e)
        {
            new NuevaVenta(_rutUsuario,Mediator,_context).Show(this);
        }

        private void ProductosClick(object sender, EventArgs e)
        {
            new Productos(ref this.Mediator).Show();
        }

        private void InventariosClick(object sender, EventArgs e)
        {
            new Inventarios(Mediator).Show();
        }

        private void SalirAppClick(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();
        }
    }

}
