using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Permissions;

namespace BelgianCavesRegisterBlazor1.Client.Models
{
    public class NUserModel
    {
        public Guid NUser_Id { get; set; }
        [Required]
        [MaxLength(64)]
        [DisplayName("Nickname ? ")]
        public string? Pseudo { get; set; }
        [Required]
        [MaxLength(64)]
        [DisplayName("Password ? ")]
        public byte PasswordHash { get; set; }
        [Required]
        [DisplayName("Security Stamp ? ")]
        public Guid SecurityStamp { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength (64)]
        [DisplayName("Email ? ")]

        public string? Email { get; set; }
        [Required]
        [DisplayName("Id Person ? ")]
        public int NPerson_Id { get; set; }
        [DisplayName("Role ? ")]
        public int Role_Id { get; set; }
        public bool Active { get; set; } = true;
    }
}
