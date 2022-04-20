namespace EveOfMidnight.Api.Models
{
    public class WeatherForecastViewModelCollection: ViewModelCollection<WeatherForecast>
    {
        private WeatherForecastViewModelCollection(string selfUrl) : base(selfUrl)
        {
        }

        private WeatherForecastViewModelCollection(string selfUrl, IEnumerable<ViewModel<WeatherForecast>> data) : base(selfUrl, data)
        {
        }

        public static WeatherForecastViewModelCollection From(HttpRequest request, IEnumerable<WeatherForecast> weatherForecasts)
        {
            var requestPath = request.Path;

            var data = weatherForecasts.Select(x => WeatherForecastViewModel.From(request, x));

            var vm = new WeatherForecastViewModelCollection(requestPath.ToString(), data);

            return vm;
        }
    }
}
