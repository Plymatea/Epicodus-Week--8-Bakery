using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  // public class Order
  // {
  //   private static List<Order> _order = new List<Order> {};
  //   public static List<Order> GetOrder()
  //   {
  //     return _order;
  //   }
  //   public static Bread AddItem (Bread item)
  //   {
  //     _order.Add(item);
  //   }
  //   public static void ClearOrder()
  //   {
  //     _order.Clear();
  //   }
  // }
  public class Items
  {
  public class Bread
  {
    public int Price { get; set; }
    private static int _price = 3; 
    public Bread()
    {
      Price = _price;
      // Order.AddItem(this);
    }

  }
  public class Pastry
  {

  }
  }

  
}