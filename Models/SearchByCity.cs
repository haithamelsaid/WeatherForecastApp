using System.ComponentModel.DataAnnotations;


namespace WeatherForecastApp.Models
{
    public class SearchByCity
    {
        [Required(ErrorMessage ="City Name is empty!")]
        [Display(Name ="City Name")]
        [StringLength(30,MinimumLength =2,ErrorMessage ="Invalid Input")]
        public string CityName { get; set; }
        

    }
}
