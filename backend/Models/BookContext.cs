using Microsoft.EntityFrameworkCore;
using BookAPI.Models;
using BookAPI.Controllers;

public class BookContext : DbContext
{
  public BookContext(DbContextOptions<BookContext> options)
      : base(options)
  {
  }

  public DbSet<Book> Books { get; set; }
}