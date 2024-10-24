using Microsoft.Data.SqlClient;
using OffshoreTradeFinance.Domain.Interfaces.Repositories;
using OffshoreTradeFinance.Domain.Interfaces.Services;
using OffshoreTradeFinance.Domain.Service;
using OffshoreTradeFinance.Infra.Repository;
using System.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IDbConnection>(sp =>
    new SqlConnection(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IBoletoRepository, BoletoRepository>();
builder.Services.AddScoped<IBoletoService, BoletoService>();

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

app.Run();