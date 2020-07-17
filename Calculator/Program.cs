using System;

namespace Calculator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our Basic Calculator!");
            
            var stay = true;
            do
            {

            Console.WriteLine("Menu");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division");
            Console.WriteLine("Press 5 to Exit");

            System.Console.Write("Input: ");
            var choice = Console.ReadLine();
            
            double input1 = 0.0;
            double input2 = 0.0;
            
            switch(choice)
            {
                /*
                casting
                "2" -> 2.0
                "2a" -> error

                parsing
                "2a" -> 2.0
                */

                case "1":
                    /* 
                    var input1 = (double)Console.ReadLine(); //explicit casting with exception
                    var input2 = Console.ReadLine() as double; //explicit casting with null
                    input1 = double.Parse(Console.ReadLine()); //explicit casting with 0
                    double.TryParse(Console.ReadLine(), out input2); //explicit casting with exception
                    */

                    double.TryParse(Console.ReadLine(), out input1);

                    if (input1 )

                    double.TryParse(Console.ReadLine(), out input2);
                    Add(input1, input2);
                    break;
                case "2":
                    double.TryParse(Console.ReadLine(), out input1);
                    double.TryParse(Console.ReadLine(), out input2);
                    Subtract(input1, input2);
                    break;
                case "3":
                    double.TryParse(Console.ReadLine(), out input1);
                    double.TryParse(Console.ReadLine(), out input2);
                    Multiply(input1, input2);
                    break;
                case "4":
                    double.TryParse(Console.ReadLine(), out input1);
                    double.TryParse(Console.ReadLine(), out input2);
                    Divide(input1, input2);
                    break;
                case "5":
                    stay = false;
                    break;
                default:
                    Console.WriteLine("Invalid Input. Try again.");
                    Console.WriteLine();
                    break;
            }
          } while (stay);
        }

        static void Add(double operand1, double operand2)
        {
            var result = operand1 + operand2;
            Console.WriteLine($"Your answer is: {result}.");
            Console.WriteLine();
        }

        static void Subtract(double operand1, double operand2)
        {
            var result = operand1 - operand2;
            Console.WriteLine($"Your answer is: {result}.");
            Console.WriteLine();
        }

        static void Multiply(double operand1, double operand2)
        {
            var result = operand1 * operand2;
            Console.WriteLine($"Your answer is: {result}.");
            Console.WriteLine();
        }

        static void Divide(double operand1, double operand2)
        {
            var result = operand1 / operand2;
            Console.WriteLine($"Your answer is: {result}.");
            Console.WriteLine();
        }
    }


}
