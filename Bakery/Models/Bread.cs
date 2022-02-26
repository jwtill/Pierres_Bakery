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
      if(decCount <= 2) 
      {
        cost += 5 * decCount;
      } else if(decCount % 3 == 0) 
      {
        cost = decCount * 3.33;
      } else if(decCount % 3 == 1) 
      {
        cost = decCount * 3.75;
      } else if(decCount % 3 == 2) 
      {
        cost = decCount * 4;
      } 
      else 
      {
        return 0;
      }
      return Convert.ToInt32(cost);
    }
  }
}