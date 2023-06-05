using _1.DAL.Context;
using ASM_CS5.IRepositories;
using ASM_CS5.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped(typeof(IAllRepositories<>), typeof(AllRepositories<>));
builder.Services.AddDbContext<FpolyDBContext>(c => c.UseSqlServer(@"Data Source=DESKTOP-OJ4UDNH\SQLEXPRESS;Initial Catalog=CuaHangAo2;Persist Security Info=True;User ID=Nbton03;Password=123"));
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
