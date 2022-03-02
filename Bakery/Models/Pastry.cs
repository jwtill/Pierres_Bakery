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
      int cost = 0;
      for(int i = 1; i <= Count; i++) {
        if (i % 3 == 0) 
        {
          cost += 1;
        } else 
        {
          cost += 2;
        }
        
      }
      return cost;
    }
  }
}