/*
   Выведите на экран матрицу заданного размера и заполните её случайными числами.
   Детальный алгоритм работы приложения:

   Сначала пользователю предлагается ввести количество строк в будущей матрице.
   Затем — ввести количество столбцов в будущей матрице.
   После того, как данные будут получены, нужно создать в памяти матрицу заданного размера.
   Используя Random, заполнить матрицу случайными целыми числами.
   Вывести полученную матрицу на экран. 
   Вывести суммы всех элементов этой матрицы на экран отдельной строкой.

 */

using System;

namespace RandomMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество рядов");
            int row;  // Количество рядов
            int.TryParse(Console.ReadLine(), out row);

            if(row == 0)
            {
                Console.WriteLine("Неправельный ввод количества рядов");
                return;
            }

            Console.WriteLine("Введите количество столбцов");
            int column;   // количество столбцов
            int.TryParse(Console.ReadLine(), out column);

            if(column == 0)
            {
                Console.WriteLine("Неправельный ввод количества столбцов");
            }

            var matrix = new int[row, column];

            // Заполнение матрици
            MatrixFilling(ref matrix, row, column);

            // Печать матрици
            PrintMatrix(ref matrix, row, column);

            // Сумма элементов матрици
            Console.WriteLine
                (
                $"Сумма всех элементов матрици: {SumMatrix(ref matrix, row, column)}"
                );
        }

        /// <summary>
        /// Заполнение матрици
        /// </summary>
        /// <param name="matrix">Матрица</param>
        /// <param name="row">Количество рядов</param>
        /// <param name="column">Количество столбцов</param>
        static void MatrixFilling(ref int[,] matrix, int row, int column)
        {
            Random random = new Random();
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < column; j++)
                {
                    matrix[i, j] = random.Next(10);
                }
            }
        }

        /// <summary>
        /// Печать матрици на экран
        /// </summary>
        /// <param name="matrix">Матрица</param>
        /// <param name="row">Ряд</param>
        /// <param name="column">Строка</param>
        static void PrintMatrix(ref int[,] matrix, int row, int column)
        {
            for (int i = 0; i < row; ++i)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Подщет суммы елементов
        /// </summary>
        /// <param name="matrix">Матрица</param>
        /// <param name="row">Колмчество рядов</param>
        /// <param name="column">Количество столбцов</param>
        /// <returns>Сумма элементов матрици</returns>
        static int SumMatrix(ref int[,] matrix, int row, int column)
        {
            int sum = 0;

            for(int i = 0;i < row; ++i)
            {
                for(int j = 0; j < column; j++)
                {
                    sum += matrix[i, j];
                }
            }

            return sum;
        }
    }
}