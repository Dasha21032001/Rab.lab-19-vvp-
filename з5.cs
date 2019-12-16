using System;

namespace з5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[100, 100];
            int i = 0, j = 0, M, sum, k = 0, l = 0;
            Console.Write("Введите порядок квадратной матрицы: ");
            M = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Начальная матрица: ");
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < M; j++)
                {
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (i = 0; i < M * 2 - 1; ++i)
            {
                sum = 0;
                k = i;
                if (i >= M)
                {
                    k = M - 1;
                    ++l;
                }
                for (j = k; j > l - 1; --j)
                {
                    sum += A[k + l - j, j];
                }
                Console.WriteLine("Сумма элементов " + (i + 1) + " диагонали: " + sum);
            }
            Console.ReadLine();
        }
    }
}
