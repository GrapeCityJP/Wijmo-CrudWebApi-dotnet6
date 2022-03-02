using Microsoft.EntityFrameworkCore;
using webinar0302.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var MyAllowOrigins = "_myAllowOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowOrigins,
                      builder =>
                      {
                          builder.AllowAnyOrigin()
                                  .AllowAnyMethod()
                                  .AllowAnyHeader();
                      });
});


builder.Services.AddControllers();

builder.Services.AddDbContext<test2022Context>(options =>
{
    options.UseMySql(builder.Configuration.GetConnectionString("Connection"), new MySqlServerVersion(new Version(8, 0, 24)));
});


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

app.UseCors(MyAllowOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
