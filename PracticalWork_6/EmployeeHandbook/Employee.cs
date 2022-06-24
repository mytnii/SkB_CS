using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeHandbook
{
    /// <summary>
    /// Сотрудник
    /// </summary>
    internal class Employee
    {
        private int _ID;   // Номер
        private DateTime _dateTime;  // Дата и время добавления записи
        private string? _lastName; // Фамилия
        private string? _firstName;  // Имя
        private string? _patronumic;  // Отчество
        private int _growth;  // Рост
        private int _age;  // Возраст
        private DateTime _birthDate; // Дата рождения
        private string? _birthPlace; // Место рождения

        /// <summary>
        /// Чтение номера
        /// </summary>
        public int ID
        {
            get { return _ID; }
        }

        /// <summary>
        /// Чтение даты добавления записи
        /// </summary>
        public DateTime DateTime
        {
            get { return _dateTime; }
        }

        /// <summary>
        /// Чтение и запись Фамилии
        /// </summary>
        public string? LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        /// <summary>
        /// Чтение и запись Имени
        /// </summary>
        public string? FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        /// <summary>
        /// Чтение и запись Отчества
        /// </summary>
        public string? Patronumic
        {
            get { return _patronumic; }
            set { _patronumic = value;}
        }

        /// <summary>
        /// Чтение и запись роста
        /// </summary>
        public int Growth
        {
            get { return _growth; }
            set { _growth = value; }
        }

        /// <summary>
        /// Чтение возраста
        /// </summary>
        public int Age
        {
            get { return _age; }
        }

        /// <summary>
        /// Чтение даты рождения
        /// </summary>
        public DateTime BirthDate
        {
            get { return _birthDate; }
        }

        /// <summary>
        /// Чтение места рождения
        /// </summary>
        public string? BirthPlace
        {
            get { return _birthPlace; }
        }

        /// <summary>
        /// Создание сотрудника
        /// </summary>
        /// <param name="id">Номер</param>
        /// <param name="dateTime">Дата добавления записи</param>
        /// <param name="lastName">Фамилия</param>
        /// <param name="firstName">Имя</param>
        /// <param name="patronumic">Отчество</param>
        /// <param name="growth">Рост</param>
        /// <param name="birthDate">Дата рождения</param>
        /// <param name="birthPlace">Место рождения</param>
        public Employee
            (
            int id, string lastName,
            string firstName, string patronumic,
            int growth, DateTime birthDate, string birthPlace
            )
        {
            this._ID = id;
            this._dateTime = DateTime.Now;
            this._lastName = lastName;
            this._firstName = firstName;
            this._patronumic = patronumic;
            this._growth = growth;
            this._age = AgeMatching(_dateTime, birthDate);
            this._birthDate = birthDate;
            this._birthPlace = birthPlace;
        }

        /// <summary>
        /// вычисление возраста
        /// </summary>
        /// <param name="dateTime">Дата</param>
        /// <param name="birthDate">Дата рождения</param>
        /// <returns>Возраст</returns>
        private static int AgeMatching(DateTime dateTime, DateTime birthDate)
        {
            int rezult = (int)dateTime.Year - birthDate.Year;

            if(dateTime.Month < birthDate.Month)
            {
                --rezult;
            }
            return rezult;
        }
    }
}
