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
        /// Сортировка по фамилии
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


    }
}
