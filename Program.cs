using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сторону матрицы: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    Console.Write("matrix[{0}, {1}] = ", i + 1, j + 1);
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            int sum = -1, tmp;
            bool f = true;
            for (int i = 0; i < n && f; i++)
            {
                tmp = 0;
                for (int j = 0; j < n && f; j++) tmp += matrix[i, j];
                if (sum == -1) sum = tmp;
                f &= (tmp == sum);

                tmp = 0;
                for (int j = 0; j < n && f; j++) tmp += matrix[j, i];
                f &= (tmp == sum);
            }
            tmp = 0;
            for (int i = 0; i < n && f; i++) tmp += matrix[i, i];
            f &= (tmp == sum);

            tmp = 0;
            for (int i = 0; i < n && f; i++) tmp += matrix[i, n - i - 1];
            f &= (tmp == sum);

            if (f) Console.WriteLine("Матрица магическая");
            else Console.WriteLine("Матрица не магическая");
            Console.ReadKey();
        }
    }
}
