using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BelgianCavesRegisterBlazor1.Client.Models
{
    public class AuthNUser
    {
        [Required]
        [EmailAddress]
        [DisplayName("Email")]
        public string Email { get; set; }
        [Required]
        public string Pwd { get; set; }
        [Required]
        [MinLength(10)]
        public string SecretMessage { get; set; }
    }
}
