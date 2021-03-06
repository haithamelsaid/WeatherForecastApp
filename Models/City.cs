using System.ComponentModel.DataAnnotations;

namespace WeatherForecastApp.Models
{
    public class City
    {

        [Display(Name ="City Name :")]
        public string Name { get; set; }


        [Display(Name = "Temp.")]
        public float Temperature { get; set; }


        [Display(Name = "Humidity")]
        public int Humidity { get; set; }


        [Display(Name = "Pressure:")]
        public float Pressure { get; set; }


        [Display(Name = "Wind Speed:")]
        public int Wind { get; set; }


        [Display(Name ="Weather Condition:")]
        public string Weather { get; set; }



    }
}
