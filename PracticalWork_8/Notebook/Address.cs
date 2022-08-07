using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    /// <summary>
    /// Класс адрес
    /// </summary>
    internal class Address
    {
        #region Поля

        private string _street;      // Название улици
        private int _houseNumber;    // Номер дома
        private int _flatNumber;     // Номер квартиры

        #endregion

        #region Свойства

        /// <summary>
        /// Название улици
        /// </summary>
        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }

        /// <summary>
        /// Номер дома
        /// </summary>
        public int HouseNumber
        {
            get { return _houseNumber; }
            set { _houseNumber = value; }
        }

        /// <summary>
        /// Номер квартиры
        /// </summary>
        public int FlatNumber
        {
            get { return _flatNumber; }
            set { _flatNumber = value; }
        }

        #endregion
    }
}
