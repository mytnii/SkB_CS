﻿using System;
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
        }
    }
}
