using Base.APP.Service.Interfaces;
using Microsoft.AspNetCore.Components;
using static Base.APP.Pages.FetchData;

namespace Base.APP.Service
{
    public class WeatherForecastService : BaseService<WeatherForecast>, IWeatherForecastService
    {
        public WeatherForecastService(IHttpClientFactory httpClientFactory, NavigationManager navigation, IConfiguration configuracao) : base(httpClientFactory, navigation, configuracao)
        {
        }
    }
}
