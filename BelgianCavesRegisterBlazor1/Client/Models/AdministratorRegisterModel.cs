using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BelgianCavesRegisterBlazor1.Client.Models
{
    public class AdministratorRegisterModel
    {
        public int Administrator_Id { get; set; }
        [Required]
        [MinLength(4)]
        [MaxLength(64)]
        [DisplayName("Nick Name ? ")]
        public string? Nickname { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(64)]
        [DisplayName("Password ? ")]
        public byte PasswordHashd { get; set; }
        [Required]
        [DisplayName("Id User ? ")]
        public Guid NUser_Id { get; set; }
        public bool Active { get; set; } = true;

    }
}
