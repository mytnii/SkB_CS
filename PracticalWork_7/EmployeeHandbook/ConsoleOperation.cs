using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeHandbook
{
    /// <summary>
    /// Класс работа с консолью
    /// </summary>
    internal class ConsoleOperation
    {
        enum Employees
        {
            ID,
            Создание_записи,
            Фамилия,
            Имя,
            Отчество,
            Возраст,
            Рост,
            Дата_рождения,
            Место_рождения,

        }
        /// <summary>
        /// Печать сотрудника в консоль
        /// </summary>
        /// <param name="employee">Сотрудник</param>
        //public static void PrintEmployee(ref Employee employee)
        //{


        //   

        //    Console.ResetColor();

        //    Console.Write($"{employee.id,4}");
        //    TextColorChange();
        //    Console.Write($"{employee.date,15}");
        //    TextColorChange();

        //}


        /// <summary>
        /// Печать таблици в консоль
        /// </summary>
        public static void TablePrint()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine
                (
                $"{Employees.ID,4}|" +
                $"{Employees.Создание_записи,15}|" +
                $"{Employees.Фамилия,15}|" +
                $"{Employees.Имя,10}|" +
                $"{Employees.Отчество,15}|" +
                $"{Employees.Возраст,8}|" +
                $"{Employees.Рост,4}|" +
                $"{Employees.Дата_рождения,15}|" +
                $"{Employees.Место_рождения,15}|"
                );
            Console.ResetColor();
        }

        /// <summary>
        /// Изменение цвета текста в консоли
        /// </summary>
        static void TextColorChange()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("|");
            Console.ResetColor();
        }

        /// <summary>
        /// Окончание записи
        /// </summary>
       public static void EndOfRecord()
        {
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine
               (
               "----|---------------|---------------|----------|---------------|--------|----|---------------|---------------|"
               );
        }
    }
}
