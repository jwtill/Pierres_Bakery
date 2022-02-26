using System;
namespace Bakery.Models
{
  public class Bread 
  {
    public int Cost { get; } 
    public int Count { get; set; }

        public Bread(int count)
    {
      Cost = 0;
      Count = count;
    }

    public int calculateCost() 
    { 
      double cost = 0;
      double decCount = Convert.ToDouble(Count);
      if(Count <= 2) 
      {
        cost += 5 * Count;
      } else if(Count % 3 == 0) 
      {
        cost = Count * 3.33;
      } else if(Count % 3 == 1) 
      {
        cost = Count * 3.75;
      } else if(Count % 3 == 2) 
      {
        cost = Count * 4;
      } 
      else 
      {
        return 0;
      }
      return Convert.ToInt32(cost);
    }
  }
}