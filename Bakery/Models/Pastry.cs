namespace Bakery.Models
{
  public class Pastry //Class def
  {
    public int Cost { get; } //field
    public int Count { get; set; }

    
    public Pastry(int count)
    {
      Cost = 0;
      Count = count;
    }
  }
}