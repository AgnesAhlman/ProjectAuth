using Microsoft.EntityFrameworkCore;
using RecipeAPI.Models;
using RecipeAPI.Controllers;

public class RecipeContext : DbContext
{
  public RecipeContext(DbContextOptions<RecipeContext> options)
      : base(options)
  {
  }

  public DbSet<Recipe> Recipes { get; set; }
}