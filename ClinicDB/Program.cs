using ClinicDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<ConnectionString>(builder.Configuration.GetSection("ConnectionStrings"));

builder.Services.AddRazorPages();
builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile(path: "appSettings.json", optional: true, reloadOnChange: true);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
