using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    /// <summary>
    /// Телефонная книга
    /// </summary>
    internal class PhoneBook
    {
       private List<Dictionary<string, Owner>> _phoneBook;

        public PhoneBook()
        {
            this._phoneBook = new List<Dictionary<string,Owner>>();
        }
    }
}
