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
      Bread.ClearBreadOrder();
    }

    [TestMethod]
    public void GetOrder_ReturnsEmptyList_OrderList()
    {
      List<Order> newOrder = new List<Order> {};
      List<Order> result = Order.GetOrder();
      CollectionAssert.AreEqual(newOrder, result);
    }

    [TestMethod]
    public void BreadConstructor_CreatesBreadItem_Item()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    // [TestMethod]
    // public void BreadConstructor_AddToOrderList_3()
    // {
    //   Bread newBread = new Bread();
    //   Assert.AreEqual(typeof(int), newBread.Price.GetType());
    // }

    [TestMethod]
    public void BreadGetPrice_ReturnBreadPrice_3()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(int), newBread.Price.GetType());
    }


  }
}