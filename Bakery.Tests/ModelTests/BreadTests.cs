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
     Bread newBread = new Bread(4);
     Assert.AreEqual(typeof(Bread), newBread.GetType());
   }
   [TestMethod]
   public void GetCost_ReturnsCost_Int()
   {
     int cost = 3;
     Bread newBread = new Bread(cost);
     Assert.AreEqual(cost, newBread.Cost);
   }
   public void SetCount_SetCount_Int()
   {
     int count = 9;
     Bread newBread = new Bread(count);
     Assert.AreEqual(count, newBread.count);
   }
  }
}