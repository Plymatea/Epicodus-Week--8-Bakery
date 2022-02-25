using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  // public class Order
  // {
  //   private static List<Item> _order = new List<Item> {};
  //   public static List<Item> GetOrder()
  //   {
  //     return _order;
  //   }
  //   public static void AddItem (Item item)
  //   {
  //     _order.Add(item);
  //   }
  //   public static void ClearOrder()
  //   {
  //     _order.Clear();
  //   }
  // }
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
      // _breadOrder.Add(this);
    }

  }
  public class Pastry
  {

  }
}