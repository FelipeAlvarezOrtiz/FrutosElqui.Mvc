using System;
using System.Windows.Forms;
using FrutosElqui.Core.Usuarios;
using FrutosElqui.Escritorio.Formularios;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace FrutosElqui.Escritorio
{
    public partial class MainFrame : Form
    {
        protected IMediator Mediator;
        private readonly ApplicationDbContext _context;
        private readonly int _rutUsuario;
        private readonly AppUser _usuario;
        private readonly Form loginForm;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        public MainFrame(IMediator mediator, ApplicationDbContext context, AppUser usuario,Form loginForm, RoleManager<IdentityRole> roleManager, UserManager<AppUser> userManager)
        {
            Mediator = mediator;
            _context = context;
            _usuario = usuario;
            this.loginForm = loginForm;
            _roleManager = roleManager;
            _userManager = userManager;
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

        private void AbrirLoginClosing(object sender, FormClosedEventArgs e)
        {
            loginForm.Show();
        }

        private void CrearNuevoUsuarioClick(object sender, EventArgs e)
        {
            new CrearUsuario(this._roleManager,this._userManager,this.Mediator).Show();
        }

        private void IngresoDinero_Click(object sender, EventArgs e)
        {
            new IngresosDeDinero(Mediator).Show();
        }

        private void EgresoDineroClick(object sender,EventArgs e)
        {

        }
    }

}
