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
        Console.WriteLine("Would you like to buy some bread or pastries?  (Bread/Pastry/End)");
        string response = Console.ReadLine().ToUpper();
        if (response == "BREAD") 
        {

        }
        else if (response == "PASTRY")
        {

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
        Console.WriteLine("");
      }
      static void End() {};
    }
  }
}