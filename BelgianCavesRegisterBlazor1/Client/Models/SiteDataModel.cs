﻿namespace BelgianCavesRegisterBlazor1.Client.Models
{
    public class SiteDataModel
    {
        public int Site_Id { get; set; }
        public string? Site_Name { get; set; }
        public string? Site_Description { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public decimal Length { get; set; }
        public decimal Depth { get; set; }
        public string? AccessRequirement { get; set; }
        public string? PracticalInformation { get; set; }
        public int LambdaData_Id { get; set; }
        public int NOwner_Id { get; set; }
        public int ScientificData_Id { get; set; }
        public int Bibliography_Id { get; set; }
        public bool Active { get;} = true;
    }
}
