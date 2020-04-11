using System;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kamayakan tvi faktorial
            int[] a = new int[1000000];
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());
            a[0] = 1;
            a[1] = 1;

            int j = 2;
            while (j <= n && a[0] < 1000000)
            {
                int r = 0;
                int i = 1;

                while (i <= a[0] || r != 0)
                {
                    int w = a[i] * j + r;
                    a[i] = w % 10;
                    r = w / 10;
                    if (a[a[0] + 1] != 0)
                    {
                        a[0]++;
                    }
                    i++;
                }
                j++;
            }

            for (int i = a[0]; i >= 1; i--)
            {
                Console.Write($"{a[i]}");
            }
            Console.WriteLine();
            Console.WriteLine(a[0]);

            int[] b = new int[10];
            for (int i = a[0]; i >= 1; i--)
            {
                b[a[i]]++;
            }
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine($"{i}: {b[i]}");
            }
        }
    }
}
