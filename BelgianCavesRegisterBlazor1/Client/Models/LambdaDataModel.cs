using System.ComponentModel.DataAnnotations;

namespace BelgianCavesRegisterBlazor1.Client.Models
{
    public class LambdaDataModel
    {
        public int LambdaData_Id { get; set; }
        [Required]
        public string? Localisation { get; set; }
        [Required]
        public string? Topo {  get; set; }
        [Required]
        public string? Acces { get; set; }
        [Required]
        public string? EquipementSheet { get; set; }
        [Required]
        public string? PracticalInformation { get; set; }
        [Required]
        public string? Description { get; set; }
        public bool Active { get; } = true;
    }
}
