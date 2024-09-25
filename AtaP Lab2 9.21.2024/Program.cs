using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtaP_Lab_2__9._20._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1

            /*
            Console.WriteLine("write an x:");
            double a = 1.65;
            double x;
            x = Convert.ToDouble(Console.ReadLine()); //задати х
            double result;
            double ln = 2.718;
            if (x == 1.4)
            {
                result = a * Math.Pow(x, 3) + 8 / Math.Sqrt(x);
            }
            else if (x < 1.4)
            {
                result = Math.PI * Math.Pow(x, 2) - 7 / Math.Pow(x, 2);
            }
            else
            {
                result = ln * (x + 9 * Math.Sqrt(Math.Abs(x + a)));
            }
            double y;
            y = result;
            Console.WriteLine($"{x} --> {y}"); //виводити y
            */

            //task 2

            /*
            // Введення чисел a, b, c та d
            Console.Write("Введiть число a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введiть число b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введiть число c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введiть число d: ");
            double d = Convert.ToDouble(Console.ReadLine());

            // Перевіряємо, яке з чисел дорівнює d
            if (a == d)
            {
                Console.WriteLine("Число a дорiвнює d");
            }
            else if (b == d)
            {
                Console.WriteLine("Число b дорiвнює d");
            }
            else if (c == d)
            {
                Console.WriteLine("Число c дорiвнює d");
            }
            else
            {
                // Якщо жодне число не дорівнює d, знаходимо найближче до d
                double closest = a; // Нехай найближче число поки що a

                // Перевіряємо, чи число b ближче до d
                if (Math.Abs(b - d) < Math.Abs(closest - d))
                {
                    closest = b;
                }

                // Перевіряємо, чи число c ближче до d
                if (Math.Abs(c - d) < Math.Abs(closest - d))
                {
                    closest = c;
                }

                Console.WriteLine($"Найбiльш наближене до d число: {closest}");
            }
            */

            //task 3

            // Використовуємо switch для обчислення відповідного значення в кілограмах
            // Введення маси та одиниці виміру
            Console.Write("Введiть масу М: ");
            double mass = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Оберiть одиницю вимiру:");
            Console.WriteLine("1 - Кiлограм");
            Console.WriteLine("2 - Мiлiграм");
            Console.WriteLine("3 - Грам");
            Console.WriteLine("4 - Тонна");
            Console.WriteLine("5 - Центнер");

            Console.Write("Введiть номер одиницi вимiру: ");
            int unit = Convert.ToInt32(Console.ReadLine());

            double result = 0;  // Результат у кілограмах


            // Використовуємо switch для обчислення відповідного значення в кілограмах
            switch (unit)
            {
                case 1:
                    result = mass;  // Якщо кілограм, залишаємо масу без змін
                    break;
                case 2:
                    result = mass / 1_000_000;  // Міліграми -> кілограми (1 кг = 1,000,000 мг)
                    break;
                case 3:
                    result = mass / 1_000;  // Грами -> кілограми (1 кг = 1,000 г)
                    break;
                case 4:
                    result = mass * 1_000;  // Тонни -> кілограми (1 тонна = 1,000 кг)
                    break;
                case 5:
                    result = mass * 100;  // Центнери -> кілограми (1 центнер = 100 кг)
                    break;
                default:
                    Console.WriteLine("Невiрно обрана одиниця вимiру.");
                    return;  // Завершуємо програму у разі неправильного вибору
            }

            // Виведення результату
            Console.WriteLine($"Маса в кiлограмах: {result} кг");
            //The End
            Console.ReadKey();
        }
    }
}