using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace L2Ex2.Models
{
    public class Reservations
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public DateTime ReservationDate { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
                
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        [MaxLength(20)]
        public string Surname { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [MaxLength(50)]
        [Required, EmailAddress]
        public string Contact { get; set; }

        [Required]
        [MaxLength(20)]
        public string CarPlate { get; set; }
        [Required]
        [MaxLength(20)]
        public string VinNumber { get; set; }


        [Required]
        public string Brand { get; set; }

        [Required]
        public string Model { get; set; }


        [Required]
        [MaxLength(50)]
        public string Describe { get; set; }
    }
}
