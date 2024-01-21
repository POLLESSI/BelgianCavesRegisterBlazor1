using System.ComponentModel.DataAnnotations;

namespace BelgianCavesRegisterBlazor1.Client.Models
{
    public class BibliographyModel
    {
        public int Bibliography_Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Author { get; set; }
        [Required]
        public int ISBN { get; set; }
        [Required]
        public string? DataType { get; set; }
        [Required]
        public string? Detail { get; set; }
        public bool Active { get; } = true;
    }
}
