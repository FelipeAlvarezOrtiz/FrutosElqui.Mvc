using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrutosElqui.Core.Usuarios;
using FrutosElqui.Negocio.Misc.Comunas;
using FrutosElqui.Negocio.Misc.Regiones;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Escritorio.Formularios
{
    public partial class CrearUsuario : Form
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly IMediator _mediator;
        
        public CrearUsuario(RoleManager<IdentityRole> roleManager, UserManager<AppUser> userManager, IMediator mediator)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _mediator = mediator;
            InitializeComponent();
        }

        private async void CargarForm(object sender, System.EventArgs e)
        {
            await CargarRoles();
            await CargarComunas();
            await CargarRegiones();
        }

        private async Task CargarRoles()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            RolesBox.DataSource = roles;
            RolesBox.ValueMember = "Name";
            RolesBox.DisplayMember = "Name";
        }

        private async Task CargarComunas()
        {
            var comunas = await _mediator.Send(new ListaDeComunas.Query { });
            ComunaBox.DataSource = comunas;
            ComunaBox.ValueMember = "IdComuna";
            ComunaBox.DisplayMember = "NombreComuna";
        }

        private async Task CargarRegiones()
        {
            var regiones = await _mediator.Send(new ListaDeRegiones.Query { });
            RegionBox.DataSource = regiones;
            RegionBox.ValueMember = "IdRegion";
            RegionBox.DisplayMember = "NombreRegion";
        }

        private async void AgregarUsuario(object sender,System.EventArgs e)
        {
            try
            {
                if (!EmailInput.Text.Contains("@") && !EmailInput.Text.Contains("."))
                {
                    MessageBox.Show(this, "Formato de correo no válido", "Error");
                    return;
                }

                var email = EmailInput.Text;
                var pass = PassInput.Text;
                var direccion = DireccionInput.Text;
                var nombre = NombreInput.Text;
                var idRegion = RegionBox.SelectedValue.ToString() ?? 0.ToString();
                var region = await _mediator.Send(new ObtenerRegion.Query { IdRegion = int.Parse(idRegion) });
                var idComuna = ComunaBox.SelectedValue.ToString() ?? 0.ToString();
                var comuna = await _mediator.Send(new ObtenerComuna.Query { IdComuna = int.Parse(idComuna) });
                var role = RolesBox.SelectedValue.ToString();
                var telefono = TelefonoInput.Text;
                var user = new AppUser
                {
                    Email = email,
                    UserName = email,
                    PhoneNumber = telefono,
                    PhoneNumberConfirmed = true,
                    Role = role,
                    Nombre = nombre,
                    Rut = RutInput.Text,
                    Direccion = direccion,
                    EmailConfirmed = true,
                    RegionUsuario = region,
                    ComunaUsuario = comuna
                };
                var result = await _userManager.CreateAsync(user, pass);
                user = await _userManager.FindByEmailAsync(email);
                if (user is not null)
                {
                    await _userManager.AddToRoleAsync(user, role);
                }

                MessageBox.Show(this, "El usuario se ha generado con exito", "Información", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(this, $"Ha ocurrido un error con mensake {error.Message}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CerrarUsuarioClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
