using System.Collections.Generic;

namespace Library.Models
{
  public class Patron
  {
    public Patron()
    {
      this.Titles = new HashSet<Checkout>();
    }

    public int PatronId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Checkout> Titles { get; set; }
  }
}