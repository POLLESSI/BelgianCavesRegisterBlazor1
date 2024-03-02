using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BelgianCavesRegisterBlazor1.Client.Models
{
    public class AuthNUser
    {
        [Required]
        [EmailAddress]
        [DisplayName("Email :")]
        public string Email { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(64)]
        [DisplayName("Password : ")]
        public string PasswordHash { get; set; }
        [Required]
        [MinLength(10)]
        [MaxLength(128)]
        [DisplayName("Secret Message : ")]
        public string SecretMessage { get; set; }
    }
}
