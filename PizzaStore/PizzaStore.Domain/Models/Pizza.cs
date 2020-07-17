using System.Collections.Generic;
using System.Text;


namespace PizzaStore.Domain.Models
{
  public class Pizza
  {
    // STATE
    //fields
    private readonly string _imageUrl = "https://some-url";
    private const double _diameter = 0; //one copy throughout workspace, can never change
    private static string _name = "pizza"; //one copy, can change
    private List<string> _toppings = new List<string>();

    //properties
    public string Size { get; set; } //removing set = can never be changed once constructed
    public string Crust { get; set; }
    public List<string> Toppings
    {
      get
      {
        return _toppings;
      }
    }

    // BEHAVIOR
    //methods
    void AddToppings(string topping)
    {
      Toppings.Add(topping);
    }

    // string concatenation:
    /*
    topping1
    topping1 + topping2
    topping1 + topping2 + topping3
    */

    //stringbuilder: mutable
    /*
    topping1 + topping2 + topping 3
    */

    public override string ToString()
    {
      var sb = new StringBuilder();

      foreach (var t in Toppings)
      {
        sb.Append(t);
      }

      return $"{Crust} \n{Size} \n{sb}";
    }
    //constructors

    public Pizza(string size, string crust, List<string> toppings)
    {
      Size = size;
      Crust = crust;
      Toppings.AddRange(toppings);
    }

    public Pizza()
    {
      Size = "";
      Crust = ""; //Intentionally empty, overloading
    }
    //finalizers or destructors
  }
}