﻿/*
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
            
            string file = "EmployeeHandbook.txt";

            SelectionMenu(file);
        }

       /// <summary>
       /// Запись в файл
       /// </summary>
       /// <param name="employee">Сотрудник</param>
       /// <param name="file">Имя файла</param>
        static void Filling(Employee employee, string file)
        {
            string text =
                $"{employee._id}#{employee._date}#" +
                $"{employee._lastName}#{employee._firstName}#" +
                $"{employee._patronumic}#{employee._age}#" +
                $"{employee._growth}#{employee._birthDate}#" +
                $"{employee._birthPlace}";

            FileStream fs = new FileStream(file, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(text);
            sw.Close();

            
        }
    
        

        /// <summary>
        /// Чтение из файла
        /// </summary>
        /// <param name="file">Имя файла</param>
        /// <returns>Массив строк</returns>
        static string[] ReadFromFile(string file)
        {
            StreamReader sr = new StreamReader(file);

            int count = File.ReadAllLines
                (
                file
                ).Length;

            string[] line = new string[count];
            for(int i = 0; i < count; ++i)
            {
                line[i] = sr.ReadLine();
            }

            sr.Close();

            return line;
        }

        /// <summary>
        /// Печать на экран
        /// </summary>
        /// <param name="file">Имя файла</param>
        static void PrintEmployees(string file)
        {
            string[] str = ReadFromFile(file);
            string[] employe;

            for(int i = 0; i < str.Length; ++i)
            {
                employe = str[i].Split('#').ToArray();

                foreach(string employee in employe)
                {
                    Console.WriteLine(employee);
                }
                Console.WriteLine("----------------------------------");
            }
        }

        /// <summary>
        /// Мени
        /// </summary>
        /// <param name="file">Имя файла</param>
        static void SelectionMenu(string file)
        {

            ConsoleKeyInfo key;
            do
            {
                Console.WriteLine("Выбирите действие");
                Console.WriteLine("1 - вывести данные на экран");
                Console.WriteLine("2 - Заполнить данные и добавить новую запись");

                byte size = Convert.ToByte(Console.ReadLine());
                switch (size)
                {
                    case 1:
                        if (File.Exists(file))
                            PrintEmployees(file);
                        break;
                    case 2:
                        Employee employee = new Employee();
                        employee.KeyboardInput();
                        Filling(employee, file);
                        break;
                }

                Console.WriteLine("Хотите продолжить Y/N");
                key = Console.ReadKey();

                Console.WriteLine();
            } while (key.Key == ConsoleKey.Y);

            Console.WriteLine("До свидания");
        }
    }
}