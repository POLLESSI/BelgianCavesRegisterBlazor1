using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace BelgianCavesRegisterBlazor1.Client.Models
{
    public class AdministratorModel
    {
        
        public int Administrator_Id { get; set; }
        [Required]
        [DisplayName("Id User: ")]
        [MinLength(4)]
        public Guid NUser_Id { get; set; }
    }
}
