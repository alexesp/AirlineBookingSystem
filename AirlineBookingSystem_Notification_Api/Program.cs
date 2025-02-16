using System.Data;
using System.Reflection;
using AirlineBookingSystem_Notifications_Application.Handlers;
using AirlineBookingSystem_Notifications_Application.Interfaces;
using AirlineBookingSystem_Notifications_Application.Services;
using AirlineBookingSystem_Notifications_Core.Repositories;
using AirlineBookingSystem_Notifications_Infrastructure.Repositories;
using Microsoft.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Register MediatR
var asseblies = new Assembly[]
{
    Assembly.GetExecutingAssembly(),
   typeof(SendNotificationHandler).Assembly
    
};
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(asseblies));



//Applicaton Services
builder.Services.AddScoped<INotificationService, NotificationService>();
builder.Services.AddScoped<INotificationRepository, NotificationRepository>();
//Add Sql Connection
builder.Services.AddScoped<IDbConnection>(sp =>
new SqlConnection(builder.Configuration.GetConnectionString("DefaultConnection")));

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

app.Run();
