/*
 Создайте справочник «Сотрудники».

Разработайте для предполагаемой компании программу,
которая будет добавлять записи новых сотрудников в файл. 
Файл должен содержать следующие данные:

ID
Дату и время добавления записи
Ф. И. О.
Возраст
Рост
Дату рождения
Место рождения
Для этого необходим ввод данных с клавиатуры. После ввода данных:

если файла не существует, его необходимо создать; 
если файл существует, то необходимо записать данные сотрудника в конец файла. 
При запуске программы должен быть выбор:

введём 1 — вывести данные на экран;
введём 2 — заполнить данные и добавить новую запись в конец файла.


Файл должен иметь следующую структуру:

1#20.12.2021 00:12#Иванов Иван Иванович#25#176#05.05.1992#город Москва
2#15.12.2021 03:12#Алексеев Алексей Иванович#24#176#05.11.1980#город Томск
 */

using System;

namespace EmployeeHandbook
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.KeyboardInput();
            Filling(employee);
        }

        /// <summary>
        /// Запись в файл
        /// </summary>
        /// <param name="employee">Сотрудник</param>
        static void Filling(Employee employee)
        {
            string text =
                $"{employee._id}#{employee._date}#" +
                $"{employee._lastName}#{employee._firstName}#" +
                $"{employee._patronumic}#{employee._age}#" +
                $"{employee._growth}#{employee._birthDate}#" +
                $"{employee._birthPlace}";

            FileStream fs = new FileStream("EmployeeHandbook.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(text);
            sw.Close();
        }
    }
}