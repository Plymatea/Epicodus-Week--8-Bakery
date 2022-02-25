using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("--------------");
      Console.WriteLine("Good Morning!! Guten Tag!! ");
      Console.WriteLine("Welcome to my bakery. I hope the smell of fresh bread and pastries brought you in this morning!");
      Console.WriteLine("--------------");

      Start();
      static void Start()
      {
        Console.WriteLine("How can I help you today? (Buy/View Cart/End)");
        string response = Console.ReadLine().ToUpper();
        if (response == "BUY")
        {
          Buy();
        }
        else if (response == "VIEW CART")
        {
          Cart();
        }
        else if (response == "END")
        {
          End();
        }
        else
        {
          Console.WriteLine("Sorry, my english isn't perfect. Can you repeat that?");
          Start();
        }
        static void Cart()
        {
          
        }
        Buy();
        static void Buy()
        {
          Console.WriteLine("--------------");
          Console.WriteLine("We are selling bread and pastries this morning.");
          Console.WriteLine($"The bread is ${Bread.GetPrice()} each or {Bread.GetSaleSet()} loaves for ${Bread.GetSalePricePerSet()}.");
          Console.WriteLine($"The pastries are ${Pastry.GetPrice()} each or {Pastry.GetSaleSet()} for ${Pastry.GetSalePricePerSet()}.");
          Console.WriteLine("--------------");
          Console.WriteLine("Would you like some?  (Bread/Pastry)");
          string response = Console.ReadLine().ToUpper();
          if (response == "BREAD") 
          {
            Console.WriteLine("--------------");
            Console.WriteLine("How many loaves of bread would you like?");
            response = Console.ReadLine().ToUpper();
            Console.WriteLine("--------------");
            Console.WriteLine($"{response} loaves of bread have been added to your order. ");
            for (int i=0; i<Int32.Parse(response); i++)
            {
              Bread Bread = new Bread();
            }
            if (Int32.Parse(response) <Bread.GetSaleSet())
            {
            Console.WriteLine($"Bread: ({response}) @ ${Bread.GetPrice()} each >> ${Bread.GetTotalBreadListPrice()}");
            Console.WriteLine("--------------");
            Start();
            }
            else
            {
            
            }
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
            Buy();
          }
        }
      }
      static void End() 
      {
        Environment.Exit(0);
      }
    }
  }
}