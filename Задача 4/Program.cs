using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    class Program
    { enum UserRole
        {
            Администратор,
            Модератор,
            Пользователь,
            Гость
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вашу роль: Администратор Модератор Пользователь Гость");
            string input = Console.ReadLine();

            bool isValid = Enum.TryParse(input, ignoreCase: true, out UserRole role);

            if (isValid)
            {
                switch (role)
                {
                    case UserRole.Администратор:
                        Console.WriteLine("Вы зарегистрированы как администратор.");
                        break;
                    case UserRole.Модератор:
                        Console.WriteLine("Вы зарегистрированы как модератор.");
                        break;
                    case UserRole.Пользователь:
                        Console.WriteLine("Вы зарегистрированы как пользователь.");
                        break;
                    case UserRole.Гость:
                        Console.WriteLine("Вы зарегистрированы как гость.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ошибка: введена некорректная роль. Допустимые значения: Admin, Moderator, User, Guest.");
            }
            Console.ReadKey();

        }
    }
}
