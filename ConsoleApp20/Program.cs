using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isExit = false;
            while (isExit==false)
            {
                Console.WriteLine("\n setconsolecolor - Поменять цвет фона консоли. \n settextcolor - Меняет цвет текста в консоли. \n clear - очистить консоль. \n randomaction - Случайное действие. \n exit - закрыть приложение.");
                Console.Write("Выберете необходимое действие: ");
                string program = Console.ReadLine();
                
                switch (program)
                {
                    case "setconsolecolor":
                        Console.WriteLine("Выбирите цвет: \n 1) Red \n 2) Green \n 3) Blue \n 4) Yellow");
                        int color = Convert.ToInt32(Console.ReadLine());
                        switch (color)
                        {
                            case 1:
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.Clear();
                                break;
                            case 2:
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.Clear();
                                break;
                            case 3:
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.Clear();
                                break;
                            case 4:
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.Clear();
                                break;
                            default:
                                Console.WriteLine("Цвет не найден.");
                                break;
                        }
                        break;
                    case "settextcolor":
                        Console.WriteLine("Выбирите цвет: \n 1) Red \n 2) Green \n 3) Blue \n 4) Yellow \n");
                        int colorText = Convert.ToInt32(Console.ReadLine());
                        switch (colorText)
                        {
                            case 1:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Clear();
                                Console.WriteLine("Цвет изменен.");
                                break;
                            case 2:
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Clear();
                                Console.WriteLine("Цвет изменен.");
                                break;
                            case 3:
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Clear();
                                Console.WriteLine("Цвет изменен.");
                                break;
                            case 4:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Clear();
                                Console.WriteLine("Цвет изменен.");
                                break;
                            default:
                                Console.WriteLine("Цвет не найден.");
                                break;
                        }
                        break;
                    case "clear":
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        break;
                    case "randomaction":
                        Random random = new Random();
                        int action = random.Next(1, 6);
                        switch (action)
                        {
                            case 1:
                                Console.WriteLine("Сделать домашку.");
                                break;
                            case 2:
                                Console.WriteLine("Повторить курс.");
                                break;
                            case 3:
                                Console.WriteLine("Сделать уборку.");
                                break;
                            case 4:
                                Console.WriteLine("Посмотреть сериал.");
                                break;
                            case 5:
                                Console.WriteLine("Пойти на улицу");
                                break;
                        }
                        break;
                    case "exit":
                        isExit = true;
                        break;
                }
            }
        }
        }
    }

