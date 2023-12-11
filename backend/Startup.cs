using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using BookApi.Models;

public class Startup
{
  public Startup(IConfiguration configuration)
  {
    Configuration = configuration;
  }

  public IConfiguration Configuration { get; }

  public void ConfigureServices(IServiceCollection services)
  {
    // Configure other services

    services.AddDbContext<BookContext>(options =>
        options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));
  }

  public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
  {
    // Configure middleware and request pipeline
  }
}
