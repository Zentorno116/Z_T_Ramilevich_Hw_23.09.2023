using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_T_Ramilevich_Project_1
{
    internal class task_4
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
            Console.WriteLine("Задание 4.\n");

            Console.WriteLine("Введите день недели.");
            int Day = int.Parse(Console.ReadLine());
            if (Day < 1 | Day > 7)
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