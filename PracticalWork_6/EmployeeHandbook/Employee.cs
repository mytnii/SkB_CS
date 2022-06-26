using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeHandbook
{
    /// <summary>
    /// Класс сотрудник
    /// </summary>
    internal class Employee
    {
        public int _id;             // Номер
        public DateTime _date;      // Дата добавления записи
        public string _lastName;    // Фамилия
        public string _firstName;   // Имя
        public string _patronumic;  // Отчество
        public int _age;            // Возраст
        public int _growth;         // Рост
        public DateTime _birthDate; // Дата рождения
        public string _birthPlace;   // Место рождения

        /// <summary>
        /// Ввод данных с клавиатуры
        /// </summary>
        public void KeyboardInput()
        {
            Console.WriteLine("Введите номер");
            this._id = Convert.ToInt32(Console.ReadLine());

            this._date = DateTime.Now;

            Console.WriteLine("Введите Фамилию");
            this._lastName = Console.ReadLine();

            Console.WriteLine("Введите Имя");
            this._firstName = Console.ReadLine();

            Console.WriteLine("Введите Отчество");
            this._patronumic = Console.ReadLine();

            Console.WriteLine("Введите рост");
            this._growth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите дату рождения");
            this._birthDate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("введите место рождения");
            this._birthPlace = Console.ReadLine();
        }
    }
}
