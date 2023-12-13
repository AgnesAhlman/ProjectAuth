using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RecipeAPI.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
 builder.Services.AddDbContext<RecipeContext>(options =>
   options.UseNpgsql("Host=localhost;Port=5432;Database=what-to-eat;User Id=agnesahlman;Password=fredricson")); 

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Add CORS policy
app.UseCors(policy =>
{
    policy.AllowAnyOrigin()
          .AllowAnyMethod()
          .AllowAnyHeader();
});

app.UseAuthorization();

app.MapControllers();

app.Run();