using System;
using System.Collections.Generic;
using Bakery.Models;


namespace Bakery 
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre\'s Bakery! \nBread costs $5 each or 3 for $10!\nPastries cost $2 each or 3 for $5!");
      Console.WriteLine("How many loaves of bread would you like?");
      int breadCount = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("How many pastries would you like?");
      int pastryCount = Convert.ToInt32(Console.ReadLine());
    }
  }
}