using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrutosElqui.Core.Misc
{
    public class Courrier
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity),Key]
        public int IdCourrier { get; set; }
        [MaxLength(100)]
        public string NombreCourrier { get; set; }
    }
}
