using Base.APP;
using Base.APP.Service;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddSingleton<IConfiguration>(builder.Configuration);

builder.Services.AddScoped<IUsuarioService, UsuarioService>();

builder.Services.AddHttpClient("Base.API", opts =>
{
    opts.BaseAddress = new Uri("https://localhost:7118/");
});

await builder.Build().RunAsync();