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
      int totalBreadPrice = 1;
      for (int i=0; i<Bread.GetBreadList().Count; i++)
      {
        totalBreadPrice += Bread.GetBreadList()[i].Price;
      }
      return totalBreadPrice;
    }
  }
  public class Pastry
  {

  }
}