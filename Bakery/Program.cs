using System;
using Bakery.Models;
namespace Bakery 
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre\'s Bakery! \nBread costs $5 each or 3 for $10!\nPastries cost $2 each or 3 for $5!");

      Console.WriteLine("How many loaves of bread would you like?");
      int breadCount = int.Parse(Console.ReadLine());
      Console.WriteLine("How many pastries would you like?");
      int pastryCount = int.Parse(Console.ReadLine());

      Bread newBreadOrder = new Bread(breadCount);
      Console.Write("Your " + breadCount + " bread loaves come to " + "$" + newBreadOrder.calculateCost() + ". ");

      Pastry newPastryOrder = new Pastry(pastryCount);
      Console.WriteLine("Your " + pastryCount + " pastries come to " + "$" + newPastryOrder.calculateCost() + ".");
      Console.WriteLine("Your total comes to " + "$"+( newBreadOrder.calculateCost()+ newPastryOrder.calculateCost()+"."));
    }
  }
}