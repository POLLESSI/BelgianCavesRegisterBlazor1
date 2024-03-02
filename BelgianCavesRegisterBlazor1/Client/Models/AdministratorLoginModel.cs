using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BelgianCavesRegisterBlazor1.Client.Models
{
    public class AdministratorLoginModel
    {
        [Required]
        [MinLength(4)]
        [MaxLength(64)]
        [DisplayName("Nick Name : ")]
        public string? Pseudo { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(64)]
        [DisplayName("Password : ")]
        public Byte PasswordHash { get; set; }
        public bool Active { get; set; } = true;
    }
}
