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
        if (Count % 3 == 0) 
        {
          cost += 0;
        } else 
        {
          cost ++;
        }
        
      }
      return cost * 5;
      
      // double cost = 0;
      // double decCount = Convert.ToDouble(Count);
      // if(decCount <= 2) 
      // {
      //   cost += 5 * decCount;
      // } else if(decCount % 3 == 0) 
      // {
      //   cost = decCount * 3.33;
      // } else if(decCount % 3 == 1) 
      // {
      //   cost = decCount * 3.75;
      // } else if(decCount % 3 == 2) 
      // {
      //   cost = decCount * 4;
      // } 
      // else 
      // {
      //   return 0;
      // }
      // return Convert.ToInt32(cost);
    }
  }
}



