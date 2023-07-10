
using Base.APP.Service;
using Base.APP;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddSingleton<IConfiguration>(builder.Configuration);

builder.Services.AddScoped<IWeatherForecastService, WeatherForecastService>();

builder.Services.AddHttpClient("Base.API", opts =>
{
    opts.BaseAddress = new Uri("https://localhost:44316/");
});

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:44316/") });

await builder.Build().RunAsync();
