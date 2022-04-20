namespace EveOfMidnight.Api.Models
{
    public class WeatherForecastViewModel: ViewModel<WeatherForecast>
    {
        private WeatherForecastViewModel(string selfUrl, WeatherForecast data) 
            : base(selfUrl, data)
        {
        }

        internal static WeatherForecastViewModel From(HttpRequest request, WeatherForecast forecast)
        {
            var selfUrl = $"{request.Path}/{forecast.Date:'O'}";

            var vm = new WeatherForecastViewModel(selfUrl, forecast);
            
            return vm;
        }

    }
}
