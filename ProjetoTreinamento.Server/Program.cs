using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi;
using ProjetoTreinamento.Application.Interfaces.Services;
using ProjetoTreinamento.Application.MapperProfiles;
using ProjetoTreinamento.Application.Queries.Tarefas.GetAll;
using ProjetoTreinamento.CrossCutting.Models;
using ProjetoTreinamento.Domain.Interfaces;
using ProjetoTreinamento.Infrastructure.Contexts;
using ProjetoTreinamento.Infrastructure.Repositories;
using ProjetoTreinamento.Infrastructure.Services.Tarefas;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddScoped<IChecklistRepository, ChecklistRepository>();
builder.Services.AddScoped<ITarefaRepository, TarefaRepository>();
builder.Services.AddScoped<IItemRepository, ItemRepository>();
builder.Services.AddScoped<ITarefaService, TarefaService>();
builder.Services.AddHttpContextAccessor();

builder.Services.AddAutoMapper(cfg => { }, typeof(TarefaProfiler));

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "To Do List", Version = "v1" });
});

builder.Services.AddMediatR(
    cfg => cfg.RegisterServicesFromAssembly(typeof(GetAllTarefaQueryHandler).Assembly)
);

builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirAngular",
        policy =>
        {
            policy.WithOrigins("http://localhost:4200")
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi


IConfigurationSection appSettingsConfigurationSection = builder.Configuration.GetSection("AppSettings");
AppSettings appSettings = appSettingsConfigurationSection.Get<AppSettings>() ?? new();

IConfigurationSection connectionSettingsSection = builder.Configuration.GetSection("ConnectionSettings");
ConnectionSettings connectionSettings = connectionSettingsSection.Get<ConnectionSettings>() ?? new();
builder.Services.AddDbContext<EXETPSContext>(options =>
                options.UseSqlServer(
                    connectionSettings.GetConnectionString("ProjetoTreintamento"),
                    o => o.UseCompatibilityLevel(120)
                )
            );
var app = builder.Build();

app.UseDefaultFiles();
app.MapStaticAssets();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseCors("PermitirAngular");

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
