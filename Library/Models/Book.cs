using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Library.Models

{
  public class Book
  {
    public Book()
    {
      this.Authors = new HashSet<BookAuthor>();
    }
    public int BookId { get; set; }
    public string Title { get; set; }
    public int PublishedYear { get; set; }
    public virtual ICollection<BookAuthor> Authors { get; set; }
  }
}