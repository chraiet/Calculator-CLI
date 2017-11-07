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
            string userInput = "";
            do
            {
                Console.WriteLine("Choose the operation and press Enter:\n\tQ - Quit");
                userInput = Console.ReadLine();
                userInput = userInput.ToLower();
            } while (userInput != "q");
        }
    }
}
