namespace Bakery.Models
{
  public class Bread //Class def
  {
    public int Cost { get; } //field
    public int Count {get; set;}
    
    public Bread(int count)//constructor
    {
      Cost = 0;
      Count = count;
    }
    //Deal method
    public int calculateCost() {
      // public int cost = 0;
      // return cost;
    }
  }
}