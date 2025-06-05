using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {/// <summary>
     /// Задача1: Перечисление названий месяцев года.
     /// </summary>
        enum Month
        {
            Январь = 1,
            Февраль,
            Март,
            Апрель,
            Май,
            Июнь,
            Июль,
            Август,
            Сентябрь,
            Октябрь,
            Ноябрь,
            Декабрь
        }

        static void Main(string[] args)
        {
            foreach (Month month in Enum.GetValues(typeof(Month)))
            {
                Console.WriteLine($"{(int)month} - {month}");
            }
            Console.ReadKey();
        }

        
        
    }
}
