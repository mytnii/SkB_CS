using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    /// <summary>
    /// Работа с консолью
    /// </summary>
    internal class ConsoleOperation
    {
        #region Методы

        /// <summary>
        /// Ввод данны Человека: Фамилия, Имя, Отчество
        /// </summary>
        /// <param name="person">Человек</param>
        public static void DataEntryPerson(ref Person person)
        {
            // Ввод Фамилии
            do
            {
                Console.WriteLine("Введите фамилию");
                person.FirstName = Console.ReadLine();

                if (person.FirstName == "")
                {
                    Console.WriteLine("Фамилия не введена");
                }
            } while (person.FirstName == "");

            // Ввод имени
            do
            {
                Console.WriteLine("Введите Имя");
                person.LastName = Console.ReadLine();

                if(person.LastName == "")
                {
                    Console.WriteLine("Имя не введено");
                }
            } while (person.LastName == "");

            // Ввод Отчества
            do
            {
                Console.WriteLine("Введите отчество");
                person.Patronumic = Console.ReadLine();

                if( person.Patronumic == "")
                {
                    Console.WriteLine("Отчество не введено");
                }
            } while (person.Patronumic == "");
        } 

        #endregion
    }
}
