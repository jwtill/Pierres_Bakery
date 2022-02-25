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
     int cost = 0;
     Bread newBread = new Bread(1);
     Assert.AreEqual(cost, newBread.Cost);
   }
   [TestMethod]
   public void SetCount_SetCount_Int()
   {
     int count = 9;
     Bread newBread = new Bread(count);
     int newCount = 7;
     newBread.Count = newCount;
     Assert.AreEqual(newCount, newBread.Count);
   }
   [TestMethod]
   public void GetCount_GetCount_Int()
   {
     int count = 9;
     Bread newBread = new Bread(count);
     int result = newBread.Count;
     Assert.AreEqual(count, result);
   }
   [TestMethod]
   public void CalculateCost_ReturnCost_Int()
   {
     Bread newBread = new Bread(3);
     int result = newBread.calculateCost();
     Assert.AreEqual(0, result);
   }
  }
}