using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    /// <summary>
    /// Телефонная книга
    /// </summary>
    internal class PhoneBook
    {
       private Dictionary<string, Owner> _phoneBook;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public PhoneBook()
        {
            this._phoneBook = new Dictionary<string,Owner>();
        }

        /// <summary>
        /// Меню действий
        /// </summary>
        public static void Menu()
        {
            ConsoleKeyInfo key;

            PhoneBook phoneBook = new PhoneBook();

            string size;


            do
            {
                Console.WriteLine("Введите действие");
                Console.WriteLine("1 - добавление номера телефона и его владельца");

                size = Console.ReadLine();

                switch (size)
                {
                    case "1":
                        phoneBook._phoneBook.Add
                            (
                            ConsoleOperation.EnteringPhoneNumber(),
                            ConsoleOperation.OwnerFill()
                            );
                        break;
                    default:
                        Console.WriteLine("Введено не правильное действие");
                        break;
                }

                Console.WriteLine("Хотите родолжить Y/N");
                key = Console.ReadKey();
            } while (key.Key == ConsoleKey.Y);
        }
    }
}
