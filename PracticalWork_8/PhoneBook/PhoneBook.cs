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
                Console.WriteLine("2 - печать телефенной книги на экран");
                Console.WriteLine("3 - поиск владельца по номеру телефона");

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
                    case "2":
                        ConsoleOperation.TablePrint();

                        foreach(var phone in phoneBook._phoneBook)
                        {
                            ConsoleOperation.PrintPhoneBook(phone.Key, phone.Value);
                        }
                        break;
                    case "3":
                        OwnerSearch(ref phoneBook);
                        break;
                    default:
                        Console.WriteLine("Введено не правильное действие");
                        break;
                }

                Console.WriteLine("Хотите родолжить Y/N");
                key = Console.ReadKey();
                Console.WriteLine();
            } while (key.Key == ConsoleKey.Y);

        }

        /// <summary>
        /// Поиск владельца по номеру телефона
        /// </summary>
        /// <param name="phoneBook">Телефонная книга</param>
        static void OwnerSearch(ref PhoneBook phoneBook)
        {
            string phoneNumber = ConsoleOperation.EnteringPhoneNumber();

            Owner owner = new Owner();

            if (phoneBook._phoneBook.TryGetValue(phoneNumber, out owner))
            {
                ConsoleOperation.TablePrint();
                ConsoleOperation.PrintPhoneBook(phoneNumber, owner);
            }
            else
            {
                Console.WriteLine($"Владельца с номером {phoneNumber} не существует");
            }

        }
    }
}
