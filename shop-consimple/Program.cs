using Core.Mapper;
using Core.Queries.Clients;
using Domain.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopConsimple.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
    .AddEnvironmentVariables();

var connectionString = builder.Configuration.GetConnectionString("Connection");

builder.Services.AddDbContext<ShopDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddControllers(cfg =>
{
    cfg.Filters.Add(new ProducesAttribute("application/json"));
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRepositories();
builder.Services.AddAutoMapper(typeof(ShopAutomapperProfile));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetClientsWithBirthdaysCommand).Assembly));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<ShopDbContext>();
    context.Database.Migrate();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
