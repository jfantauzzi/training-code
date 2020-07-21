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

      /*
      // array
      //1-d
      string[] cart1 = { "", "", "" }; //initial values
      string[] cart2 = new string[3]; //default values
      string[] cart3 = new[] { "", "", "" }; //initial values - custom datatypes or earlier C# versions

      // list
      // List<string> cart4 = new List{"","",""}; // initial values
      List<string> cart5 = new List<string>(); // default values
      List<Pizza> cart6 = new List<Pizza>();
      */
      //Menu2(cart6);

      var startup = new PizzaStore.Client.Starter();
      var user = new User();
      var store = new Store();

      /* if (order != null)
       {
         Menu3(order);
       }
       else
       {
         System.Console.WriteLine("Technical difficulties, we be back donchu worry.");
       } */

      try
      {
        Menu3(startup.CreateOrder(user, store));
      }
      catch (Exception ex)
      {
        System.Console.WriteLine(ex.Message);
      }
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

    /*   static void DisplayCart2(List<Pizza> cart)
      {
        System.Console.WriteLine("Your Order:");
        foreach (var pizza in cart)
        {
          System.Console.WriteLine(pizza);
        }
      } */
    static void Menu3(Order cart)
    {

      var exit = false;

      do
      {
        Starter.PrintMenu();

        int select;
        int.TryParse(Console.ReadLine(), out select);

        switch (select)
        {
          case 1:
            cart.CreatePizza("L", "Stuffed", new List<string> { "cheese" });
            Console.WriteLine("added Cheese Pizza");
            break;
          case 2:
            cart.CreatePizza("L", "Stuffed", new List<string> { "pepperoni" });
            Console.WriteLine("added Pepperoni Pizza");
            break;
          case 3:
            cart.CreatePizza("L", "Stuffed", new List<string> { "Hawaiian" });
            Console.WriteLine("added Hawaiian Pizza");
            break;
          case 4:
            cart.CreatePizza("L", "Stuffed", new List<string> { "custom" });
            Console.WriteLine("added Custom Pizza");
            break;
          case 5:
            DisplayCart3(cart);
            break;
          case 6:
            var fmw = new FileManager();
            fmw.Write(cart);
            Console.WriteLine("Thank you!");
            exit = true;
            break;
          case 7:
            var fmr = new FileManager();
            DisplayCart3(fmr.Read());
            break;
        }

        Console.WriteLine();
      } while (!exit);

    }

    static void DisplayCart3(Order cart)
    {
      //Console.WriteLine("Your Order:");
      foreach (var pizza in cart.Pizzas)
      {
        Console.WriteLine(pizza);
      }
    }



  }
}
