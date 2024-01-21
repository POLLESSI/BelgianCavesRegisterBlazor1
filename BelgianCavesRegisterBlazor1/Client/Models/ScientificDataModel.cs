using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BelgianCavesRegisterBlazor1.Client.Models
{
    public class ScientificDataModel
    {
        public int ScientificData_Id { get; set; }
        [Required(ErrorMessage = "Type of data is required ! ")]
        [MinLength(3), MaxLength(128)]
        [DisplayName("Data's Type : ")]
        public string? DataType { get; set; }
        [Required(ErrorMessage = "The details of de data are required ! ")]
        [MinLength(3)]
        [MaxLength(512)]
        [DisplayName("Details : ")]
        public string? DetailsData { get; set; }
        [Required(ErrorMessage = "The references of de data are required ! ")]
        [MinLength(3), MaxLength(256)]
        [DisplayName("References : ")]
        public string? ReferenceData { get; set; }
        public bool Active { get; set; } = true;
    }
}
