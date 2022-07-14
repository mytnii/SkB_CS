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
        public static void PrintEmployee(Employee employee)
        {
            TextColorChange();
            Console.Write($"{employee.id,4}");
            TextColorChange();
            Console.Write($"{employee.date,20}");
            TextColorChange();
            Console.Write($"{employee.lastName,15}");
            TextColorChange();
            Console.Write($"{employee.firstName,10}");
            TextColorChange();
            Console.Write($"{employee.patronumic,15}");
            TextColorChange();
            Console.Write($"{employee.age,8}");
            TextColorChange();
            Console.Write($"{employee.growth,4}");
            TextColorChange();
            Console.Write($"{employee.brithDate,20}");
            TextColorChange();
            Console.Write($"{employee.brithPlace,15}");
            TextColorChange();
            Console.WriteLine();
            EndOfRecord();

        }


        /// <summary>
        /// Печать таблици в консоль
        /// </summary>
        public static void TablePrint()
        {
            EndOfRecord();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine
                (
                $"|{Employees.ID,4}|" +
                $"{Employees.Создание_записи,20}|" +
                $"{Employees.Фамилия,15}|" +
                $"{Employees.Имя,10}|" +
                $"{Employees.Отчество,15}|" +
                $"{Employees.Возраст,8}|" +
                $"{Employees.Рост,4}|" +
                $"{Employees.Дата_рождения,20}|" +
                $"{Employees.Место_рождения,15}|"
                );
            EndOfRecord();
            Console.ResetColor();
        }

        /// <summary>
        /// Просмотр записи
        /// </summary>
        /// <param name="id">Номер записи</param>
        /// <param name="file">Имя файла</param>
        public static void RecordView(ref string file)
        {

            int ID;
            Diary employees = new Diary(file);
            int.TryParse(ConsoleOperation.RecordNumber(), out ID);

            if(employees.employees.Count >= ID && ID != 0)
            {
                ConsoleOperation.TablePrint();
                ConsoleOperation.PrintEmployee(employees.employees[ID - 1]);
            }
            else
            {
                Console.WriteLine("Записи с таким номером нету");
            }
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
               "|----|--------------------|---------------|----------|---------------|--------|----|--------------------|---------------|"
               );
            Console.ResetColor();
        }

        /// <summary>
        /// Ввод фамили сотрудника
        /// </summary>
        /// <returns>Фамилия сотрудника</returns>
        public static string EmployeeLastName()
        {
            string lastName;

            do
            {
                Console.WriteLine("Введите фамилию");
                lastName = Console.ReadLine();

                if (lastName.Length == 0)
                {
                    Console.WriteLine("Фамилия не введена\n");
                }
            } while (lastName.Length == 0);

            return lastName;
        }

        /// <summary>
        /// Ввод имени сотрудника
        /// </summary>
        /// <returns>Имя сотрудника</returns>
        public static string EmployeeFirstName()
        {
            string firstName;

            do
            {
                Console.WriteLine("Введите имя");
                firstName = Console.ReadLine();

                if (firstName.Length == 0)
                {
                    Console.WriteLine("Имя не введено\n");
                }
            } while (firstName.Length == 0);

            return firstName;
        }

        /// <summary>
        /// Ввод отчества сотрудника
        /// </summary>
        /// <returns>Отчество сотрудника</returns>
        public static string EmployeePatronumic()
        {
            string patronumic;

            do
            {
                Console.WriteLine("Введите отчество");
                patronumic = Console.ReadLine();

                if (patronumic.Length == 0)
                {
                    Console.WriteLine("Отчество не введено\n");
                }
            } while (patronumic.Length == 0);

            return patronumic;
        }

        /// <summary>
        /// Ввод роста сотрудника
        /// </summary>
        /// <returns>Рост сотрудника</returns>
        public static int EmployeeGrowth()
        {
            int growth;

            do
            {
                Console.WriteLine("Введите рост");
                int.TryParse(Console.ReadLine(), out growth);

                if (growth == 0)
                {
                    Console.WriteLine("Рост не введен\n");
                }
            } while (growth == 0);

            return growth;
        }

        /// <summary>
        /// Ввод даты рождения сотрудника
        /// </summary>
        /// <returns>Дата рождения</returns>
        public static DateTime EmployeeBrithDate()
        {
            DateTime brithDate;

            do
            {
                Console.WriteLine("Введите дату рождения");
                DateTime.TryParse(Console.ReadLine(), out brithDate);

                if (brithDate.Year == 0)
                {
                    Console.WriteLine("Дата рождения не введена");
                }
            } while (brithDate.Year == 0);

            return brithDate;

        }

        /// <summary>
        /// Ввод места рождения
        /// </summary>
        /// <returns>Место рождения</returns>
        public static string EmployeeBrithPlace()
        {
            string brithPlace;
            do
            {
                Console.WriteLine("Введите место рождения");
                brithPlace = Console.ReadLine();

                if (brithPlace.Length == 0)
                {
                    Console.WriteLine("Место рождения не введено");
                }
            } while (brithPlace.Length == 0);

            return brithPlace;
        }

        /// <summary>
        /// Ввод номера записи
        /// </summary>
        /// <returns>Номер записи</returns>
        public static string RecordNumber()
        {
            Console.WriteLine("Введите номер записи");
            return Console.ReadLine();
        }
    }
}
