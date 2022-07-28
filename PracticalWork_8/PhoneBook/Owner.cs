using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class Owner
    {
        private string _lastName;    // Фамилия
        private string _firstName;   // Имя
        private string _patronumic;  // Отчество

        /// <summary>
        /// Свойства Фамилии
        /// </summary>
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        /// <summary>
        /// Свойства Имени
        /// </summary>
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        /// <summary>
        /// Свойства Отчества
        /// </summary>
        public string Patronumic
        {
            get { return _patronumic; }
            set { _patronumic = value;}
        }
    }
}
