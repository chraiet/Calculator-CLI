using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator__CLI_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******\nWelcome to Calculator (CLI)!\n******\n");

            string userInput = "";
            do
            {
                Console.WriteLine("Choose the operation and press Enter:\n\t1 - Add\n\n\t2 - Substract\n\tQ - Quit");

                //  Get user input.
                userInput = Console.ReadLine();
                userInput = userInput.ToLower();

                //  Choose the right operation.
                switch (userInput)
                {
                    case "1":
                    case "add":
                        Console.Write("Choose first number: ");
                        string a = Console.ReadLine();
                        Console.Write("Choose second number: ");
                        string b = Console.ReadLine();
                        double numberA;
                        double.TryParse(a, out numberA);
                        double numberB;
                        double.TryParse(b, out numberB);
                        double resultAdd = Math.Add(numberA, numberB);
                        Console.WriteLine($"The result of the addition is {resultAdd}");
                        break;
                    case "2":
                    case "substract":
                        Console.WriteLine("Choose first number: ");
                        string c = Console.ReadLine();
                        Console.WriteLine("Choose second number: ");
                        string d = Console.ReadLine();
                        double numberC;
                        double.TryParse(c, out numberC);
                        double numberD;
                        double.TryParse(d, out numberD);
                        double resultSubstract = Math.Substract(numberC, numberD);
                        Console.WriteLine($"The result of the substraction is {resultSubstract}");
                        break;
                    default:
                        Console.WriteLine("This operation does not exist. Please try again.");
                        break;
                }
            } while (userInput != "q");
        }
    }
}
