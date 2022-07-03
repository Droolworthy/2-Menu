using System;

namespace CS13
{
    class Program
    {
        static void Main(string[] args)
        {
            string foregroundColor;
            string changeConsoleColor;
            string userInput;
            bool exitApp = true;

            while (exitApp)
            {
                Console.WriteLine("--------M-----------Е-----------Н-----------Ю-----");
                Console.WriteLine("----Для изменения цвета текста на зелёный - color-");
                Console.WriteLine("----Для изменения цвета консоли - console---------");
                Console.WriteLine("----Для того чтобы очистить консоль - clear-------");
                Console.WriteLine("----Для выхода из приложения введите exit---------");
                Console.WriteLine("--------------------------------------------------");
                Console.Write("Введите команду: ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "color":
                        foregroundColor = Convert.ToString(Console.ReadLine());
                        foregroundColor = Convert.ToString(Console.ForegroundColor = ConsoleColor.Green);

                        if (userInput == "color")
                        {
                            Console.WriteLine("Вы поменяли цвет текста на зелёный");
                        }
                        break;
                    case "Console":
                        changeConsoleColor = Console.ReadLine();
                        changeConsoleColor = Convert.ToString(Console.BackgroundColor = ConsoleColor.Red);

                        if (userInput == "console")
                        {
                            Convert.ToString(Console.BackgroundColor = ConsoleColor.Red);
                            Console.Clear();
                            Console.WriteLine("Вы поменяли цвет консоли на красный");
                        }
                        break;
                    case "clear":
                        Console.Clear();
                        break;
                    case "exit":
                        exitApp = false;
                        break;
                    default:
                        {
                            Console.WriteLine("Введите color,console,clear или exit");
                            break;
                        }
                }
            }
        }
    }
}
