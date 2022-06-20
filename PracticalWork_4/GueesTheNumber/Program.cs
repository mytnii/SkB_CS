/*
Разработайте программу по следующему алгоритму:

Пользователь вводит максимальное целое число диапазона. 
На основе диапазона целых чисел (от 0 до «введено пользователем») 
программа генерирует случайное целое число из диапазона. 
Пользователю предлагается ввести загаданное программой случайное число. 
Пользователь вводит свои предположения в консоли приложения. 
Если число меньше загаданного, программа сообщает об этом пользователю. 
Если больше, то тоже сообщает, что число больше загаданного. 
Программа завершается, когда пользователь угадал число. 
Если пользователь устал играть, 
то вместо ввода числа он вводит пустую строку и нажимает Enter. 
Тогда программа завершается, предварительно показывая, какое число было загадано.
 */

using System;

namespace GueesTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Максимальный диапозон чисел: ");
            int endOfRange; // Конец диапозона
            int.TryParse(Console.ReadLine(), out endOfRange);

            if(endOfRange <= 0)
            {
                Console.WriteLine("Неправельный ввод диапозона");
                return;
            }

            Random random = new Random();

            int puzzledNumber = random.Next(endOfRange); // Загаданное число

            int value;
            string? str;

            Console.WriteLine("Выход из программы - Enter");

            do
            {

                Console.Write("Введите число");
                str = Console.ReadLine();

                int.TryParse(str, out value);
                
                if(str.Length == 0)
                {
                    Console.WriteLine($"Загаданное число: {puzzledNumber}");
                    Console.WriteLine("До свидания");
                    break;
                }
                else if(value == 0 && str != "0")
                {
                    Console.WriteLine("Неправильный ввод числа");
                    continue;
                }
                else if(value > puzzledNumber)
                {
                    Console.WriteLine($"Число {value} больше загаданного");
                }
                else if(value < puzzledNumber)
                {
                    Console.WriteLine($"Число {value} меньше загаданного");
                }
                else
                {
                    Console.WriteLine($"Вы угадали загаданное число: {puzzledNumber}");
                    break;
                }

                

               
            } while (true);
        }
    }
}