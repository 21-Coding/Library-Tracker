using System.Collections.Generic;

namespace Library.Models
{

  public class Checkout
  {
    // public Checkout()
    // {
    //   this.Patrons = new HashSet<Patron>();
    // }

    public int CheckoutId { get; set; }
    public int TitleId { get; set; }
    public int PatronId { get; set; }
    public virtual ApplicationUser user { get; set; }
    // public virtual ICollection<Patron> Patrons { get; set; }

    public Title Title { get; set; }
    public Patron Patron { get; set; }

  }

}