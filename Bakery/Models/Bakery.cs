using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    private static int _price = 5; 
    private static int _saleSet = 3;
    private static int _salePricePerSet = 10;
    private static List<Bread> _breadOrder = new List<Bread> {};

    public static int GetPrice()
    {
      return _price;
    }
    public static int GetSaleSet()
    {
      return _saleSet;
    }
    public static int GetSalePricePerSet()
    {
      return _salePricePerSet;
    }
    public static List<Bread> GetBreadList()
    {
      return _breadOrder;
    }
    public static void ClearBreadOrder()
    {
      _breadOrder.Clear();
    }
    public Bread()
    {
      _breadOrder.Add(this);
    }
    public static int GetTotalBreadListPrice()
    {
      int numOfBread = Bread.GetBreadList().Count;
      int totalBreadPrice = numOfBread * Bread._price;
      
      if (numOfBread < Bread._saleSet) {
        return totalBreadPrice;
      }
      else 
      {
        int numsaleSet = numOfBread / Bread._saleSet;
        int rem = (numOfBread % Bread._saleSet);
        int totalSalePrice = numsaleSet * Bread._salePricePerSet + rem * Bread._price;
        return totalSalePrice;
      }
    }
  }
  public class Pastry
  {
    private static int _price = 2; 
    private static int _saleSet = 3;
    private static int _salePricePerSet = 5;
    private static List<Pastry> _pastryOrder = new List<Pastry> {};
    public static List<Pastry> GetPastryList()
    {
      return _pastryOrder;
    }
    public static int GetPrice()
    {
      return _price;
    }
    public static int GetSaleSet()
    {
      return _saleSet;
    }
        public static int GetSalePricePerSet()
    {
      return _salePricePerSet;
    }
    public static void ClearPastryOrder()
    {
      _pastryOrder.Clear();
    }
    public Pastry()
    {
      _pastryOrder.Add(this);
    }
    public static int GetTotalPastryListPrice()
    {
      int numOfPastry = Pastry.GetPastryList().Count;
      int totalPastryPrice = numOfPastry * Pastry._price;
      
      if (numOfPastry < Pastry._saleSet) {
        return totalPastryPrice;
      }
      else 
      {
        int numSaleSet = numOfPastry / Pastry._saleSet;
        int rem = (numOfPastry % Pastry._saleSet);
        int totalSalePrice = numSaleSet * Pastry._salePricePerSet + rem * Pastry._price;
        return totalSalePrice;
      }
    }
  }
}