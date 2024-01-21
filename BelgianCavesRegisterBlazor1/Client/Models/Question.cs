using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BelgianCavesRegisterBlazor1.Client.Models
{
    public class Question
    {
        [Required]
        [MaxLength(256)]
        [DisplayName("Enonce : ")]
        public String? Enonce { get; set; }
        public bool Response { get; set; }
    }
}
