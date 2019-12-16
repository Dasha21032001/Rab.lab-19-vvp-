using System;

namespace з3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0;
            int[,] A = new int[100, 100];
            Console.Write("Введите кол-во строк матрицы: ");
            int M = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во столбцов матрицы: ");
            int N = int.Parse(Console.ReadLine());
            if ((M % 2 == 0) && (N % 2 == 0))
            {
                Console.Write("Начальная матрица: ");
                Console.WriteLine();
                for (i = 0; i < M; i++)
                {
                    for (j = 0; j < N; j++)
                    {
                        A[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                int k = M / 2;
                int l = N / 2;
                for (i = 0; i < k; i++)
                {
                    for (j = 0; j < l; j++)
                    {
                        int temp = A[i, j];
                        A[i, j] = A[k + i, l + j];
                        A[k + i, l + j] = temp;
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
            }
            else { Console.WriteLine("M и N должны быть чётными! Ошибка при вводе!"); }
            Console.ReadLine();
        }
    }
}
