using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        enum days 
        {
            sat, 
            sun,
            mon,
            tue,
            wed,
            thu,
            fri         
        }
        static void Main(string[] args)
        {
            foreach (days month in Enum.GetValues(typeof(days)))
            {
                Console.WriteLine($"{month} имеет значения  {(int)month}");
            }
            Console.ReadKey();
        }
    }
}
