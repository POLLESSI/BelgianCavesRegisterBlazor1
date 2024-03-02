using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BelgianCavesRegisterBlazor1.Client.Models
{
    public class NUserLoginModel
    {
        [Required]
        [EmailAddress]
        [DisplayName("Email ? ")]
        public string? Email { get; set; }
        [Required]
        public Byte PasswordHash { get; set; }
        public bool Active { get; } = true;
    }
}
