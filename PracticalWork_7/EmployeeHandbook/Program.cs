/*
 * Улучшите программу, которую разработали в модуле 6. 
 * Создайте структуру «Сотрудник» со следующими полями:

ID
Дата и время добавления записи
Ф.И.О.
Возраст
Рост
Дата рождения
Место рождения


Для записей реализуйте следующие функции:

Просмотр записи. Функция должна содержать параметр ID записи, которую необходимо вывести на экран. 
Создание записи.
Удаление записи.
Редактирование записи.
Загрузка записей в выбранном диапазоне дат.
Сортировка по возрастанию и убыванию даты.


После всех изменений записей создайте метод перезаписи изменённых данных в файл в таком виде:

1#20.12.2021 00:12#Иванов Иван Иванович#25#176#05.05.1992#город Москва

2#15.12.2021 03:12#Алексеев Алексей Иванович#24#176#05.11.1980#город Томск

…


 */

using System;

namespace EmployeeHandbook
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Menu();
        }

        static void Menu()
        {
            string file = "employee.txt";

            Console.WriteLine("Для запуска меню нажмите Enter");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                do
                {
                    Console.Clear();

                    Console.WriteLine("Выберите действие");
                    Console.WriteLine("1 - вывести данные на экран");
                    Console.WriteLine("2 - заполнить данные и добавить новую запись");

                    byte size;
                    byte.TryParse(Console.ReadLine(), out size);

                    switch (size)
                    {
                        case 0:
                            Console.WriteLine("Не верный выбор действия");

                            continue;
                        case 1:

                            List<Employee> employees = Employee.ListOfEmployees(file);
                            ConsoleOperation.TablePrint();
                            for (int i = 0; i < employees.Count; i++)
                            {
                                ConsoleOperation.PrintEmployee(employees[i]);
                            }
                            break;
                        case 2:
                            Employee employee = new Employee();
                            employee.KeyboardInput();
                            FileHandling.Filling(ref employee, ref file);
                            break;
                    }

                    Console.WriteLine("Хотите продолжить Y/N");

                    key = Console.ReadKey();

                    Console.WriteLine();

                } while (key.Key == ConsoleKey.Y);
            }

            Console.WriteLine("До свидания");
        }
    }
}
