using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeHandbook
{
    /// <summary>
    /// Работа с консолью
    /// </summary>
    internal class ConsoleOperation
    {
        public static void PrintEmployee(ref Employee employee)
        {
            Console.Write
                (
                $"№ {employee.ID}\n" +
                $"Дата добавления записи: {employee.DateTime}\n" +
                $"Фамилия: {employee.LastName}\n" +
                $"Имя: {employee.FirstName}\n" +
                $"Отчество: {employee.Patronumic}\n" +
                $"Возраст: {employee.Age}\n" +
                $"Рост: {employee.Growth}\n" +
                $"Дата рождения: {employee.BirthDate}\n" +
                $"Место рождения: {employee.BirthPlace}\n"
                );
        }
    }
}
