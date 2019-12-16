using System;

namespace з4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0, l=0, k=0;
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
            for (l = 0; l < M; l++)
            {
                for (i = 0; i < M - 1; i++)
                {
                    j = 0;
                    if (A[i, j] > A[i + 1, j])
                    {
                        for (k = 0; k < N; k++)
                        {
                            int temp = A[i, k];
                            A[i, k] = A[i + 1, k];
                            A[i + 1, k] = temp;
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Изменённая матрица:");
            for (i = 0; i < M; i++)
            {
                Console.WriteLine("\n");
                for (j = 0; j < N; j++)
                {
                    Console.Write("{0} ", A[i, j]);
                }
            }
            Console.ReadLine();
        }
    }
 }
