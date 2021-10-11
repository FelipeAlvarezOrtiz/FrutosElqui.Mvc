using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FrutosElqui.Core.Misc;

namespace FrutosElqui.Core.Clientes
{
    public class Cliente
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCliente { get; set; }
        [MinLength(5, ErrorMessage = "No alcanza el minimo de caracteres."), MaxLength(75, ErrorMessage = "Sobrepasa el limite de caracteres permitido")]
        public string NombreCliente { get; set; }
        [MinLength(5, ErrorMessage = "No alcanza el minimo de caracteres."), MaxLength(100, ErrorMessage = "Sobrepasa el limite de caracteres permitido")]
        public string DireccionCliente { get; set; }
        [MinLength(10), MaxLength(10)]
        public string RutCliente { get; set; }
        [Required]
        public bool EsMayorista { get; set; }
        [Required,Column(name:"IdSector")]
        public Sector SectorCliente { get; set; }
        [Required, Column(name: "IdComuna")]
        public Comuna ComunaCliente { get; set; }
        [Required, Column(name: "IdRegion")]
        public Region RegionCliente { get; set; }
    }
}
