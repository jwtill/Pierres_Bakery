using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests 
{
  [TestClass]
  public class BreadTests
  {
   [TestMethod]
   public void BreadConstructor_CreatesInstanceOfBread_Bread()
   {
     Bread newBread = new Bread();
     Assert.AreEqual(typeof(Bread), newBread.GetType());
   }
   [TestMethod]
   public void GetCost_ReturnsCost_Int()
   {
     int cost = 3;
     Bread newBread = new Bread(cost);
     Assert.AreEqual(cost, newBread.Cost);
   }
  }
}