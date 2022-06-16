/*
 * Объявите несколько переменных, которые будут хранить следующие значения:

Ф. И. О.
Возраст
Email
Баллы по программированию
Баллы по математике
Баллы по физике
 

Каждая переменная должна иметь:

название, что-либо обозначающее на английском языке;
тип данных, который наилучшим образом подходит для этой переменной. 
Например, для Ф.И.О. можно указать наименование переменной FullName. 
Дальше выведите всю информацию на экран. Организуйте форматированный вывод данных на экран. 


Cоздайте две переменные для подсчёта суммы баллов по всем предметам
и рассчитайте среднее арифметическое значение. Для этого:

Создайте переменную под сумму баллов по всем предметам.
Посчитайте сумму баллов.
Создайте переменную под средний балл.
Рассчитайте среднее арифметическое баллов.
Выведите информацию на экран.
 */

using System;

namespace ArithmeticMean
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Фамилия?");
            string? lastName = Console.ReadLine(); // Фамилия

            // Проверка ввода Фамилии
            if (lastName == null)
            {
                Console.WriteLine("Фамилия не введена");
                return;
            }

            Console.WriteLine("Имя?");
            string? firstName = Console.ReadLine(); // Имя

            // Проверка ввода Имени
            if (firstName == null)
            {
                Console.WriteLine("Имя не введено");
                return;
            }

            Console.WriteLine("Отчество");
            string? patronymic = Console.ReadLine(); // Отчество

            // Проверка ввода Отчества
            if (patronymic == null)
            {
                Console.WriteLine("Отчество не введено");
                return;
            }

            Console.WriteLine("Возраст?");
            byte age;  // Возраст
            byte.TryParse(Console.ReadLine(), out age);

            // Проверка ввода возраста
            if (age == 0)
            {
                Console.WriteLine("Некоректный ввод возраста");
            }

            Console.WriteLine("Email?");
            string? email = Console.ReadLine();  // Почта

            // Проверка ввода почты
            if (email == null)
            {
                Console.WriteLine("Почта не введена");
                return;
            }

            Console.WriteLine("Введите баллы по программированию через пробел");
            var programmingScores =                          // Баллы по программированию
                Console.ReadLine().Split(' ')
                .Select(it => double.Parse(it)).ToArray();

            Console.WriteLine("Введите баллы по математике через пробел");
            var mathScores =                                  // Баллы по математике
                Console.ReadLine().Split(' ')
                .Select(it => double.Parse(it)).ToArray();

            Console.WriteLine("Введите баллы по физике через пробел");
            var physicsScores =                               // Баллы по физике
                Console.ReadLine().Split(' ')
                .Select(it => double.Parse(it)).ToArray();

            Console.WriteLine($"{firstName} {lastName} {patronymic}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Email: {email}");

            Console.WriteLine("Баллы по программированию");
            foreach (int i in programmingScores)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine();

            Console.WriteLine("Баллы по математике");
            foreach (int i in mathScores)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine();

            Console.WriteLine("Баллы по физике");
            foreach (int i in physicsScores)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine();
        }
    }
}