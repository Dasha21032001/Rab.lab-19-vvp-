using System;

namespace лаб.раб__19
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, max, i = 0, j = 0, l=0, r=0;
            Random rand = new Random();
            Console.Write("Введите кол-во строк матрицы: ");
            int M = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во столбцов матрицы: ");
            int N = int.Parse(Console.ReadLine());
            int[,] A = new int[M, N];
            Console.Write("Элементы матрицы: ");
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
                min = 999999;
                max = 0;
                for (j = 0; j < N; j++)
                {
                    if (A[i,j] < min) { min = A[i,j]; l = j; }
                    if (A[i,j] > max) { max = A[i,j]; r = j; }
                }
                A[i,l] = max;
                A[i,r] = min;
            }
            Console.WriteLine("\n\nИзменённая матрица: ");
            for ( i = 0; i < M; i++)
            {
                Console.WriteLine("\n");
                for ( j = 0; j < N; j++)
                {
                    Console.Write("{0} ", A[i, j]);
                }
            }
            Console.ReadLine();
        }
    }
}
