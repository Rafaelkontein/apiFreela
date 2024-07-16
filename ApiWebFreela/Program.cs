using ApiWebFreela.Data;
using Microsoft.EntityFrameworkCore;
using ApiWebFreela.Controllers;
using ApiWebFreela.Migrations;
using ApiWebFreela.Modell;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var conectionStringMysql = builder.Configuration.GetConnectionString("ConnectionMysql");
builder.Services.AddDbContext<ApiDBContext>(x => x.UseMySql(
       conectionStringMysql,
       Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.37")
    ));
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



app.Run();
