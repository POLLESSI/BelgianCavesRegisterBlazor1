﻿namespace BelgianCavesRegisterBlazor1.Client.Shared
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }
        public int TemperatureC { get; set; }
        public string? Summary { get; set; }
        public int Temperature => 32 + (int)(TemperatureC / 0.5556);
    }
}
