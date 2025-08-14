
using Cart.Services.CouponApi.Data;
using Cart.Services.CouponApi.Mapping;
using Cart.Services.CouponApi.Repositories;
using Cart.Services.CouponApi.Services;
using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

Env.Load();
var conn = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ICouponRepository, CouponRepository>();
builder.Services.AddScoped<CouponService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICouponRepository, CouponRepository>();
builder.Services.AddScoped<CouponService>();
builder.Services.AddDbContext<CouponDbContext>(options =>
    options.UseSqlite(conn));


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
ApplyMigration();
app.Run();

void ApplyMigration()
{
    using(var scope = app.Services.CreateScope())
  {
    var _db = scope.ServiceProvider.GetRequiredService<CouponDbContext>();
    if (_db.Database.GetAppliedMigrations().Count() > 0)
    {
      _db.Database.Migrate();
    }
  }
}
