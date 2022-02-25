using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Good Morning!! Guten Tag!! ");
      Console.WriteLine("Welcome to the bakery. I hope the smell of fresh bread and pastries brought you in this morning!");
      Start();
      static void Start()
      {
        Console.WriteLine("--------------");
        Console.WriteLine("We are selling bread and pastries this morning.");
        Console.WriteLine($"The bread is ${Bread.GetBreadPrice()} each or 3 loaves for $10");
        Console.WriteLine("The pastries are $2 each or 3 for $5");
        Console.WriteLine("Would you like to buy some?  (Bread/Pastry/End)");
        string response = Console.ReadLine().ToUpper();
        if (response == "BREAD") 
        {
          Console.WriteLine("How many loaves of bread would you like?");
          response = Console.ReadLine().ToUpper();
          Console.WriteLine($"{response} loaves of bread have been added to your order. ");
          Start();
        }
        else if (response == "PASTRY")
        {

        }
        else if (response == "END")
        {
          Console.WriteLine("Have a good day! Come back again!");
          End();
        }
        else
        {
          Console.WriteLine("Sorry, my english isn't perfect. Can you repeat that?");
          Start();
        }
      }
      static void End() {};
    }
  }
}