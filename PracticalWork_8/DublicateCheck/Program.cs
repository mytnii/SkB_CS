/*
 * Пользователь вводит число. 
 * Число сохраняется в HashSet коллекцию. 
 * Если такое число уже присутствует в коллекции, 
 * то пользователю на экран выводится сообщение, 
 * что число уже вводилось ранее. Если числа нет, 
 * то появляется сообщение о том, что число успешно сохранено. 
 */

using System.Collections.Generic;

namespace DublicateCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numbers = new HashSet<int>();
        }

        /// <summary>
        /// Добавление числа
        /// </summary>
        /// <param name="numbers">колекция чисел</param>
        static void AddNumber(ref HashSet<int> numbers)
        {
            ConsoleKeyInfo key;

            do
            {
                int number = ConsoleOperation.NumericInput();

                Console.WriteLine("Хотите продолжить Y/N");
                key = Console.ReadKey();

            } while (key.Key == ConsoleKey.Y);
        }
    }
}