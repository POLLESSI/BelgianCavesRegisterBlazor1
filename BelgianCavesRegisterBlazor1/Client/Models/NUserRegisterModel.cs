using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BelgianCavesRegisterBlazor1.Client.Models
{
    public class NUserRegisterModel
    {
        public Guid NUserRegister_Id { get; set; }
        [Required(ErrorMessage = "The Nickname is required ! ")]
        [DisplayName("NickName ? ")]
        public string? Pseudo { get; set; }
        [Required(ErrorMessage = "Email is required ! ")]
        [EmailAddress]
        [MaxLength(64)]
        [DisplayName("Email ? ")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "The password is required ! ")]
        [MaxLength(64)]
        [DisplayName("Password ? ")]
        public Byte PasswordHash { get; set; }
        [Required(ErrorMessage = "Repeat the password ! ")]
        [Compare("Pwd")]
        [DisplayName("Second Password ? ")]
        public string? SecondPassword { get; set; }
        [Required(ErrorMessage = "Id Person is required ! ")]
        [DisplayName("Id Person ? ")]
        public int NPerspn_Id { get; set; }
        [Required(ErrorMessage = "Id Rôle is required ! ")]
        [DisplayName("Id Rôle ? ")]
        public int Role_Id { get; set; }
        public bool Active { get; } = true;
    }
}
