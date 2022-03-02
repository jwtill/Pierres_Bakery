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
     Bread newBread = new Bread(4, "white");
     Assert.AreEqual(typeof(Bread), newBread.GetType());
   }
   [TestMethod]
   public void GetCost_ReturnsCost_Int()
   {
     int cost = 0;
     Bread newBread = new Bread(1, "white");
     Assert.AreEqual(cost, newBread.Cost);
   }
   [TestMethod]
   public void SetCount_SetCount_Int()
   {
     int count = 9;
     Bread newBread = new Bread(count, "white");
     int newCount = 7;
     newBread.Count = newCount;
     Assert.AreEqual(newCount, newBread.Count);
   }
   [TestMethod]
   public void GetCount_GetCount_Int()
   {
     int count = 9;
     Bread newBread = new Bread(count, "white");
     int result = newBread.Count;
     Assert.AreEqual(count, result);
   }
   [TestMethod]
   public void CalculateCost_ReturnCost_Int()
   {
     Bread newBread = new Bread(0, "white");
     int result = newBread.calculateCost();
     Assert.AreEqual(newBread.Cost, result);
   }
  //  [TestMethod]
  //  public void CalculateCost_Count2Less_Int()
  //  {
  //    Bread newBread = new Bread(2, "white");
  //    int result = newBread.calculateCost();
  //    Assert.AreEqual(10, result);
  //  }
  //  [TestMethod]
  //  public void CalculateCost_Mult3_Int()
  //  {
  //    Bread newBread = new Bread(3, "white");
  //    int result = newBread.calculateCost();
  //    Assert.AreEqual(10, result);
  //  }
  //  [TestMethod]
  //  public void CalculateCost_Mult3PlusOne_Int()
  //  {
  //    Bread newBread = new Bread(4, "white");
  //    int result = newBread.calculateCost();
  //    Assert.AreEqual(15, result);
  //  }
  //  [TestMethod]
  //  public void CalculateCost_Mult3PlusTwo_Int()
  //  {
  //    Bread newBread = new Bread(5, "white");
  //    int result = newBread.calculateCost();
  //    Assert.AreEqual(20, result);
  //  }
  // [TestMethod]
  //  public void SetKind_SetKind_String()
  //  {
  //    string kind = "Challah";
  //    Bread newBread = new Bread(1, kind);
  //    string newKind = "Rye";
  //    newBread.Kind = newKind;
  //    Assert.AreEqual(newKind, newBread.Kind);
  //  }
  
   [TestMethod]
   public void CalculateCost_CalculateCost_Int()
   {
     Bread newBread = new Bread(2, "white");
     int result = newBread.calculateCost();
     Assert.AreEqual(10, result);
   }
   [TestMethod]
   public void CalculateCost_CalculateCost3_Int()
   {
     Bread newBread = new Bread(3, "white");
     int result = newBread.calculateCost();
     Assert.AreEqual(10, result);
   }

   
  }
}