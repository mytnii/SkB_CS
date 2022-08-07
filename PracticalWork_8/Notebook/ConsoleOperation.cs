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
        /// Ввод данных Человека: Фамилия, Имя, Отчество
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
        /// Ввод данных адрес: улица, номер дома, номер квартиры
        /// </summary>
        /// <param name="address">Адрес</param>
        public static void DateEntryAddress(ref Address address)
        {
            // Ввод названия улици
            do
            {
                Console.WriteLine("Введите название улици");
                address.Street = Console.ReadLine();

                if(address.Street == "")
                {
                    Console.WriteLine("Название улици не введено");
                }
            } while (address.Street == "");

            // Ввод номера дома
            do
            {
                Console.WriteLine("Введите номер дома");
                int houseNumber;
                int.TryParse(Console.ReadLine(), out houseNumber);

                if(houseNumber == 0)
                {
                    Console.WriteLine("Не коректно введен номер дома");
                }

                address.HouseNumber = houseNumber;
            } while (address.HouseNumber == 0);

            // Ввод номера квартиры
            do
            {
                Console.WriteLine("Введите номер квартиры");
                int flatNumber;
                int.TryParse(Console.ReadLine(), out flatNumber);

                if(flatNumber == 0)
                {
                    Console.WriteLine("Не коректно введен номер квартиры");
                }
                address.FlatNumber = flatNumber;
            } while (address.FlatNumber == 0);
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
