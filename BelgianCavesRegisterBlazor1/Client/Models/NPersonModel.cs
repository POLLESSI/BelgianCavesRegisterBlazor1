using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BelgianCavesRegisterBlazor1.Client.Models
{
    public class NPersonModel
    {
        public int NPerson_Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(32)]
        [DisplayName("Lastname")]

        public string Lastname { get; set; }
        [Required]
        [MinLength(3), MaxLength(32)]
        [DisplayName("Firstname")]
        public string Firstname { get; set; }
        [Required]
        [DisplayName("Birth Date")]
        public DateTime? BirthDate { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(64)]
        [DisplayName("Email")]
        public string? Email { get; set; }
        [Required]
        [MinLength(3), MaxLength(64)]
        [DisplayName("Street")]
        public string? Address_Street { get; set; }
        [Required]
        [MaxLength(5)]
        [DisplayName("N°")]
        public int Address_Nbr { get; set; }
        [Required]
        [MaxLength(5)]
        [DisplayName("Postal Code")]
        public int PostalCode { get; set; }
        [Required]
        [MinLength(2), MaxLength(64)]
        [DisplayName("City")]
        public string Address_City { get; set; }
        [Required]
        [MinLength(3), MaxLength(64)]
        [DisplayName("Country")]
        public string Address_Country { get; set;}
        public int Gsm { get; set; }
        [MaxLength(16)]
        [DisplayName("Telephone")]
        public int Telephone { get; set; }
        [MaxLength(16)]
        [DisplayName("Gsm")]
        public bool Active { get; } = true;
    }
}
