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
        public Byte Pwd { get; set; }
        public bool Active { get; } = true;
    }
}
