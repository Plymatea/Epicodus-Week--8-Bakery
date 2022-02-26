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
      Console.WriteLine("How can I help you today? (Buy/View Cart/End)");
      Start();
      static void Start()
      {

        string response = Console.ReadLine().ToUpper();
        if (response == "BUY")
        {
          BuyMain();
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
          Console.WriteLine("--------------");
          Console.WriteLine("Your Cart includes the following:");
          int numBread = Bread.GetBreadList().Count;
          Console.WriteLine(numBread);
        }
        static void BuyMain()
        {
          static void BuyStart()
          {
            Console.WriteLine("--------------");
            Console.WriteLine("What else can I do for you? (Buy/View Cart/End)");
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
          }

          Console.WriteLine("--------------");
          Console.WriteLine("We are selling bread and pastries this morning.");
          Console.WriteLine($"The bread is ${Bread.GetPrice()} each or {Bread.GetSaleSet()} for ${Bread.GetSalePricePerSet()}.");
          Console.WriteLine($"The pastries are ${Pastry.GetPrice()} each or {Pastry.GetSaleSet()} for ${Pastry.GetSalePricePerSet()}.");
          Console.WriteLine("--------------");
          Console.WriteLine("Which would you like?  (Bread/Pastry/View Cart)");
          Buy();
          static void Buy()
          {
            string response = Console.ReadLine().ToUpper();
            if (response == "BREAD") 
            {
              Console.WriteLine("--------------");
              Console.WriteLine("How many loaves of bread would you like? (example:5)");
              response = Console.ReadLine().ToUpper();
              Console.WriteLine("--------------");
              Console.WriteLine($"{response} loaves of bread have been added to your order. ");
              for (int i=0; i<Int32.Parse(response); i++)
              {
                Bread Bread = new Bread();
              }
              if (Int32.Parse(response) <Bread.GetSaleSet())
              {
                Console.WriteLine("Bread:");
                Console.WriteLine($"   Each: ({response}) @ ${Bread.GetPrice()} >> ${Bread.GetTotalBreadListPrice()}");
                BuyStart();
              }
              else if (Int32.Parse(response) % Bread.GetSaleSet() == 0)
              {
                Console.WriteLine("Bread:");
                int num  = Int32.Parse(response);
                int saleSets = num / Bread.GetSaleSet();
                int rem = num % Bread.GetSaleSet();
                Console.WriteLine($"  Sale Qty:({saleSets}) @ ${Bread.GetSalePricePerSet()} >> ${Bread.GetSalePricePerSet() * saleSets}");
                BuyStart();
              }
              else if (Int32.Parse(response) % Bread.GetSaleSet() != 0)
              {
                Console.WriteLine("Bread:");
                int num  = Int32.Parse(response);
                int saleSets = num / Bread.GetSaleSet();
                int rem = num % Bread.GetSaleSet();
                Console.WriteLine($"  Sale Qty:({saleSets}) @ ${Bread.GetSalePricePerSet()} >> ${Bread.GetSalePricePerSet() * saleSets}");
                Console.WriteLine($"  Each:({rem}) @ ${Bread.GetPrice()} >> ${(rem) * Bread.GetPrice()}");
                Console.WriteLine($"Total Bread Price: ${Bread.GetTotalBreadListPrice()}");
                BuyStart();
              }
              else
              {
                Console.WriteLine("Sorry, my english isn't perfect. Can you repeat that?");
                Buy();
              }
            }
            else if (response == "PASTRY")
            {
              Console.WriteLine("--------------");
              Console.WriteLine("How many pastries would you like? (example:8)");
              response = Console.ReadLine().ToUpper();
              Console.WriteLine("--------------");
              Console.WriteLine($"{response} pastries have been added to your order. ");
              for (int i=0; i<Int32.Parse(response); i++)
              {
                Pastry Bread = new Pastry();
              }
              if (Int32.Parse(response) <Pastry.GetSaleSet())
              {
                Console.WriteLine("Pastry:");
                Console.WriteLine($"   Each: ({response}) @ ${Pastry.GetPrice()} >> ${Pastry.GetTotalPastryListPrice()}");
                BuyStart();
              }
              else if (Int32.Parse(response) % Pastry.GetSaleSet() == 0)
              {
                Console.WriteLine("Pastry:");
                int num  = Int32.Parse(response);
                int saleSets = num / Pastry.GetSaleSet();
                int rem = num % Pastry.GetSaleSet();
                Console.WriteLine($"  Sale Qty:({saleSets}) @ ${Pastry.GetSalePricePerSet()} >> ${Pastry.GetSalePricePerSet() * saleSets}");
                BuyStart();
              }
              else if (Int32.Parse(response) % Pastry.GetSaleSet() != 0)
              {
                Console.WriteLine("Pastry:");
                int num  = Int32.Parse(response);
                int saleSets = num / Pastry.GetSaleSet();
                int rem = num % Pastry.GetSaleSet();
                Console.WriteLine($"  Sale Qty:({saleSets}) @ ${Pastry.GetSalePricePerSet()} >> ${Pastry.GetSalePricePerSet() * saleSets}");
                Console.WriteLine($"  Each:({rem}) @ ${Pastry.GetPrice()} >> ${(rem) * Pastry.GetPrice()}");
                Console.WriteLine($"Total Pastries Price: ${Pastry.GetTotalPastryListPrice()}");
                BuyStart();
              }
              else
              {
                Console.WriteLine("Sorry, my english isn't perfect. Can you repeat that?");
                Buy();
              }
            }
            else if (response == "VIEW Cart")
            {
              Cart();
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
      }
      static void End() 
      {
        Environment.Exit(0);
      }
    }
  }
}