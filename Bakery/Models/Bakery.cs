using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public string Description { get; set; }
    public int Price { get; set; }
    private static int _price = 5; 
    private static List<Bread> _breadOrder = new List<Bread> {};
    public static List<Bread> GetBreadList()
    {
      return _breadOrder;
    }
    public static void AddBread (Bread item)
    {
      _breadOrder.Add(item);
    }
    public static void ClearBreadOrder()
    {
      _breadOrder.Clear();
    }
    public Bread()
    {
      Description = "Bread";
      Price = _price;
      _breadOrder.Add(this);
    }
    public static int GetTotalBreadListPrice()
    {
      int numOfBread = Bread.GetBreadList().Count;
      int totalBreadPrice = numOfBread * Bread._price;
      
      if (numOfBread < 3) {
        return totalBreadPrice;
      }
      else 
      {
        int saleSet = numOfBread / 3;
        int salePrice = 10;
        int rem = (numOfBread % 3);
        int totalSalePrice = saleSet * salePrice + rem * Bread._price;
        return totalSalePrice;
      }
    }
  }
  public class Pastry
  {
    public string Description { get; set; }
    public int Price { get; set; }
    private static int _price = 2; 
    private static List<Pastry> _pastryOrder = new List<Pastry> {};
    public static List<Pastry> GetPastryList()
    {
      return _pastryOrder;
    }
    public static void AddPastry (Pastry item)
    {
      _pastryOrder.Add(item);
    }
    public static void ClearPastryOrder()
    {
      _pastryOrder.Clear();
    }
    public Pastry()
    {
      Description = "Pastry";
      Price = _price;
      _pastryOrder.Add(this);
    }
    public static int GetTotalPastryListPrice()
    {
      int numOfPastry = Pastry.GetPastryList().Count;
      int totalPastryPrice = numOfPastry * Pastry._price;
      
      if (numOfPastry < 3) {
        return totalPastryPrice;
      }
      else 
      {
        int saleSet = numOfPastry / 3;
        int salePrice = 5;
        int rem = (numOfPastry % 3);
        int totalSalePrice = saleSet * salePrice + rem * Pastry._price;
        return totalSalePrice;
      }
    }
  }
}