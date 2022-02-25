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
    public void GetBreadList_ReturnsEmptyList_BreadList()
    {
      List<Bread> testBreadList = new List<Bread> {};
      List<Bread> result = Bread.GetBreadList();
      CollectionAssert.AreEqual(testBreadList, result);
    }

    [TestMethod]
    public void BreadConstructor_CreatesBreadItem_Item()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void BreadConstructor_AddToBreadOrder_()
    {
      Bread newBread = new Bread();
      List<Bread> testBreadList = new List<Bread> {};
      testBreadList.Add(newBread);

      CollectionAssert.AreEqual(testBreadList,  Bread.GetBreadList());
    }

    [TestMethod]
    public void BreadGetPrice_ReturnBreadPrice_int()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(int), newBread.Price.GetType());
    }


  }
}