using System.ComponentModel.DataAnnotations;

namespace WebAPI_Parcial.DAL.Entities
{
    public class Room:AuditBase
    {
        [Display(Name = "Number room")]
        [Required(ErrorMessage = "¡El campo {0} es obligatorio!")]
        public int Number { get; set; } //varchar(50)
        [Display(Name = "Max guests")]
        public string? MaxGuests { get; set; }
        [Display(Name = "Availability")]
        public bool Availability { get; set; }
    }
}
