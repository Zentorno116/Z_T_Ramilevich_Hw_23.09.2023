using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_T_Ramilevich_Project_1
{
    internal class Solution
    {
        enum Week
        {
            Понедельник = 1,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Task 3.Должности и выпивка. \n");

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

            Console.WriteLine("Task 4. Дни недели. \n");

            Console.WriteLine("Введите номер дня недели.");
            int Day = int.Parse(Console.ReadLine());
            if (Day > 7 | Day < 1)
            {
                Console.WriteLine("Ошибка");
            }
            else
            {
                Console.WriteLine($"День недели: {(Week)Day}");
            }
            Console.ReadKey();
            Console.Clear();


            
        }
    }
}