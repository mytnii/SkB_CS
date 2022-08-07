using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    /// <summary>
    /// Класс Записная книжка
    /// </summary>
    internal class NoteBook
    {
        #region Поля

        private Person _person;           // Человек
        private List<Address> _addresses; // Список адресов
        private List<Phones> _phones;     // Список телефонных номеров

        #endregion

        #region Конструкторы

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public NoteBook()
        {
            _person = new Person();
            _addresses = new List<Address>();
            _phones = new List<Phones>();
        }
        #endregion
    }
}
