using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BelgianCavesRegisterBlazor1.Client.Models
{
    public class Message
    {
        [Required]
        [DisplayName("Message")]
        public string? Content { get; set; }
        [Required]
        [DisplayName("Author")]
        public string? Author { get; set; }
    }
}
