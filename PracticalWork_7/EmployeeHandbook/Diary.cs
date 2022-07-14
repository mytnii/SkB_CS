using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeHandbook
{
    /// <summary>
    /// Класс ежедневник
    /// </summary>
    internal class Diary
    {
       public List<Employee> employees; // Список сотрудников


        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Diary()
        {
            employees = new List<Employee>();
        }

        /// <summary>
        /// Список сотрудников из файла
        /// </summary>
        /// <param name="file">Имя файла</param>
        public void  DiaryAddFile (string file)
        {
            string[] str = FileHandling.FileReading(ref file);
            for (int i = 0; i < str.Length; i++)
            {
                this.employees.Add(new Employee(str[i]));
            }
        }

        /// <summary>
        /// Добавление сотрудника
        /// </summary>
        public void EmployeesAdd()
        {
            this.employees.Add(new Employee());
            this.employees[employees.Count - 1].KeyboardInput();

        }

        /// <summary>
        /// Просмотр записи
        /// </summary>
        /// <param name="id">Номер записи</param>
        /// <param name="file">Имя файла</param>
        public void RecordView()
        {
            int ID;
            int.TryParse(ConsoleOperation.RecordNumber(), out ID);
            Console.WriteLine(ID);
            Console.WriteLine(this.employees.Count);

            if (this.employees.Count >= ID && ID != 0)
            {
                ConsoleOperation.TablePrint();
                ConsoleOperation.PrintEmployee(this.employees[ID - 1]);
            }
            else
            {
                Console.WriteLine("Записи с таким номером нету");
            }
        }

    }
}
