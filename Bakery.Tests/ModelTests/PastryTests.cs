using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests 
{
  [TestClass]
  public class PastryTests
  {
   [TestMethod]
   public void PastryConstructor_CreatesInstanceOfPastry_Bread()
   {
     Pastry newPastry = new Pastry(3);
     Assert.AreEqual(typeof(Pastry), newPastry.GetType());
   }
   [TestMethod]
   public void GetCost_ReturnsCost_Int()
   {
     int cost = 0;
     Pastry newPastry = new Pastry(1);
     Assert.AreEqual(cost, newPastry.Cost);
   }
  }
}