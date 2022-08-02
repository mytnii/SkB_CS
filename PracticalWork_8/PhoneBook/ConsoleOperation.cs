using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    /// <summary>
    /// Работа с консолью
    /// </summary>
    internal class ConsoleOperation
    {

        /// <summary>
        /// Заполнение владельца с клавиатуры
        /// </summary>
        /// <returns>Владелец</returns>
        public static Owner OwnerFill()
        {
            Owner owner = new Owner();
            owner.LastName = null;
            owner.FirstName = null;
            owner.Patronumic = null;

            Console.WriteLine("\n");

            while (owner.LastName == null)
            {
                Console.WriteLine("Введите Фамилию");
                owner.LastName = Console.ReadLine();

                if (owner.LastName == null)
                {
                    Console.WriteLine("Фамилия не введена\n");
                }
            }

            while (owner.FirstName == null)
            {
                Console.WriteLine("Введите Имя");
                owner.FirstName = Console.ReadLine();

                if (owner.FirstName == null)
                {
                    Console.WriteLine("Имя не введено\n");
                }
            }

            while (owner.Patronumic == null)
            {
                Console.WriteLine("Введите отчество");
                owner.Patronumic = Console.ReadLine();

                if (owner.Patronumic == null)
                {
                    Console.WriteLine("Отчество не введено");
                }
            }

            return owner;
        }

        /// <summary>
        /// Ввод номера телефона
        /// </summary>
        /// <returns>Номер телефона</returns>
        public static string EnteringPhoneNumber()
        {
            Console.WriteLine("Введите номер телефона");
            string phoneNumber;

            do
            {
                phoneNumber = Console.ReadLine();

                if(phoneNumber == null)
                {
                    Console.WriteLine("Номер телефона не введен");
                }
            } while (phoneNumber == null);

            return phoneNumber;
        }

        /// <summary>
        /// Окончание записи
        /// </summary>
        public static void EndOfRecord()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine
               (
               "|----|--------------------|---------------|----------|---------------|--------|----|--------------------|---------------|"
               );
            Console.ResetColor();
        }
    }
}
