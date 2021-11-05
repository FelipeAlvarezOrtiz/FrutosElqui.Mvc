using System;
using System.Windows.Forms;
using FrutosElqui.Core.Usuarios;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace FrutosElqui.Escritorio
{
    public partial class Login : Form
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly IMediator _mediator;
        private readonly ApplicationDbContext _context;

        public Login(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager, IMediator mediator, ApplicationDbContext context)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _mediator = mediator;
            _context = context;
            InitializeComponent();
        }

        private void SalirAppClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void LoggearClick(object sender, EventArgs e)
        {
            var user = await _userManager.FindByEmailAsync(EmailTextbox.Text);
            if (user is null)
            {
                MessageBox.Show(this, "Ese usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var signInResult = await _signInManager.CheckPasswordSignInAsync(user, PassInput.Text, false);
            if (signInResult.Succeeded)
            {
                new MainFrame(this._mediator, _context, user,this).Show(this);
                this.Hide();
            }
            else
            {
                MessageBox.Show(this, "La combinación usuario y contraseña no es correcta", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
