using System;
using Microsoft.EntityFrameworkCore;
using backend.Models;
using Microsoft.Extensions;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

 builder.Services.AddDbContext<Contexto>(
     options => options.UseSqlServer("ConnectionString")
//     // options => options.UseSqlServer("Data Source=GZTVIX-BDHM01;Integrated Security=True;")
 );

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
