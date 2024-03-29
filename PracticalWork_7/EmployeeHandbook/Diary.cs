﻿using System;
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


        /// <summary>
        /// Редактирование записи
        /// </summary>
        /// <param name="file">Имя файла</param>
        /// <param name="id">Номер записи</param>
        public void RecordEditing(ref string file)
        {
            int ID;
            int.TryParse(ConsoleOperation.RecordNumber(), out ID);

            if (this.employees.Count >= ID && ID != 0)
            {
                Console.WriteLine("Выберете что нужно отредактировать");
                Console.WriteLine("1 - Фамилия");
                Console.WriteLine("2 - Имя");
                Console.WriteLine("3 - Отчество");
                Console.WriteLine("4 - Рост");
                Console.WriteLine("5 - Дата рождения");
                Console.WriteLine("6 - Место рождения");

                int value;
                int.TryParse(Console.ReadLine(), out value);

                int size = ID - 1;

                switch (value)
                {
                    case 0:
                        Console.WriteLine("Некоректный выбор");
                        break;
                    case 1:
                        this.employees[size].lastName = ConsoleOperation.EmployeeLastName();
                        break;
                    case 2:
                        this.employees[size].firstName = ConsoleOperation.EmployeeFirstName();
                        break;
                    case 3:
                        this.employees[size].patronumic = ConsoleOperation.EmployeePatronumic();
                        break;
                    case 4:
                        this.employees[size].growth = ConsoleOperation.EmployeeGrowth();
                        break;
                    case 5:
                        do
                        {
                            this.employees[size].brithDate = ConsoleOperation.EmployeeBrithDate();
                            if (this.employees[size].brithDate.Year > this.employees[size].date.Year)
                            {
                                Console.WriteLine("Не коректный ввод даты рождения ");
                            }

                        } while (this.employees[size].date.Year < this.employees[size].brithDate.Year);

                        this.employees[size].age = this.employees[size].date.Year - this.employees[size].brithDate.Year;
                        if (this.employees[size].date.Month > this.employees[size].brithDate.Month)
                        {
                            this.employees[size].age--;
                        }
                        break;
                    case 6:
                        this.employees[size].brithPlace = ConsoleOperation.EmployeeBrithPlace();
                        break;
                }

                FileHandling.OverwriteFile(ref this.employees, ref file);

            }
            else
            {
                Console.WriteLine("Записи с таким номером нет");
            }
        }

        /// <summary>
        /// Удаление записи
        /// </summary>
        /// <param name="file">Имя файла</param>
        /// <param name="id">Номер записи</param>
        public void RecordDeletion( ref string file)
        {
            int ID;
            int.TryParse(ConsoleOperation.RecordNumber(), out ID);

            if (this.employees.Count >= ID && ID != 0)
            {
                for (int i = ID; i < this.employees.Count; i++)
                {
                    this.employees[i].id = i;
                }

                this.employees.RemoveAt(ID - 1);

                FileHandling.OverwriteFile(ref this.employees, ref file);

            }
            else
            {
                Console.WriteLine("Записи с таким номером нет");
            }
        }

        /// <summary>
        /// Сортировка по номеру записи
        /// </summary>
        public void SortById()
        {
            Employee employee = new Employee();

            for(int i = 0; i < this.employees.Count; i++)
            {
                for(int j = i; j < this.employees.Count; j++)
                {
                    if(this.employees[i].id > this.employees[j].id)
                    {
                        employee = this.employees[i];
                        this.employees[i] = this.employees[j];
                        this.employees[j] = employee;
                    }
                }
            }
        }

        /// <summary>
        /// Сортировка по дате добавления
        /// </summary>
        public void DateSorting()
        {
            Employee employee = new Employee();

            for(int i = 0; i < this.employees.Count; i++)
            {
                for(int j = i; j < this.employees.Count; j++)
                {
                    if(this.employees[i].date > this.employees[j].date)
                    {
                        employee = this.employees[i];
                        this.employees[i] = this.employees[j];
                        this.employees[j] = employee;
                    }
                }
            }
        }

        /// <summary>
        /// Сортировка по Фамилии
        /// </summary>
        public void SortingByLastName()
        {
            Employee employee = new Employee();

            for(int i = 0; i < this.employees.Count; i++)
            {
                for(int j = i; j < this.employees.Count; j++)
                {
                    if(string.Compare(this.employees[i].lastName, this.employees[j].lastName) > 0)
                    {
                        employee = this.employees[i];
                        this.employees[i] = this.employees[j];
                        this.employees[j]= employee;
                    }
                }
            }
        }

        /// <summary>
        /// Сортировка по Имени
        /// </summary>
        public void SortingByFirstName()
        {
            Employee employee = new Employee();

            for (int i = 0; i < this.employees.Count; i++)
            {
                for (int j = i; j < this.employees.Count; j++)
                {
                    if (string.Compare(this.employees[i].firstName, this.employees[j].firstName) > 0)
                    {
                        employee = this.employees[i];
                        this.employees[i] = this.employees[j];
                        this.employees[j] = employee;
                    }
                }
            }
        }

        /// <summary>
        /// Сортировка по Отчеству
        /// </summary>
        public void SortingByPatronumic()
        {
            Employee employee = new Employee();

            for (int i = 0; i < this.employees.Count; i++)
            {
                for (int j = i; j < this.employees.Count; j++)
                {
                    if (string.Compare(this.employees[i].patronumic, this.employees[j].patronumic) > 0)
                    {
                        employee = this.employees[i];
                        this.employees[i] = this.employees[j];
                        this.employees[j] = employee;
                    }
                }
            }
        }

        /// <summary>
        /// Сортировка по росту
        /// </summary>
        public void SortByHeight()
        {
            Employee employee = new Employee();

            for (int i = 0; i < this.employees.Count; i++)
            {
                for (int j = i; j < this.employees.Count; j++)
                {
                    if (this.employees[i].growth > this.employees[j].growth)
                    {
                        employee = this.employees[i];
                        this.employees[i] = this.employees[j];
                        this.employees[j] = employee;
                    }
                }
            }
        }

        /// <summary>
        /// Сортировка по дате рождения
        /// </summary>
        public void BrithDateSorting()
        {
            Employee employee = new Employee();

            for (int i = 0; i < this.employees.Count; i++)
            {
                for (int j = i; j < this.employees.Count; j++)
                {
                    if (this.employees[i].brithDate > this.employees[j].brithDate)
                    {
                        employee = this.employees[i];
                        this.employees[i] = this.employees[j];
                        this.employees[j] = employee;
                    }
                }
            }
        }

        /// <summary>
        /// Сортировка по месту рождения
        /// </summary>
        public void SortingByBrithPlace()
        {
            Employee employee = new Employee();

            for (int i = 0; i < this.employees.Count; i++)
            {
                for (int j = i; j < this.employees.Count; j++)
                {
                    if (string.Compare(employees[i].brithPlace, employees[j].brithPlace) > 0)
                    {
                        employee= this.employees[i];
                        this.employees[i] = employees[j];
                        this.employees[j] = employee;
                    }
                }
            }
        }

        /// <summary>
        /// Меню сортировки
        /// </summary>
        public void SortMenu()
        {
            Console.WriteLine("Выберете поле по которому нужно отсортировать");
            ConsoleOperation.MenuDesign();

            string str = Console.ReadLine();

            ConsoleKeyInfo key;

            switch (str)
            {
                case "1":
                    Console.WriteLine("По возрастанию Y/N");
                    key = Console.ReadKey();
                    this.SortById();
                    if(key.Key == ConsoleKey.N)
                    {
                        this.employees.Reverse();
                    }
                    break;
                case "2":
                    Console.WriteLine("По возрастанию Y/N");
                    key = Console.ReadKey();
                    this.DateSorting();
                    if (key.Key == ConsoleKey.N)
                    {
                        this.employees.Reverse();
                    }
                    break;
                case "3":
                    Console.WriteLine("По возрастанию Y/N");
                    key = Console.ReadKey();
                    this.SortingByLastName();
                    if (key.Key == ConsoleKey.N)
                    {
                        this.employees.Reverse();
                    }
                    break;
                case "4":
                    Console.WriteLine("По возрастанию Y/N");
                    key = Console.ReadKey();
                    this.SortingByFirstName();
                    if (key.Key == ConsoleKey.N)
                    {
                        this.employees.Reverse();
                    }
                    break;
                case "5":
                    Console.WriteLine("По возрастанию Y/N");
                    key = Console.ReadKey();
                    this.SortingByPatronumic();
                    if (key.Key == ConsoleKey.N)
                    {
                        this.employees.Reverse();
                    }
                    break;
                case "6":
                    Console.WriteLine("По возрастанию Y/N");
                    key = Console.ReadKey();
                    this.SortByHeight();
                    if (key.Key == ConsoleKey.N)
                    {
                        this.employees.Reverse();
                    }
                    break;
                case "7":
                    Console.WriteLine("По возрастанию Y/N");
                    key = Console.ReadKey();
                    this.BrithDateSorting();
                    if (key.Key == ConsoleKey.N)
                    {
                        this.employees.Reverse();
                    }
                    break;
                case "8":
                    Console.WriteLine("По возрастанию Y/N");
                    key = Console.ReadKey();
                    SortingByBrithPlace();
                    if (key.Key == ConsoleKey.N)
                    {
                        this.employees.Reverse();
                    }
                    break;
                default:
                    Console.WriteLine("Неправнльный выбор сортировки");
                    break;
            }

                    Console.WriteLine();
        }

        /// <summary>
        /// Меню вывода диапозона
        /// </summary>
        public void RangeOutputMenu()
        {
            Console.WriteLine("Выберете парамет по которому будет осуществлятся вывод");
            ConsoleOperation.MenuDesign();

            string str = Console.ReadLine();

            switch(str)
            {
                case "1":
                    this.SortById();
                    Console.WriteLine("Введите начало диапозона");
                    int startValue;
                    int.TryParse(Console.ReadLine(), out startValue);

                    Console.WriteLine("Введите конец диапозона");
                    int endValue;
                    int.TryParse(Console.ReadLine(),out endValue);

                    if(startValue == 0 || endValue == 0)
                    {
                        Console.WriteLine("Не коректный ввод диапозона");
                        break;
                    }

                    ConsoleOperation.OutputByRange(ref this.employees, startValue, endValue);
                    break;
                case "2":
                    this.DateSorting();
                    Console.WriteLine("Введите начало диапозона");
                    DateTime startDate;
                    DateTime.TryParse(Console.ReadLine(), out startDate);

                    Console.WriteLine("Введите конец диапозона");
                    DateTime endDate;
                    DateTime.TryParse(Console.ReadLine(), out  endDate);

                    if(startDate.Year == 0001 || endDate.Year == 0001)
                    {
                        Console.WriteLine("Не коректный ввод диапозона");
                        break;
                    }

                    ConsoleOperation.OutputByRangeDate(ref this.employees, startDate, endDate);
                    break;
                case "3":
                    this.SortingByLastName();
                    Console.WriteLine("Введите начало диапозона");
                    string startLastName = Console.ReadLine();

                    Console.WriteLine("Введите конец диапозона");
                    string endLastName = Console.ReadLine();

                    ConsoleOperation.OutputByRangeLastName(ref this.employees, startLastName, endLastName);
                    break;
                case "4":
                    this.SortingByLastName();
                    Console.WriteLine("Введите начало диапозона");
                    string startFirstName = Console.ReadLine();

                    Console.WriteLine("Введите конец диапозона");
                    string endFirstName = Console.ReadLine();

                    ConsoleOperation.OutputByRangeFirstName(ref this.employees, startFirstName, endFirstName);
                    break;
                case "5":
                    this.SortingByLastName();
                    Console.WriteLine("Введите начало диапозона");
                    string startPatronumic = Console.ReadLine();

                    Console.WriteLine("Введите конец диапозона");
                    string endPatronumic = Console.ReadLine();

                    ConsoleOperation.OutputByRangePatronumic(ref this.employees, startPatronumic, endPatronumic);
                    break;
                case "6":
                    this.SortById();
                    Console.WriteLine("Введите начало диапозона");
                    int startGrowth;
                    int.TryParse(Console.ReadLine(), out startGrowth);

                    Console.WriteLine("Введите конец диапозона");
                    int endGrowth;
                    int.TryParse(Console.ReadLine(), out endGrowth);

                    if (startGrowth == 0 || endGrowth == 0)
                    {
                        Console.WriteLine("Не коректный ввод диапозона");
                        break;
                    }

                    ConsoleOperation.OutputByRange(ref this.employees, startGrowth, endGrowth);
                    break;
                case "7":
                    this.DateSorting();
                    Console.WriteLine("Введите начало диапозона");
                    DateTime startBrithDate;
                    DateTime.TryParse(Console.ReadLine(), out startBrithDate);


                    Console.WriteLine("Введите конец диапозона");
                    DateTime endBrithDate;
                    DateTime.TryParse(Console.ReadLine(), out endBrithDate);

                    if (startBrithDate.Year == 0001 || endBrithDate.Year == 0001)
                    {
                        Console.WriteLine("Не коректный ввод диапозона");
                        break;
                    }

                    ConsoleOperation.OutputByRangeBrithDate(ref this.employees, startBrithDate, endBrithDate);
                    break;
                case "8":
                    this.SortingByLastName();
                    Console.WriteLine("Введите начало диапозона");
                    string startBrithPlace = Console.ReadLine();

                    Console.WriteLine("Введите конец диапозона");
                    string endBrithPlace = Console.ReadLine();

                    ConsoleOperation.OutputByRangePatronumic(ref this.employees, startBrithPlace, endBrithPlace);
                    break;
                default:
                    Console.WriteLine("Не коректный выбор параметра");
                    break;
            }

        }
    }
}
