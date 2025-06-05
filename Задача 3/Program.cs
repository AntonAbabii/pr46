using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{ 
            using System;

        enum MathOperation
        {
            Add = 1,
            Subtract,
            Multiply,
            Divide
        }

        class Program
        {
            static void Main()
            {
                Console.Write("Введите первое число: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите второе число: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("1 - Сложение");
                Console.WriteLine("2 - Вычитание");
                Console.WriteLine("3 - Умножение");
                Console.WriteLine("4 - Деление");

                int choice = Convert.ToInt32(Console.ReadLine());

                MathOperation operation = (MathOperation)choice;

                double result = 0;
                bool valid = true;

                switch (operation)
                {
                    case MathOperation.Add:
                        result = num1 + num2;
                        break;
                    case MathOperation.Subtract:
                        result = num1 - num2;
                        break;
                    case MathOperation.Multiply:
                        result = num1 * num2;
                        break;
                    case MathOperation.Divide:
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                        {
                            Console.WriteLine("Ошибка: деление на ноль.");
                            valid = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Неверный выбор операции.");
                        valid = false;
                        break;
                }

                if (valid)
                    Console.WriteLine($"Результат: {result}");
            Console.ReadKey();
            }
        }


}


