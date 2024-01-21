using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BelgianCavesRegisterBlazor1.Client.Models
{
    public class NOwnerModel
    {
        public int NOwner_Id { get; set; }
        [Required]
        [DisplayName("Status")]
        public string? Status { get; set; }
        [Required]
        [DisplayName("Aggreement")]
        public string? Agreement { get; set; }
        public bool Active { get; } = true;
    }
}
