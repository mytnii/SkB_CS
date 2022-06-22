/*
 Пользователь вводит в программе длинное предложение. 
 Каждое слово раздельно одним пробелом. 
 После ввода пользователь нажимает клавишу Enter. 
 Необходимо создать два метода:

 первый метод разделяет слова в предложении;
 второй метод меняет эти слова местами (в обратной последовательности). 
 При этом важно учесть, 
 что один метод вызывается внутри другого метода,
 то есть в методе main вызывается метод
 cо следующей сигнатурой — ReversWords (string inputPhrase). 
 Внутри этого метода вызывается метод по разделению входной фразы на слова.
 */

using System;

namespace WordTransposition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            Console.WriteLine("Слова должны быть разделены пробелом");

            string? str = Console.ReadLine(); // Предложение

            // Проверка ввода предложения
            if(str.Length == 0)
            {
                Console.WriteLine("Предложение не введено");
                return;
            }

            string[] arr = new string[str.Length];

            // переворот предложения
            ReversArray(ref str, ref arr);

            // Печать предложения на экран
            PrintArray(ref arr);
        }

        /// <summary>
        /// Разделение предложения на строки
        /// </summary>
        /// <param name="str">Строка</param>
        /// <param name="arr">Массив</param>
        static void LineSplit(ref string str, ref string[] arr)
        {
            arr = str.Split(' ').ToArray();
        }

        /// <summary>
        /// Переворот массива
        /// </summary>
        /// <param name="str">строка</param>
        /// <param name="arr">массив</param>
        static void ReversArray(ref string str, ref string[] arr )
        {
            
            string[] word = new string[arr.Length];
            LineSplit(ref str, ref arr);

            for(int i = 0; i < arr.Length; i++)
            {
                word[i] = arr[arr.Length - 1 - i];
            }

            arr = word;
        }

        /// <summary>
        /// Печать массива на экран
        /// </summary>
        /// <param name="arr"></param>
        static void PrintArray(ref string[] arr)
        {
            foreach(string str in arr)
            {
                Console.Write($"{str} ");
            }
            Console.WriteLine();
        }
    }
}