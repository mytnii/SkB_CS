using System;
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
        public static void SheetPrinting(ref List<int> numbers)
        {
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
        }
    }
}
