using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Hello World");
      Item.Bread newBread = new Item.Bread();
      Console.WriteLine(newBread.Price);
    }
  }
}