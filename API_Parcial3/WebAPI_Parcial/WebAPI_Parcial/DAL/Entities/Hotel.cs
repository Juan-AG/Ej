using System.ComponentModel.DataAnnotations;

namespace WebAPI_Parcial.DAL.Entities
{
    public class Hotel:AuditBase
    {
        [Display(Name = "Hotel")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        [Required(ErrorMessage = "¡El campo {0} es obligatorio!")]
        public string Name { get; set; } //varchar(50)
        [Display(Name = "Address")]
        [Required(ErrorMessage = "!El campo {1} es obligatorio")]
        public string Address { get; set; }
        [Display(Name = "Phone")]
        public string? Phone { get; set; }
        [Display(Name = "Stars")]
        public int Stars { get; set; }
        [Display(Name = "Name City")]
        public int City { set; get; }
    }
}
