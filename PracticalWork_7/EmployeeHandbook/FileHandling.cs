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
        public static void Filling(ref Employee employee, ref string file)
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
    }
}
