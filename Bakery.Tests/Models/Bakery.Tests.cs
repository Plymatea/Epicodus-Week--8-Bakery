using Microsoft.VisualStudio.TestTools.UnitTesting;
using System; 
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.TestTools
{
  [TestClass]
  public class BakeryTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearOrder();
    }

    [TestMethod]
    public void BreadConstructor_CreatesBreadItem_Item()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void BreadGetPrice_ReturnBreadPrice_3()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(int), newBread.Price.GetType());
    }
  }
}