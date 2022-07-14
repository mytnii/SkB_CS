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
        /// Конструктор с одним параметром
        /// </summary>
        /// <param name="file">Имя файла</param>
        public  Diary (string file)
        {
            string[] str = FileHandling.FileReading(ref file);
            for (int i = 0; i < str.Length; i++)
            {
                employees.Add(new Employee(str[i]));
            }
        }
    }
}
