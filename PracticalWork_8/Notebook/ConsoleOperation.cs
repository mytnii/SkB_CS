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
        enum ContentsTables
        {
            Last_name,
            First_name,
            Patronumic,
            Street,
            House_number,
            Flat_number,
            Mobile_phone,
            Flat_phone

        }
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

        /// <summary>
        /// Печать таблици в консоль
        /// </summary>
        public static void PrintTable()
        {
            EndOfRecord();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine
                (
                $"|{ContentsTables.Last_name,15}|" +
                $"{ContentsTables.First_name,10}|" +
                $"{ContentsTables.Patronumic,15}|" +
                $"{ContentsTables.Street,10}|" +
                $"{ContentsTables.House_number,15}|" +
                $"{ContentsTables.Flat_number,15}|" +
                $"{ContentsTables.Mobile_phone,15}|" +
                $"{ContentsTables.Flat_phone,15}|"
                );
            EndOfRecord();
            Console.ResetColor();
        }

        /// <summary>
        /// Окончание записи
        /// </summary>
        public static void EndOfRecord()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine
                (
                "|---------------|----------|---------------|----------|---------------|---------------" +
                "|---------------|---------------|"
                );
            Console.ResetColor();
        }

        #endregion
    }
}
