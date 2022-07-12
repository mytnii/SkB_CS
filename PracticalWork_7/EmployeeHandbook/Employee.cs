using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeHandbook
{
    /// <summary>
    /// Класс Сотрудник
    /// </summary>
    internal class Employee
    {
        public int id;                  // Номер записи
        public DateTime date;           // Дата создания записи
        public string lastName;        // Фамилия сотрудника
        public string firstName;       // Имя сотрудника
        public string patronumic;      // Отчество сотрудника
        public int age;                 // Возраст сотрудника
        public int growth;              // Рост сотрудника
        public DateTime brithDate;      // Дата рождения сотрудника
        public string brithPlace;      // Место рождения сотрудника

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Employee()
        { }

        /// <summary>
        /// Конструктор с одним параметром
        /// </summary>
        /// <param name="str">строка</param>
        public Employee(string str)
        {
            string[] employee = str.Split('#').ToArray();
            this.id = int.Parse(employee[0]);
            this.date = DateTime.Parse(employee[1]);
            this.lastName = employee[2];
            this.firstName = employee[3];
            this.patronumic = employee[4];
            this.age = int.Parse(employee[5]);
            this.growth = int.Parse(employee[6]);
            this.brithDate = DateTime.Parse(employee[7]);
            this.brithPlace = employee[8];
        }
        /// <summary>
        /// Ввод данных о сотруднике с клавиатуры
        /// </summary>
        public void KeyboardInput()
        {
            // Ввод номера сотрудника
            do
            {
                Console.WriteLine("Введите номер");
                int.TryParse(Console.ReadLine(), out this.id);

                if(this.id == 0)
                {
                    Console.WriteLine("Номер не введен\n");
                }
            } while (this.id == 0);

            // Дата создания записи
            this.date = DateTime.Now;

            // Ввод Фамилии сотрудника
            this.lastName = ConsoleOperation.EmployeeLastName();

            // Ввод Имени сотрудника
            this.firstName = ConsoleOperation.EmployeeFirstName();

            // Ввод отчества сотрудника
            do
            {
                Console.WriteLine("Введите отчество");
                this.patronumic = Console.ReadLine();

                if(this.patronumic.Length == 0)
                {
                    Console.WriteLine("Отчество не введено\n");
                }
            }while(this.patronumic.Length == 0);

            // Ввод роста сотрудника
            do
            {
                Console.WriteLine("Введите рост");
                int.TryParse(Console.ReadLine(), out this.growth);

                if(growth == 0)
                {
                    Console.WriteLine("Рост не введен\n");
                }
            } while (growth == 0);

            // Ввод даты рождения сотрудника
            do
            {
                Console.WriteLine("Введите дату рождения");
                DateTime.TryParse(Console.ReadLine(), out brithDate);

                if(brithDate.Year == 0)
                {
                    Console.WriteLine("Дата рождения не введена");
                }
                if(brithDate.Year > date.Year)
                {
                    Console.WriteLine("Не коректный ввод даты рождения ");
                    continue;
                }
            }while(brithDate.Year == 0);

            // Ввод места рождения сотрудника
            do
            {
                Console.WriteLine("Введите место рождения");
                this.brithPlace = Console.ReadLine();

                if(brithPlace.Length == 0)
                {
                    Console.WriteLine("Место рождения не введено");
                }
            } while (this.brithPlace.Length == 0);

            // Возраст сотрудника
            this.age = this.date.Year - this.brithDate.Year;
            if(date.Month > brithDate.Month)
            {
                this.age--;
            }
        }

      


        /// <summary>
        /// Список сотрудников из файла
        /// </summary>
        /// <param name="file">Имя файла</param>
        /// <returns>Список сотрудников</returns>
        public static List<Employee> ListOfEmployees( string file)
        {
            string[] str = FileHandling.FileReading(ref file);

            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < str.Length; i++)
            {
                employees.Add(new Employee(str[i]));
            }
            return employees;
        }
    }
}
