using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Order
  {
    private static List<Order> _order = new List<Order> {};
    public static List<Order> GetOrder()
    {
      return _order;
    }
  }
  public class Bread
  {
    public Bread()
    {
      
    }
  }
  public class Pastry
  {

  }
  
}