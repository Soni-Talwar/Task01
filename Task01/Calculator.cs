using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Calculator
    {
         Myproject();

        static void Main(string[] args)

        {
           

            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                //Console.WriteLine("------------------");
                Console.WriteLine("Calculator Program");
                //Console.WriteLine("------------------");

                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write("Enter a number : ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter another number : ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an option: ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.Write("Enter an option: ");


                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result is : {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result is : {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result is : {num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result is : {num1} / {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("That was not a valid option");
                        break;
                }
                Console.Write("Would you like to continue? (Y = yes, N = No): ");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("See you next time Bye!");
            Console.ReadKey();
        }
    }

}






    


