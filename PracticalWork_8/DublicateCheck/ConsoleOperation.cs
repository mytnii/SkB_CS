using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DublicateCheck
{
    internal class ConsoleOperation
    {
        /// <summary>
        /// Ввод числа
        /// </summary>
        /// <returns>Целое число</returns>
        public static int NumericInput()
        {
            int number;
            do
            {
                Console.WriteLine("введите число");
                string? str = Console.ReadLine();
                int.TryParse(str, out number);

                if(number == 0 && str != "0")
                {
                    Console.WriteLine("Введено не число");
                }
                else
                {
                    return number;
                }

            } while (true);
        }

        /// <summary>
        /// Проверка присутсвия числа в коллекции
        /// </summary>
        /// <param name="numbers">Коллекция чисел</param>
        /// <param name="number">Число</param>
        public static void CheckNumber(ref HashSet<int> numbers, int number)
        {
            if(numbers.Contains(number))
            {
                Console.WriteLine($"Число {number} присутствует в коллекции");
            }
            else
            {
                Console.WriteLine($"Число {number} успешно сохранено");
                numbers.Add(number);
            }
        }
    }

}
