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
                person.LastName = Console.ReadLine();

                if (person.LastName == "")
                {
                    Console.WriteLine("Фамилия не введена");
                }
            } while (person.LastName == "");

            // Ввод имени
            do
            {
                Console.WriteLine("Введите Имя");
                person.FirstName = Console.ReadLine();

                if(person.FirstName == "")
                {
                    Console.WriteLine("Имя не введено");
                }
            } while (person.FirstName == "");

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
        public static void DateEntryAddress(Address address)
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
        /// Ввод данных телефон: номер мобильного телефона, номер домашнего телефона
        /// </summary>
        /// <param name="phones">Телефон</param>
        public static void DateEntryPhones(Phones phones)
        {
            // Ввод номера мобилного телефона
            do
            {
                Console.WriteLine("Введите Мобильный номер телефона");
                Console.WriteLine("Если нет мобильного номера телефона то введите -");
                phones.MobilePhone = Console.ReadLine();
                long mobilePhone;
                long.TryParse(phones.MobilePhone, out mobilePhone);
                if(phones.MobilePhone != "-" && mobilePhone == 0)
                {
                    Console.WriteLine("Некоректный ввод номера телефона");
                }
                else
                {
                    break;
                }

            } while (true);

            // Ввод домашнего номера телефона
            do
            {
                bool flag = true;
                Console.WriteLine("Введите домашний номер телефона");
                Console.WriteLine("Если нет домашнего телефона то введите -");
                phones.FlatPhone = Console.ReadLine();


                for(int i = 0; i < phones.FlatPhone.Length; i++)
                {
                    if(phones.FlatPhone[i] != '-' && !(char.IsDigit(phones.FlatPhone[i])))
                    {
                        flag = false;
                        Console.WriteLine("Некоректный ввод номера телефона");
                        break;
                    }
                }

                if (phones.FlatPhone == "")
                {
                    Console.WriteLine("Некоректный ввод номера телефона");
                    flag = false;
                }

                if(flag = true)
                {
                    return;
                }
            } while (true);
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
                $"{ContentsTables.First_name,15}|" +
                $"{ContentsTables.Patronumic,15}|" +
                $"{ContentsTables.Street,15}|" +
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
                "|---------------|---------------|---------------" +
                "|---------------|---------------|---------------" +
                "|---------------|---------------|"
                );
            Console.ResetColor();
        }

        /// <summary>
        /// Печать Фамилии Имени и Отчества чеовека
        /// </summary>
        /// <param name="person">Человек</param>
        public static void PrintPerson(ref Person person)
        {
            ColorChangeConsole();
            Console.Write($"{person.LastName,15}");
            ColorChangeConsole();
            Console.Write($"{person.FirstName,15}");
            ColorChangeConsole();
            Console.Write($"{person.Patronumic,15}");
            ColorChangeConsole();
        }

        /// <summary>
        /// Печать адреса в консоль
        /// </summary>
        /// <param name="address">Адрес</param>
        public static void PrintAddress( Address address)
        {
            Console.Write($"{address.Street,15}");
            ColorChangeConsole();
            Console.Write($"{address.HouseNumber,15}");
            ColorChangeConsole();
            Console.Write($"{address.FlatNumber,15}");
            ColorChangeConsole();
        }

        /// <summary>
        /// Печать телефонных номеров в консоль
        /// </summary>
        /// <param name="phones">Номера телефонов</param>
        public static void PrintPhones( Phones phones)
        {
            Console.Write($"{phones.MobilePhone,15}");
            ColorChangeConsole();
            Console.Write($"{phones.FlatPhone,15}");
            ColorChangeConsole();
        }

        /// <summary>
        /// Печать пустых значений
        /// </summary>
        public static void PrintBlankValues(int value)
        {
            for (int i = 0; i < value; i++)
            {
                Console.Write("               ");
                ColorChangeConsole();
            } 
        }

        /// <summary>
        /// Изменение цвета в консоли
        /// </summary>
        public static void ColorChangeConsole()
        {
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.Write("|");
            Console.ResetColor();
        }

        #endregion
    }
}
