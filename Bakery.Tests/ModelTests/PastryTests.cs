using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
namespace Bakery.Tests 
{
  [TestClass]
  public class PastryTests
  {
   [TestMethod]
   public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
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
   [TestMethod]
   public void SetCount_SetCount_Int()
   {
     int count = 9;
     Pastry newPastry = new Pastry(count);
     int newCount = 7;
     newPastry.Count = newCount;
     Assert.AreEqual(newCount, newPastry.Count);
   }
   [TestMethod]
   public void GetCount_GetCount_Int()
   {
     int count = 9;
     Pastry newPastry = new Pastry(count);
     int result = newPastry.Count;
     Assert.AreEqual(count, result);
   }
  
   [TestMethod]
   public void CalculateCost_CalculateCost_Int()
   {
     Pastry newPastry = new Pastry(2);
     int result = newPastry.calculateCost();
     Assert.AreEqual(4, result);
   }
   [TestMethod]
   public void CalculateCost_CalculateCost3_Int()
   {
     Pastry newPastry = new Pastry(3);
     int result = newPastry.calculateCost();
     Assert.AreEqual(5, result);
   }
  }
}