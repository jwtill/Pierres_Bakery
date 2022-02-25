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
     Pastry newPastry = new Pastry();
     Assert.AreEqual(typeof(Pastry), newPastry.GetType());
   }
  }
}