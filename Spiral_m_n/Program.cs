using System;

namespace Spiral_m_n
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество столбцов");
            int n;
            bool result1 = int.TryParse(Console.ReadLine(), out n);
            while (result1 == false)
            {
                Console.WriteLine("Перепроверьте число и введите снова");
                result1 = int.TryParse(Console.ReadLine(), out n);
            }
            Console.WriteLine("Введите количество строк");
            int m;
            bool result2 = int.TryParse(Console.ReadLine(), out m);
            while (result2 == false)
            {
                Console.WriteLine("Перепроверьте число и введите снова");
                result2 = int.TryParse(Console.ReadLine(), out m);
            }
            int[,] mas = new int[m, n];
            int k = 1;
            int t = 0;
            int i, j = 0;
            int n1 = n;
            int m1 = m;

            while (k <= n1 * m1)
            {
                for (i = t; i < n; i++)
                    mas[j, i] = k++;
                j = n - 1;              
                if (k >= n1 * m1)
                    break;

                for (i = t + 1; i < m; i++)
                    mas[i, j] = k++;
                j = m - 1;
                if (k >= n1 * m1)
                    break;

                for (i = n - 2; i >= t; i--)
                    mas[j, i] = k++;
                j = t;
                if (k >= n1 * m1)
                    break;

                for (i = m - 2; i > t ; i--)
                    mas[i, j] = k++;
                n--;
                m--;
                t++;
                j = t;          
            }

            for (i = 0; i < m1; i++)
            {
                for (j = 0; j < n1; j++)
                    Console.Write("{0,4} ", mas[i, j]);
                Console.WriteLine();
            }
        }
    }
}
