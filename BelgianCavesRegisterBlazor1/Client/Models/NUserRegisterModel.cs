using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BelgianCavesRegisterBlazor1.Client.Models
{
    public class NUserRegisterModel
    {
        public Guid NUserRegister_Id { get; set; }
        [Required(ErrorMessage = "The Nickname is required ! ")]
        [DisplayName("NickName ? ")]
        public string? Nickname { get; set; }
        [Required(ErrorMessage = "Email is required ! ")]
        [EmailAddress]
        [MaxLength(64)]
        [DisplayName("Email ? ")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "The password is required ! ")]
        [MaxLength(64)]
        [DisplayName("Password ? ")]
        public Byte Pwd { get; set; }
        [Required(ErrorMessage = "Repeat the password ! ")]
        [Compare("Pwd")]
        [DisplayName("Second Password ? ")]
        public string? SecondPassword { get; set; }
        public bool Active { get; } = true;
    }
}
