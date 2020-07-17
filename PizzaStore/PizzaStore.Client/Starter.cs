using System.Collections.Generic;
using PizzaStore.Domain.Models;
using System;

namespace PizzaStore.Client
{
  public class Starter
  {
    public Order CreateOrder(User user, Store store)
    {
      try
      {
        var order = new Order();


        user.Orders.Add(order);
        store.Orders.Add(order);

        return order;
      }
      catch
      {
        throw new System.Exception("We messed up");
      }
      finally
      {
        GC.Collect();
      }

    }

    internal static void PrintMenu()
    {
      Console.WriteLine("Select 1 for Cheese Pizza");
      Console.WriteLine("Select 2 for Pepperoni Pizza");
      Console.WriteLine("Select 3 for Hawaiian Pizza");
      Console.WriteLine("Select 4 for Custom Pizza");
      Console.WriteLine("Select 5 to see cart");
      Console.WriteLine("Select 6 for Exit");
      Console.WriteLine();
    }
  }
}