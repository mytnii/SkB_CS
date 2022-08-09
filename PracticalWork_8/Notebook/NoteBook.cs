using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    /// <summary>
    /// Класс Записная книжка
    /// </summary>
    internal class NoteBook
    {
        #region Поля

        private Person _person;           // Человек
        private List<Address> _addresses; // Список адресов
        private List<Phones> _phones;     // Список телефонных номеров

        #endregion

        #region Конструкторы

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public NoteBook()
        {
            _person = new Person();
            _addresses = new List<Address>();
            _phones = new List<Phones>();
        }
        #endregion

        /// <summary>
        /// Меню Записной книжки
        /// </summary>
        public static void Menu()
        {
            List<NoteBook> noteBooks = new List<NoteBook>();
            ConsoleKeyInfo key;
            do
            {
                Console.WriteLine("Выбирете действие");
                Console.WriteLine("1 - Добавить запись");
                Console.WriteLine("2 - печать записей на экран");

                string value = Console.ReadLine();

                switch (value)
                {
                    case "1":
                        noteBooks.Add(new NoteBook());
                        noteBooks[noteBooks.Count - 1].AddEntry();
                        break;
                    case "2":
                        ConsoleOperation.PrintTable();

                        foreach (var note in noteBooks)
                        {
                            ConsoleOperation.PrintPerson(ref note._person);

                            if(note._addresses.Count > note._phones.Count)
                            {
                                for(int i = 0; i < note._addresses.Count; i++)
                                {
                                    if(i > 0)
                                    {
                                        ConsoleOperation.ColorChangeConsole();
                                        ConsoleOperation.PrintBlankValues(3);
                                    }

                                    ConsoleOperation.PrintAddress( note._addresses[i]);

                                    if(i > note._phones.Count - 1)
                                    {
                                        ConsoleOperation.PrintBlankValues(2);
                                    }
                                    else
                                    {
                                        ConsoleOperation.PrintPhones( note._phones[i]);
                                    }

                                    Console.WriteLine();
                                }
                            }
                            else
                            {
                                for(int i = 0; i < note._phones.Count; i++)
                                {
                                    if(i > 0)
                                    {
                                        ConsoleOperation.ColorChangeConsole();
                                        ConsoleOperation.PrintBlankValues(3);
                                    }

                                    if(i > note._addresses.Count - 1)
                                    {
                                        ConsoleOperation.PrintBlankValues(3);
                                    }
                                    else
                                    {
                                        ConsoleOperation.PrintAddress(note._addresses[i]);
                                    }

                                    ConsoleOperation.PrintPhones(note._phones[i]);
                                    Console.WriteLine();
                                }
                            }

                            ConsoleOperation.EndOfRecord();
                        }
                        break;
                    default:
                        Console.WriteLine("Не коректный выбор действия");
                        break;
                }

                Console.WriteLine("Хотите продолжить Y/N");
                key = Console.ReadKey();

            } while (key.Key == ConsoleKey.Y);
        }

        /// <summary>
        /// Добавление записи
        /// </summary>
        private void AddEntry()
        {
            ConsoleOperation.DataEntryPerson(ref this._person);

            ConsoleKeyInfo key;

            // Создание и заполнение адресов
            do
            {
                this._addresses.Add(new Address());
                ConsoleOperation.DateEntryAddress( this._addresses[_addresses.Count - 1]);

                Console.WriteLine("Хотите продолжить запись адресов Y/N");
                key = Console.ReadKey();

            } while (key.Key == ConsoleKey.Y);

            // Создание и заполнение телефонных номеров
            do
            {
                this._phones.Add(new Phones());
                ConsoleOperation.DateEntryPhones(this._phones[_phones.Count - 1]);

                Console.WriteLine("хотите продолжить запись телефонных номеров Y/N");
                key= Console.ReadKey();

            } while (key.Key == ConsoleKey.Y);
        }
    }
}
