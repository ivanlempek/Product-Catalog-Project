using Application.ProductService.Application.Interfaces;
using Application.ProductService.Infrastructure.Data;
using Application.ProductService.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ProductDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Database") ??
        throw new InvalidOperationException("Erro: Sua conex�o n�o foi encontrada!"));
});

builder.Services.AddScoped<IProductService, ProductService>();

// Cors para aceitar meus dominios
builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirBlazorWasm2", builder =>
    {
        builder.WithOrigins("http://localhost:5039", "https://localhost:7057")
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowCredentials();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("PermitirBlazorWasm2");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();