using System;
using System.Collections.Generic;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client
{
  class Program
  {
    static void Main()
    {
      Welcome();
    }


    static void Welcome()
    {
      Console.WriteLine("Welcome to PizzaTime");
      Console.WriteLine("It's Pizza time!");
      Console.WriteLine();

      // array
      //1-d
      string[] cart1 = { "", "", "" }; //initial values
      string[] cart2 = new string[3]; //default values
      string[] cart3 = new[] { "", "", "" }; //initial values - custom datatypes or earlier C# versions

      // list
      // List<string> cart4 = new List{"","",""}; // initial values
      List<string> cart5 = new List<string>(); // default values

      List<Pizza> cart6 = new List<Pizza>();
      Menu2(cart6);
    }

    /*
    static void Menu(string[] cart)
    {

      var exit = false;
      var number = 0;

      do
      {

        if (number < cart.Length)
        {
          Console.WriteLine("Select 1 for Cheese Pizza");
          Console.WriteLine("Select 2 for Pepperoni Pizza");
          Console.WriteLine("Select 3 for Hawaiian Pizza");
          Console.WriteLine("Select 4 for Custom Pizza");
          Console.WriteLine("Select 5 to see cart");
          Console.WriteLine("Select 6 for Exit");
          Console.WriteLine();


          int select;
          int.TryParse(Console.ReadLine(), out select);

          switch (select)
          {
            case 1:
              cart[number] = "cheese";
              number += 1;
              Console.WriteLine("added Cheese Pizza");
              break;
            case 2:
              cart[number] = "pepperoni";
              number += 1;
              Console.WriteLine("added Pepperoni Pizza");
              break;
            case 3:
              cart[number] = "Hawaiian";
              number += 1;
              Console.WriteLine("added Hawaiian Pizza");
              break;
            case 4:
              cart[number] = "custom";
              number += 1;
              Console.WriteLine("added Custom Pizza");
              break;
            case 5:
              DisplayCart(cart);
              break;
            case 6:
              Console.WriteLine("Thank you!");
              exit = true;
              break;
          }
        }
        else
        {
          DisplayCart(cart);
          exit = true;
        }

        Console.WriteLine();
      } while (!exit);
    }


    static void DisplayCart(string[] cart)
    {
      Console.WriteLine("Your Order:");
      foreach (var pizza in cart)
      {
        Console.WriteLine(pizza);
      }

    }

    */

    //     *****list****

    /* static void DisplayCart2(List<string> cart)
    {
      System.Console.WriteLine("Your Order:");
      foreach (var pizza in cart)
      {
        System.Console.WriteLine(pizza);
      }

    } */

    static void DisplayCart2(List<Pizza> cart)
    {
      System.Console.WriteLine("Your Order:");
      foreach (var pizza in cart)
      {
        System.Console.WriteLine(pizza);
      }
    }
    static void Menu2(List<Pizza> cart)
    {

      var exit = false;
      var startup = new PizzaStore.Client.Startup();

      do
      {
        if (cart.Count < 4)
        {
          Console.WriteLine("Select 1 for Cheese Pizza");
          Console.WriteLine("Select 2 for Pepperoni Pizza");
          Console.WriteLine("Select 3 for Hawaiian Pizza");
          Console.WriteLine("Select 4 for Custom Pizza");
          Console.WriteLine("Select 5 to see cart");
          Console.WriteLine("Select 6 for Exit");
          Console.WriteLine();


          int select;
          int.TryParse(Console.ReadLine(), out select);

          switch (select)
          {
            case 1:
              var p = startup.CreatePizza("L", "Stuffed", new List<string> { "cheese" });

              cart.Add(p);
              Console.WriteLine("added Cheese Pizza");
              break;
            case 2:
              cart.Add(startup.CreatePizza("L", "Stuffed", new List<string> { "pepperoni" }));
              Console.WriteLine("added Pepperoni Pizza");
              break;
            case 3:
              cart.Add(startup.CreatePizza("L", "Stuffed", new List<string> { "Hawaiian" }));
              Console.WriteLine("added Hawaiian Pizza");
              break;
            case 4:
              cart.Add(startup.CreatePizza("L", "Stuffed", new List<string> { "custom" }));
              Console.WriteLine("added Custom Pizza");
              break;
            case 5:
              DisplayCart2(cart);
              break;
            case 6:
              Console.WriteLine("Thank you!");
              exit = true;
              break;
          }

        }
        else
        {
          DisplayCart2(cart);
          exit = true;
        }

        Console.WriteLine();
      } while (!exit);

    }

  }
}
