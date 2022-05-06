using KodluyoruzTest.Business;
using KodluyoruzTest.DataAccess;
using KodluyoruzTest.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(opt =>
{
    opt.UseNpgsql("Server=localhost;Port=5433;Database=kodluyorz_testDb;User Id=sa;Password=AbcUser1234;");
});


builder.Services.AddScoped<ProductRepository>();
builder.Services.AddScoped<ProductService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "Vue",
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:8080").AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                          policy.AllowAnyHeader();
                          policy.AllowAnyMethod();
                          policy.AllowAnyOrigin();
                      });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("Vue");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
