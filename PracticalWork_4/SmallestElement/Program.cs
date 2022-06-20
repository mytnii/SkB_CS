/*
   Найдите наименьший элемент в последовательности, которую вводит пользователь.
   Последовательность нужно сохранить в массив. Детальный алгоритм программы:

   Пользователь вводит длину последовательности. 
   Затем пользователь последовательно вводит целые числа 
   (как положительные, так и отрицательные). Числа разделяются клавишей Enter.
   Каждое введённое число помещается в соответствующий элемент массива.
   После окончания ввода данных отдельный цикл проходит по последовательности
   и находит минимальное число. Для этого он сравнивает каждое число в итерации
   с предыдущим найденным минимальным числом. 
 */

using System;

namespace SmallestElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинну массива");
            int size; // Размер массива
            int.TryParse(Console.ReadLine(), out size);

            if(size <= 0)
            {
                Console.WriteLine("Неправельный ввод размера массива");
                return;
            }

            var arr = new int[size];

            // Заполнение массива
            ArrayFilling(ref arr, size);

            // Печать массива
            PrintArray(ref arr);

            // Минимальный элемент в массиве
            Console.WriteLine($"Минимальный элемент в массиве: {arr.Min()}"); /* Решил не прописывать
                                                                               * весь цикл, воспользовался
                                                                               * встроенным методом
                                                                               */

        }

        static void ArrayFilling(ref int[] arr, int size)
        {
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine("Введите целое число");
                string? str = Console.ReadLine();
                
                if(!NumericValueCheck(ref str))
                {
                    Console.WriteLine("Введенное значение не является числом");
                    --i;
                    continue;
                }

                arr[i] = int.Parse(str);
            }
        }

        /// <summary>
        /// Проверка на числовое значение
        /// </summary>
        /// <param name="str">Строка</param>
        /// <returns>Истина, лож</returns>
        static bool NumericValueCheck(ref string str)
        {
            foreach(char c in str)
            {
                if(!char.IsDigit(c))
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Печать массива на экран
        /// </summary>
        /// <param name="arr">Массив</param>
        static void PrintArray(ref int[] arr)
        {
            foreach(int i in arr)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine();
        }
    }
}