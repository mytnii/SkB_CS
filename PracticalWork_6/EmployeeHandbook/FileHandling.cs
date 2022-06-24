using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeHandbook
{
    /// <summary>
    /// Работа с файлом
    /// </summary>
    internal class FileHandling
    {
        public static void Filling(Employee employee)
        {
            string text =
                $"{employee.ID}#" +
                $"{employee.DateTime}#" +
                $"{employee.LastName}#" +
                $"{employee.FirstName}#" +
                $"{employee.Patronumic}" +
                $"{employee.Age}#" +
                $"{employee.Growth}#" +
                $"{employee.BirthDate}#" +
                $"{employee.BirthPlace}";

            FileStream fs = new FileStream("EmployeeHandbook.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(text);
            sw.Close();
        }
    }
}
