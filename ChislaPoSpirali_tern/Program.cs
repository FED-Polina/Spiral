using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива:");
            //объявление переменных
            int n = int.Parse(Console.ReadLine());//размер сетки
            int[,] matrix = new int[n, n];
            int row = 0;
            int col = 0;
            int dx = 1;
            int dy = 0;
            int dirChanges = 0; //количество поворотов спирали
            int visits = n;//проверка выходов за массив
            //цикл по расчету спиральных чисел
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[row, col] = i + 1;
                if (--visits == 0) //-1 из переменной потом проверка
                {
                    visits = n * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
                    //замена мест переменных
                    int temp = dx;
                    dx = -dy;
                    dy = temp;
                    dirChanges++;
                }
                col += dx;
                row += dy;
            }
            //вывод матрицы в консоль
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}


