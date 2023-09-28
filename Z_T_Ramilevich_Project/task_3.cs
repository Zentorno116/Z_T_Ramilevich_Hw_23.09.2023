using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_4
{
    internal class task_3
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Задание 3.\n");

            Console.WriteLine("Введите должность.");
            string human = Console.ReadLine();
            switch (human.ToLower())
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequila");
                    break;
                case "school counselor":
                    Console.WriteLine("Anything with Alcohol");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine");
                    break;
                case "politician":
                    Console.WriteLine("Your tax dollars");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Beer");
                    break;
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}