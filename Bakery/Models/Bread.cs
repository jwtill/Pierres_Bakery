using System;
namespace Bakery.Models
{
  public class Bread 
  {
    public int Cost { get; } 
    public int Count { get; set; }
    public string Kind { get; set;}

        public Bread(int count, string kind)
    {
      Cost = 0;
      Count = count;
      Kind = kind;
    }

    public int calculateCost() 
    { 
      int cost = 0;
      for(int i = 1; i <= Count; i++) {
        if (i % 3 == 0) 
        {
          cost += 0;
        } else 
        {
          cost ++;
        }
        
      }
      return cost * 5;
      
      
    }
  }
}



