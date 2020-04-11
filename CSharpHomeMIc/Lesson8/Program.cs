using System;

namespace Lesson8
{
    class Program
    {
        static void kaxardakan()
        {
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[n, n];
            int a = 1;
            int p = 2;
            arr[0, 0] = 1;
            while (a <= 2 * n - 2)
            {
                if (a % 2 == 1)
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (i + j == a)
                            {
                                arr[i, j] = p;
                                p++;
                            }
                        }
                    }
                }
                else
                {
                    for (int i = n - 1; i >= 0; i--)
                    {
                        for (int j = n - 1; j >= 0; j--)
                        {
                            if (i + j == a)
                            {
                                arr[i, j] = p;
                                p++;
                            }
                        }
                    }
                }
                a++;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void mogakan()
        {
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n % 2 == 1)
            {
                int[,] arr = new int[n, n];
                int m = 1;
                int i = 0;
                int i1 = i;
                int j = n / 2;
                int j1 = j;

                while (m <= n * n)
                {
                    if (i < 0)
                        i = n - 1;

                    if (j > n - 1)
                        j = 0;

                    if (arr[i, j] != 0)
                    {
                        i = i1 + 1;
                        j = j1;

                    }
                    arr[i, j] = m;
                    i1 = i;
                    j1 = j;
                    i--;
                    j++;
                    m++;
                }
                for (int l = 0; l < n; l++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        Console.Write(arr[l, k] + "\t");
                    }
                    Console.WriteLine();
                }
                break;
            }
        }
        static void Main(string[] args)
        {
            //kaxardakan();
            mogakan();
        }
    }
}
