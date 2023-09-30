using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_T_Ramilevich_Project_2
{
    internal class labwork
    {
        static void Main(string[] args)
        {
            Console.Write("Упражнение 4.1. Дата.\n Введите число от 1 до 365: ");
            int dayOfYear = int.Parse(Console.ReadLine());

            string month = "";
            int dayOfMonth = 0;

            if (dayOfYear >= 1 && dayOfYear <= 31)
            {
                month = "Январь";
                dayOfMonth = dayOfYear;
            }
            else if (dayOfYear >= 32 && dayOfYear <= 59)
            {
                month = "Февраль";
                dayOfMonth = dayOfYear - 31;
            }
            else if (dayOfYear >= 60 && dayOfYear <= 90)
            {
                month = "Март";
                dayOfMonth = dayOfYear - 59;
            }
            else if (dayOfYear >= 91 && dayOfYear <= 120)
            {
                month = "Апрель";
                dayOfMonth = dayOfYear - 90;
            }
            else if (dayOfYear >= 121 && dayOfYear <= 151)
            {
                month = "Май";
                dayOfMonth = dayOfYear - 120;
            }
            else if (dayOfYear >= 152 && dayOfYear <= 181)
            {
                month = "Июнь";
                dayOfMonth = dayOfYear - 151;
            }
            else if (dayOfYear >= 182 && dayOfYear <= 212)
            {
                month = "Июль";
                dayOfMonth = dayOfYear - 181;
            }
            else if (dayOfYear >= 213 && dayOfYear <= 243)
            {
                month = "Август";
                dayOfMonth = dayOfYear - 212;
            }
            else if (dayOfYear >= 244 && dayOfYear <= 273)
            {
                month = "Сентябрь";
                dayOfMonth = dayOfYear - 243;
            }
            else if (dayOfYear >= 274 && dayOfYear <= 304)
            {
                month = "Октябрь";
                dayOfMonth = dayOfYear - 273;
            }
            else if (dayOfYear >= 305 && dayOfYear <= 334)
            {
                month = "Ноябрь";
                dayOfMonth = dayOfYear - 304;
            }
            else if (dayOfYear >= 335 && dayOfYear <= 365)
            {
                month = "Декабрь";
                dayOfMonth = dayOfYear - 334;
            }
            else Console.WriteLine("Вне диапазона 0<day<366.");
            
            Console.WriteLine($"Месяц: {month}, День: {dayOfMonth}");
        }
    }
}