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
        public static void RecordView(ref string id, ref string file)
        {

            int ID;
            List<Employee> employees = Employee.ListOfEmployees(file);
            int.TryParse(id, out ID);

            if(employees.Count >= ID && ID != 0)
            {
                ConsoleOperation.TablePrint();
                ConsoleOperation.PrintEmployee(employees[ID - 1]);
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
    }
}
