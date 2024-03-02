using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BelgianCavesRegisterBlazor1.Client.Models
{
    public class ModeratorModel
    {
        public int Moderator_Id { get; set; }
        [Required]
        [MinLength(4)]
        [DisplayName("Id User : ")]
        public Guid NUser_Id { get; set; }  
    }
}
