using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeHandbook
{
    /// <summary>
    /// Класс работа с файлом
    /// </summary>
    internal class FileHandling
    {

        /// <summary>
        /// Запись в файл
        /// </summary>
        /// <param name="employee">Сотрудник</param>
        /// <param name="file">Имя файла</param>
        public static void Filling(Employee employee, ref string file)
        {
            FileStream fs = new FileStream(file, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine
                (
                $"{employee.id}#{employee.date}#" +
                $"{employee.lastName}#{employee.firstName}#" +
                $"{employee.patronumic}#{employee.age}#" +
                $"{employee.growth}#{employee.brithDate}#" +
                $"{employee.brithPlace}"
                );
            sw.Close();
        }

        /// <summary>
        /// Чтение из файла
        /// </summary>
        /// <param name="file">Имя файла</param>
        /// <returns>Массив строк</returns>
        public static string[] FileReading(ref string file)
        {
            StreamReader sr = new StreamReader(file);

            int count = File.ReadAllLines(file).Length;

            string[] line = new string[count];

            for(int i = 0; i < count; i++)
            {
                line[i] = sr.ReadLine();
            }

            sr.Close();

            return line;
        }

        /// <summary>
        /// Удаление записи
        /// </summary>
        /// <param name="file">Имя файла</param>
        /// <param name="id">Номер записи</param>
        public static void RecordDeletion(ref string file, ref string id)
        {
            int ID;
            List<Employee> employees = Employee.ListOfEmployees(file);
            int.TryParse(id, out ID);

            if(employees.Count >= ID && ID != 0)
            {
                for(int i = ID; i < employees.Count; i++)
                {
                    employees[i].id = i;
                }

                employees.RemoveAt(ID - 1);

                FileInfo fileInfo = new FileInfo(file);
                fileInfo.Delete();
                for(int i = 0; i < employees.Count; ++i)
                {
                    Filling(employees[i], ref file);
                }
            }
            else
            {
                Console.WriteLine("Записи с таким номером нет");
            }
        }

        /// <summary>
        /// Редактирование записи
        /// </summary>
        /// <param name="file">Имя файла</param>
        /// <param name="id">Номер записи</param>
        public static void RecordEditing(ref string file, ref string id)
        {
            int ID;
            List<Employee> employees = Employee.ListOfEmployees(file);
            int.TryParse(id, out ID);

            if(employees.Count >= ID && ID != 0)
            {
                Console.WriteLine("Выберете что нужно отредактировать");
                Console.WriteLine("1 - Фамилия");
                Console.WriteLine("2 - Имя");
                Console.WriteLine("3 - Отчество");
                Console.WriteLine("4 - Рост");
                Console.WriteLine("5 - Дата рождения");
                Console.WriteLine("6 - Место рождения");

                byte value;
                byte.TryParse(Console.ReadLine(), out value);

                int size = ID - 1;

                switch(ID)
                {
                    case 0:
                        Console.WriteLine("Некоректный выбор");
                        break;
                    case 1:
                        employees[size].lastName = ConsoleOperation.EmployeeLastName();
                        break;
                    case 2:
                        employees[size].firstName = ConsoleOperation.EmployeeFirstName();
                        break;
                    case 3:
                        employees[size].patronumic = ConsoleOperation.EmployeePatronumic();
                        break;
                    case 4:
                        employees[size].growth = ConsoleOperation.EmployeeGrowth();
                        break;
                    case 5:
                        do
                        {
                            employees[size].brithDate = ConsoleOperation.EmployeeBrithDate();
                            if (employees[size].brithDate.Year > employees[size].date.Year)
                            {
                                Console.WriteLine("Не коректный ввод даты рождения ");
                            }

                        } while(employees[size].date.Year < employees[size].brithDate.Year);

                        employees[size].age = employees[size].date.Year - employees[size].brithDate.Year;
                        if (employees[size].date.Month > employees[size].brithDate.Month)
                        {
                            employees[size].age--;
                        }
                        break;
                    case 6:
                        employees[size].brithPlace = ConsoleOperation.EmployeeBrithPlace();
                        break;
                }

            }
        }
    }
}
