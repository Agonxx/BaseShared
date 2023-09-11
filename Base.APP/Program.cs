
using Base.APP;
using Base.APP.Service;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddSingleton<IConfiguration>(builder.Configuration);
builder.Services.AddMudServices();
builder.Services.AddScoped<MudThemeProvider>();

builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IConfiguracaoService, ConfiguracaoService>();
builder.Services.AddScoped<ISaborService, SaborService>();
builder.Services.AddScoped<IPedidoService, PedidoService>();

builder.Services.AddHttpClient("Base.API", opts =>
{
    opts.BaseAddress = new Uri("https://localhost:7118/");
});

await builder.Build().RunAsync();
