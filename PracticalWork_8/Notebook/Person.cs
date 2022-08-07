using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    internal class Person
    {
        #region Поля

        private string _lastName;     // Фамилия
        private string _firstName;    // Имя
        private string _patronumic;   // Отчество

        #endregion

        #region Своиства

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        /// <summary>
        /// Отчество
        /// </summary>
        public string Patronumic
        {
            get { return _patronumic; }
            set { _patronumic = value;}
        }

        #endregion
    }
}
