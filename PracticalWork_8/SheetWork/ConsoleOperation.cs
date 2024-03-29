﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheetWork
{
    /// <summary>
    /// работа с консолью
    /// </summary>
    internal class ConsoleOperation
    {
        /// <summary>
        /// Печать на экран
        /// </summary>
        /// <param name="numbers">Лист целых чисел</param>
        public static void SheetPrinting(List<int> numbers)
        {
            foreach (int number in numbers)
            {
                Console.Write($"{number}\t");
            }
            Console.WriteLine($"\n\n{numbers.Count}\n");
        }
    }
}
