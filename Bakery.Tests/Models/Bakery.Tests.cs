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
      Pastry.ClearPastryOrder();
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
    public void BreadTotalBreadListPrice_ReturnTotalBreadListPrice_int()
    {
      Bread newBread = new Bread();
      Bread newBread1 = new Bread();
      int testPrice = Bread.GetPrice() *2; 
      int result = Bread.GetTotalBreadListPrice();

      Assert.AreEqual(testPrice, result);
    }

        [TestMethod]
    public void BreadTotalBreadListPrice_ReturnTotalBreadListPriceOnSale_int()
    {
      Bread newBread = new Bread();
      Bread newBread1 = new Bread();
      Bread newBread3 = new Bread();
      int testPrice = Bread.GetPrice() *2 + 0;
      int result = Bread.GetTotalBreadListPrice();

      Assert.AreEqual(testPrice, result);
    }
    [TestMethod]
    public void GetPastryList_ReturnsEmptyList_PastryList()
    {
      List<Pastry> testPastryList = new List<Pastry> {};
      List<Pastry> result = Pastry.GetPastryList();
      CollectionAssert.AreEqual(testPastryList, result);
    }

    [TestMethod]
    public void PastryConstructor_CreatesPastryItem_Item()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void PastryConstructor_AddToPastryOrder_()
    {
      Pastry newPastry = new Pastry();
      List<Pastry> testPastryList = new List<Pastry> {};
      testPastryList.Add(newPastry);

      CollectionAssert.AreEqual(testPastryList,  Pastry.GetPastryList());
    }

    [TestMethod]
    public void PastryTotalPastryListPrice_ReturnTotalPastryListPrice_int()
    {
      Pastry newPastry = new Pastry();
      Pastry newPastry1 = new Pastry();
      int testPrice = Pastry.GetPrice() * 2;
      int result = Pastry.GetTotalPastryListPrice();

      Assert.AreEqual(testPrice, result);
    }

        [TestMethod]
    public void PastryTotalPastryListPrice_ReturnTotalPastryListPriceOnSale_int()
    {
      for (int i=0;i<Pastry.GetSaleSet();i++)
      {
        Pastry newPastry = new Pastry();
      }
      int testPrice = Pastry.GetSalePricePerSet();
      int result = Pastry.GetTotalPastryListPrice();

      Assert.AreEqual(testPrice, result);
    }
    

  }
}