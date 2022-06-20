/*
 Пользователь вводит в консольном приложении длинное предложение. 
 Каждое слово в этом предложении отделено одним пробелом. 
 Необходимо создать метод, 
 который в качестве входного параметра принимает строковую переменную,
 а в качестве возвращаемого значения — массив слов.
 После вызова данного метода программа вызывает второй метод,
 который выводит каждое слово в отдельной строке.   
 */

using System;

namespace LineBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            Console.WriteLine("Слова должны быть разделены пробелом");

            string? str = Console.ReadLine(); // Предложение

            if(str.Length == 0)
            {
                Console.WriteLine("Предложение не введено");
                return;
            }

            string[] arr;  // Массив слов

            // Разделение строки на слова
            LineSplit(ref str, out  arr);

            PrintArray(ref arr);
        }

        /// <summary>
        /// Разделение строки на слова
        /// </summary>
        /// <param name="str">строка</param>
        /// <param name="arr">массив строк</param>
        static void LineSplit(ref string str, out  string[] arr)
        {
            arr = str.Split(' ').ToArray();
        }

        /// <summary>
        /// Печать массива
        /// </summary>
        /// <param name="arr">Массив</param>
        static void PrintArray(ref string[] arr)
        {
            foreach(string str in arr)
            {
                Console.WriteLine(str);
            }
        }
    }
}