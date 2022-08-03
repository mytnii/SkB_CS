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
            HashSet<int> vs = new HashSet<int>();

            int number = ConsoleOperation.NumericInput();
        }
    }
}