using System;

namespace CALCULATOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в CALCULATRON1990! Для начала работы нажмите \"Enter\" или введите слово \"EXIT\" для выхода:");
            string enterselect = Console.ReadLine();
            switch (enterselect)
            {
                case "EXIT":
                    Console.WriteLine("До новых встреч!");
                    Console.ReadKey();
                    return;

                default:
                    Console.WriteLine("Отлично, тогда начнем!");
                    break;
            }
        link1:
            Console.WriteLine("Введите первое число:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int num2 = Convert.ToInt32(Console.ReadLine());
        link2:
            Console.WriteLine("Введите требуемую операцию:\n'+' для сложения\n'-' для вычитания\n'*' для умножения\n'/' для деления");
            Console.WriteLine("или'EXIT' для выхода из калькулятора");
            string select = Console.ReadLine();
            switch (select)
            {
                case "+":
                    Console.WriteLine($"Вы выбрали \"сложение\". Результатом будет служить число {num1 + num2}\n");
                    break;

                case "-":
                    Console.WriteLine($"Вы выбрали \"вычитание\" . Результатом будет служить число {num1 - num2}\n");
                    break;

                case "*":
                    Console.WriteLine($"Вы выбрали \"умножение\". Результатом будет служить число {num1 * num2}\n");
                    break;

                case "/":
                    Console.WriteLine($"Вы выбрали \"деление\". Результатом будет служить число {num1 / num2} с остатком {num1 % num2}\n");
                    break;

                case "EXIT":
                    Console.WriteLine("До встречи!");
                    Console.ReadKey();
                    return;

                default:
                    Console.WriteLine("Вы ввели неизвестную операцию;\n");
                    goto link2;
            }
            Console.WriteLine("Продолжить вычисления?");
        link3:
            Console.WriteLine("Нажмите \"Y\" для продолжения вычислений или \"N\" для выхода из программы:");
            string exitselect = Console.ReadLine();
            switch (exitselect)
            {
                case "Y":
                    Console.WriteLine("Отлично, продолжим!");
                    goto link1;

                case "N":
                    Console.WriteLine("Хорошо, удачи вам!");
                    return;

                default:
                    Console.WriteLine("Я не очень понял вашу команду, можете повторить?");
                    goto link3;
            }
        }
    }
}
