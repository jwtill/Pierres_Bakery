using System;
namespace Bakery.Models
{
  public class Pastry 
  {
    public int Cost { get; } 
    public int Count { get; set; }

    public Pastry(int count)
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
        cost += 2 * decCount;
      }
      else if(decCount % 3 == 0) 
      {
        cost = decCount * 1.666;
      }
       else if(decCount % 3 == 1) 
      {
        cost = decCount * 1.75;
      } 
      else if(decCount % 3 == 2) 
      {
        cost = decCount * 1.8;
      } 
      else 
      {
        return 0;
      }
      return Convert.ToInt32(cost);
    }
  }
}