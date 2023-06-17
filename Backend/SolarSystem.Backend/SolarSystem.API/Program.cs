using Microsoft.EntityFrameworkCore;
using SolarSystem.Domain.Interfaces;
using SolarSystem.Infrastructure.Data;
using SolarSystem.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SolarSystemContext>(options => options.UseInMemoryDatabase("SolarSystemContext"));
builder.Services.AddTransient<IPlanetService, PlanetService>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<SolarSystemContext>();
    context.Database.EnsureCreated();
}

app.Run();