using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheetWork
{
    /// <summary>
    /// Класс работа с листом
    /// </summary>
    internal class WorkSheet
    {
        private List<int> _numbers; // Лист целых чисел

        public List<int> Numbers
        {
            get { return _numbers; }
        }
        public WorkSheet()
        {
            _numbers = new List<int>();
        }

        /// <summary>
        /// Заполнение листа
        /// </summary>
        public void SheetFilling()
        {
            Random random = new Random();

            for(int i = 0; i < 100; i++)
            {
                this._numbers.Add(random.Next(101));
            }
        }
    }
}
