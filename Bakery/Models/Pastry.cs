namespace Bakery.Models
{
  public class Pastry //Class def
  {
    public int Cost { get; } //field
    
    public Pastry(int cost)
    {
      Cost = cost;
    }
  }
}