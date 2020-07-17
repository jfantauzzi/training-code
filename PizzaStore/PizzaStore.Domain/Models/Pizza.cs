using System.Collections.Generic;
using System.Text;


namespace PizzaStore.Domain.Models
{
  public class Pizza
  {
    // STATE
    //fields
    private string _imageUrl = "";
    private double _diameter = 0;
    //public string Size = "";
    //public string Crust = "";
    public List<string> _toppings = new List<string>();
    //properties
    public string Size {get;} //remove set = can never be changed
    public string Crust {get;}
    public List<string> Toppings
    {
      get{
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

       foreach(var t in Toppings)
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
    //finalizers or destructors
  }
}