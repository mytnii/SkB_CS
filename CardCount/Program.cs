/*
Есть довольно простая карточная игра, она называется Blackjack.
Суть игры сводится к подсчёту карт. Каждая карта имеет свой «вес».
Напишите программу, которая подсчитает сумму всех карт у нас на руках.
Задача программы сводится к следующему алгоритму:

    1. Программа приветствует пользователя и спрашивает, сколько у него на руках карт.

    2. Пользователь вводит целое число.

    3. Преобразуем это число в счётчик для цикла.

    4. С помощью цикла for итеративно просим пользователя ввести номинал каждой карты.
       Для карт с числовым номиналом он вводит только цифру. 

Для «картинок» следует принять обозначения латинскими буквами:

Валет = J

Дама = Q

Король = K

Туз = T

    5. Внутри цикла, используя оператор switch, 
       «вес» каждой карты складываем в общую переменную суммы, 
       которая объявлена до тела основного цикла. 
       Для числовых карт их «вес» равен весу, указанному при вводе пользователем.
       Для «картинок» «вес» равен 10.

    6. По завершении ввода на экране появится значение суммы карт.
*/

using System;
namespace CardCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет");
            Console.Write("Сколько карт на руках: ");

            int numberOfCards;     // Количество карт
            int.TryParse(Console.ReadLine(), out numberOfCards);  // чтобы не ловить Exeption
                                                                  // при некоректном ввод
            int cardAmount = 0;

            Console.WriteLine("Введите номинал карты");
            Console.WriteLine("Для карт с числовым наминало введите цифру");
            Console.WriteLine("Для картинок букву");
            Console.WriteLine("Валет = J");
            Console.WriteLine("Дама = Q");
            Console.WriteLine("Король = K");
            Console.WriteLine("Туз = T");

            for(int i = 0; i < numberOfCards; ++i)
            {
                Console.WriteLine("Введите номинал следующей карты");
                var card = Console.ReadLine();

                switch(card)
                {
                    case "6":
                        cardAmount += 6;
                        break;
                    case "7":
                        cardAmount += 7;
                        break;
                    case "8":
                        cardAmount += 8;
                        break;
                    case "9":
                        cardAmount += 9;
                        break;
                    case "10":
                        cardAmount += 10;
                        break;
                    case "j":
                    case "J":
                        cardAmount += 2;
                        break;
                    case "q":
                    case "Q":
                        cardAmount += 3;
                        break;
                    case "k":
                    case "K":
                        cardAmount += 4;
                        break;
                    case "t":
                    case "T":
                        cardAmount += 11;
                        break;
                    default:
                        Console.WriteLine("Неправельный ввод карты \n введите карту еще раз");
                        --i;
                        break;
                }
            }

            Console.WriteLine($"Сумма введеных карт: {cardAmount}");
        }
    }
}