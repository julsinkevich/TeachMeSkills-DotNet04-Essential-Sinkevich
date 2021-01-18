using System;

namespace Essential
{
    class Program
    {
        static void Main(string[] args)
        {
            var task1 = new Tasks1_10.Task1();
            var task2 = new Tasks1_10.Task2();
            var task3 = new Tasks1_10.Task3.Task3();
            var task4 = new Tasks1_10.Task4.Task4();
            var task5 = new Tasks1_10.Task5.Task5();
            var task6 = new Tasks1_10.Task6.Task6();


            while (true)
            {
                Console.WriteLine("Условие задач-читайте README");
                Console.WriteLine("Введите номер задачи:");
                Console.ForegroundColor = ConsoleColor.Green;
                int.TryParse(Console.ReadLine(), out int userInput);
                Console.ForegroundColor = ConsoleColor.White;
                switch (userInput)
                {
                    case 1:
                        task1.Task();
                        break;
                    case 2:
                        task2.Book();
                        break;
                    case 3:
                        task3.Task();
                        break;
                    case 4:
                        task4.Task();
                        break;
                    case 5:
                        task5.Task();
                        break;
                    case 6:
                        task6.Task();
                        break;
                    default:
                        Console.WriteLine("Вы нажали неизвестный символ");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
