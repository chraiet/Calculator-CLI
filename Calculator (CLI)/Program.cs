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
                Console.WriteLine("Choose the operation and press Enter:\n\t1 - Add\n\tQ - Quit");
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
                    default:
                        Console.WriteLine("This operation does not exist. Please try again.");
                        break;
                }
            } while (userInput != "q");
        }
    }
}
