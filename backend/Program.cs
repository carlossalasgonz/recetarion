using Recetarion.Data;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<RecetarionDbContext>( options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString) ));

Environment.SetEnvironmentVariable("Seeder:Admin:Username", builder.Configuration.GetValue<string>("Seeder:Admin:Username"));
Environment.SetEnvironmentVariable("Seeder:Admin:Email", builder.Configuration.GetValue<string>("Seeder:Admin:Email"));
Environment.SetEnvironmentVariable("Seeder:Admin:Password", builder.Configuration.GetValue<string>("Seeder:Admin:Password"));
Environment.SetEnvironmentVariable("Seeder:Image:Name", builder.Configuration.GetValue<string>("Seeder:Image:Name"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
