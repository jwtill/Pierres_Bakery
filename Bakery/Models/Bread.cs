using System;
namespace Bakery.Models
{
  public class Bread //Class def
  {
    public int Cost { get; } //fields
    public int Count { get; set; }

    
    
    public Bread(int count)//constructor
    {
      Cost = 0;
      Count = count;
    }

     //Calculate cost method
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
        return Convert.ToInt32(cost);
      }
      return Convert.ToInt32(cost);

    }
   
  }
}