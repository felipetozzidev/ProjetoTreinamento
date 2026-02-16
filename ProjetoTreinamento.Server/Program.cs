using ProjetoTreinamento.CrossCutting.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirAngular",
        policy =>
        {
            policy.WithOrigins("http://localhost:4200") // A URL do seu Angular
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

IConfigurationSection appSettingsConfigurationSection = builder.Configuration.GetSection("AppSettings");
AppSettings appSetings = appSettingsConfigurationSection.Get<AppSettings>() ?? new();

var app = builder.Build();

app.UseDefaultFiles();
app.MapStaticAssets();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseCors("PermitirAngular");

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
