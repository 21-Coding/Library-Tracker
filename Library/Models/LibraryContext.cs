using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Library.Models
{
  public class LibraryContext : DbContext
  {
    public DbSet<Book> Books { get; set; }

    public LibraryContext(DbContextOptions options) : base(options) { }
  }
}