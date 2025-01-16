using EmployeeAppAPI.Data;
using Microsoft.EntityFrameworkCore;
using EmployeeAppAPI.Controllers;
using EmployeeAppAPI.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionstring = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string not found");
builder.Services.AddDbContext<EmployeeAppContext>(options => 
 options.UseSqlServer(connectionstring));



builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.MapOpenApi();
//}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
};

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
