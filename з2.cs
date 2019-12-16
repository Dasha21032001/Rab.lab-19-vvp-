using System;

namespace з2
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 999999, max = -999999, i = 0, j = 0, jmin = 0, jmax = 0, temp;
            int[,] A = new int[100, 100];
            Console.Write("Введите кол-во строк матрицы: ");
            int M = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во столбцов матрицы: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Начальная матрица: ");
            Console.WriteLine();
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < N; j++)
                {
                    if (A[i, j] < min)
                    {
                        min = A[i, j];
                        jmin = j;
                    }
                    else
                    {
                        if (A[i, j] > max)
                        {
                            max = A[i, j];
                            jmax = j;
                        }
                    }
                }
            }
            if (jmin == jmax)
                Console.WriteLine("Наибольший и наименьший элементы пpинадлежат одному столбцу");
            else
            {
                for (i = 0; i < M; i++)
                {
                    for (j = 0; j < N; j++)
                    {
                        if (j == jmin)
                        {
                            temp = A[i, j];
                            A[i, j] = A[i, jmax];
                            A[i, jmax] = temp;
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Изменённая матрица: ");
                for (i = 0; i < M; i++)
                {
                    Console.WriteLine("\n");
                    for (j = 0; j < N; j++)
                    {
                        Console.Write("{0} ", A[i, j]);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
