using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    /// <summary>
    /// Класс телефон
    /// </summary>
    internal class Phones
    {
        #region Поля

        private string _mobilePhone;  // Мобильный телефон
        private string _flatPhone;  // Домашний телефон

        #endregion

        #region Свойства

        /// <summary>
        /// Мобильный телефон
        /// </summary>
        public string MobilePhone
        {
            get { return _mobilePhone; }
            set { _mobilePhone = value; }
        }

        /// <summary>
        /// Домашний телефон
        /// </summary>
        public string FlatPhone
        {
            get { return _flatPhone; }
            set { _flatPhone = value; }
        }

        #endregion
    }
}
