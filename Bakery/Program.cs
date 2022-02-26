using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    { //Welcome Banner
      Console.WriteLine("--------------");
      Console.WriteLine("Good Morning!! Guten Tag!! ");
      Console.WriteLine("Welcome to my bakery. I hope the smell of fresh bread and pastries brought you in this morning!");
      Console.WriteLine("--------------");

      Start();
      static void Start()
      {
        Console.WriteLine("How can I help you? (Buy/Cart/End)");
        string response = Console.ReadLine().ToUpper();
        if (response == "BUY")
        {
          BuyMain();
        }
        else if (response == "CART")
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

          int numBread = Bread.GetBreadList().Count;
          int numPastry = Pastry.GetPastryList().Count;
//Bread Cart Construction
          if (numBread ==0 && numPastry ==0)
          {
            Console.WriteLine("You have nothing in your cart yet. But I'll still glady accept your money.");
          }
          else 
          {
            Console.WriteLine("Your Cart includes the following:");
            if (numBread == 0) {}
            else if (numBread <Bread.GetSaleSet())  //Bread less than the SaleSet Qty
            {
              Console.WriteLine("Bread:");
              Console.WriteLine($"   Each: ({numBread}) @ ${Bread.GetPrice()} >> ${Bread.GetTotalBreadListPrice()}");
            }
            else if (numBread % Bread.GetSaleSet() == 0)  // Bread == multiple of SaleSet Qty
            {
              int saleSets = numBread / Bread.GetSaleSet();
              int rem = numBread % Bread.GetSaleSet();
              Console.WriteLine("Bread:");
              Console.WriteLine($"  Sale Qty:({saleSets}) @ ${Bread.GetSalePricePerSet()} >> ${Bread.GetSalePricePerSet() * saleSets}");
            }
            else if (numBread % Bread.GetSaleSet() != 0) //Bread > SaleSet multiple
            {
              int saleSets = numBread / Bread.GetSaleSet();
              int rem = numBread % Bread.GetSaleSet();
              Console.WriteLine("Bread:");
              Console.WriteLine($"  Sale Qty:({saleSets}) @ ${Bread.GetSalePricePerSet()} >> ${Bread.GetSalePricePerSet() * saleSets}");
              Console.WriteLine($"  Each:({rem}) @ ${Bread.GetPrice()} >> ${(rem) * Bread.GetPrice()}");
            }
            Console.WriteLine($"Subtotal Bread: ${Bread.GetTotalBreadListPrice()}");
  //Pastry Cart Construction
            if (numPastry ==0) {}
            else if (numPastry <Pastry.GetSaleSet())  //Pastry less than the SaleSet Qty
            {
              if (numPastry == 1)
              {
                Console.WriteLine($"({numPastry}) Pastry:");
              }
              else
              {
                Console.WriteLine($"({numPastry}) Pastries:");
              }
              Console.WriteLine($"   Each: ({numPastry}) @ ${Pastry.GetPrice()} >> ${Pastry.GetTotalPastryListPrice()}");
            }
            else if (numPastry % Pastry.GetSaleSet() == 0)  // Pastry == multiple of SaleSet Qty
            {
              Console.WriteLine($"({numPastry}) Pastries:");
              int saleSets = numPastry / Pastry.GetSaleSet();
              int rem = numPastry % Pastry.GetSaleSet();
              Console.WriteLine($"  Sale Qty:({saleSets}) @ ${Pastry.GetSalePricePerSet()} >> ${Pastry.GetSalePricePerSet() * saleSets}");
            }
            else if (numPastry % Pastry.GetSaleSet() != 0)    // Pastry > multiple of SaleSet Qty
            {
              Console.WriteLine($"({numPastry}) Pastries:");
              int saleSets = numPastry / Pastry.GetSaleSet();
              int rem = numPastry % Pastry.GetSaleSet();
              Console.WriteLine($"  Sale Qty:({saleSets}) @ ${Pastry.GetSalePricePerSet()} >> ${Pastry.GetSalePricePerSet() * saleSets}");
              Console.WriteLine($"  Each:({rem}) @ ${Pastry.GetPrice()} >> ${(rem) * Pastry.GetPrice()}");
            }
              Console.WriteLine($"Subtotal Pastries: ${Pastry.GetTotalPastryListPrice()}");
              int total = Pastry.GetTotalPastryListPrice() + Bread.GetTotalBreadListPrice();
              Console.WriteLine($"Total Cost: ${total}");
          }
          Start();
        }
        static void BuyMain()
        {
          static void BuyStart()  // "Main Menu"
          {
            Console.WriteLine("--------------");
            Console.WriteLine("What else can I do for you? (Buy/Cart/End)");
            string response = Console.ReadLine().ToUpper();
            if (response == "BUY")
            {
              Buy();
            }
            else if (response == "CART")
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
              BuyStart();
            }
          }
// Buy Welcome Banner
          Console.WriteLine("--------------");
          Console.WriteLine("We are selling bread and pastries this morning.");
          Console.WriteLine($"The bread is ${Bread.GetPrice()} each or {Bread.GetSaleSet()} for ${Bread.GetSalePricePerSet()}.");
          Console.WriteLine($"The pastries are ${Pastry.GetPrice()} each or {Pastry.GetSaleSet()} for ${Pastry.GetSalePricePerSet()}.");
          Console.WriteLine("--------------");

          Buy();
          static void Buy()
          {          
            Console.WriteLine("Which would you like?  (Bread/Pastry/View Cart)");
            string response = Console.ReadLine().ToUpper();
            if (response == "BREAD") 
            {
              Console.WriteLine("--------------");
              Console.WriteLine("How many loaves of bread would you like? (example:5)");

              response = Console.ReadLine().ToUpper();
              for (int i=0; i<Int32.Parse(response); i++)
              {
                Bread Bread = new Bread();
              }
              int numBread = Bread.GetBreadList().Count;
              int saleSets = numBread / Bread.GetSaleSet();
              int rem = numBread % Bread.GetSaleSet();
              string saleSetMessage = $"  Sale Qty:({saleSets}) @ ${Bread.GetSalePricePerSet()} >> ${Bread.GetSalePricePerSet() * saleSets}";

              Console.WriteLine("--------------");
              Console.WriteLine($"({response}) loaves of bread have been added to your order. The following bread is on your order:");
              Console.WriteLine($"({numBread}) Bread:");

              if (numBread < Bread.GetSaleSet())
              {
                Console.WriteLine($"   Each: ({numBread}) @ ${Bread.GetPrice()} >> ${Bread.GetTotalBreadListPrice()}");
              }
              else if (rem == 0)
              {
                Console.WriteLine(saleSetMessage);
              }
              else if (rem != 0)
              {
                Console.WriteLine(saleSetMessage);
                Console.WriteLine($"  Each:({rem}) @ ${Bread.GetPrice()} >> ${(rem) * Bread.GetPrice()}");
                Console.WriteLine($"Total Bread Price: ${Bread.GetTotalBreadListPrice()}");

              }
              else
              {
                Console.WriteLine("Sorry, my english isn't perfect. Can you repeat that?");
                
              }
              BuyStart();          
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
                BuyStart();
              }
            }
            else if (response == "CART")
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
              BuyStart();
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