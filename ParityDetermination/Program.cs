﻿/*
  Напишите приложение, которое определяет чётное или нечётное число.
  Алгоритм приложения выглядит следующим образом:

  На экране программа с помощью оператора Console.WriteLine предлагает пользователю ввести целое число.
  С помощью оператора Console.ReadLine считывается введённое число.
  С помощью метода int.Parse число преобразуется в целочисленную переменную.
  С помощью оператора деления с остатком определяется, чётное число или нечётное.
  В зависимости от предыдущего шага на экран выводится текст, является ли данное число чётным или нет.
*/

using System;

namespace ParityDetermination
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");

            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0) Console.WriteLine($"Число {number} четное");
            else Console.WriteLine($"Число {number} не четное");
        }





    }
}