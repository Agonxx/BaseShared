using Base.API.Data;
using Base.API.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("ConexaoBanco");

builder.Services.AddDbContext<BaseContext>(opts =>
{
    opts.UseSqlServer(connectionString)
    .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    opts.EnableSensitiveDataLogging();
},
    contextLifetime: ServiceLifetime.Transient,
    optionsLifetime: ServiceLifetime.Singleton);

builder.Services.AddDbContext<BaseContext>(options =>
    options.UseSqlServer(connectionString));


builder.Services.AddCors(options => options
    .AddDefaultPolicy(builder => builder
    .AllowAnyMethod()
    .AllowAnyHeader()
    .AllowAnyOrigin()));


// Area para declarar os Respositorys
builder.Services.AddScoped<UsuarioRepository>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors();
app.Run();
