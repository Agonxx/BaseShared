using Base.MOBILE.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Syncfusion.Blazor;

namespace Base.MOBILE
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            //builder.Services.AddHttpClient();

            builder.Services.AddSingleton<IConfiguration>(builder.Configuration);

            builder.Services.AddScoped<IUsuarioService, UsuarioService>();

            builder.Services.AddHttpClient("Base.API", opts =>
            {
                opts.BaseAddress = new Uri("https://localhost:44316/");
            });

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddSyncfusionBlazor();
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}