using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace FrutosElqui.Core.Usuarios
{
    public class AppUser : IdentityUser
    {
        [MaxLength(150, ErrorMessage = "Excede el máximo de limites permitido.")]
        public string Direccion { get; set; }
        [Required]
        public string Role { get; set; }
        [MinLength(9), MaxLength(15), Required]
        public string Rut { get; set; }
        [MaxLength(100), Required]
        public string Nombre { get; set; }
    }
}
