using System;

namespace Lesson9
{
    class Program
    {
        static void dziuQayl()
        {
            int n = int.Parse(Console.ReadLine());

            int[,] arr = new int[n, n];

            int x = 0, y = 0, k = 1;
            int xBef = x, yBef = y;
            while (k != n * n)
            {
                if (arr[x, y] != 0)
                {
                    x = xBef - 1;
                    y = yBef + 1;
                    if (y > n - 1)
                        y = 0;
                    if (x < 0)
                        x = n - 1;
                    arr[x, y] = k;
                }
                arr[x, y] = k;
                xBef = x;
                yBef = y;
                y += 2;
                x++;
                k++;
                if (y > n - 1)
                    y = y - n;
                if (x > n - 1)
                    x = 0;

            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(arr[i, j] + "  ");
                Console.WriteLine();
            }
        }
        static void urishQayl()
        {
            int n = int.Parse(Console.ReadLine());

            int[,] arr = new int[n, n];

            int x = 0, y = n / 2, k = 1;
            int xBef = x, yBef = y;
            while (k != n * n)
            {
                if (arr[x, y] != 0)
                {
                    x = xBef - 3;
                    y = yBef;
                    if (x < 0)
                        x = n + x;
                    arr[x, y] = k;
                }
                arr[x, y] = k;
                xBef = x;
                yBef = y;
                x += 2;
                y++;
                k++;
                if (y > n - 1)
                    y = 0;
                if (x > n - 1)
                    x = x - n;

            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(arr[i, j] + "  ");
                Console.WriteLine();
            }
        }
        static void amenamecTarerovVektor()
        {
            int n = int.Parse(Console.ReadLine());

            int[,] arr = new int[n, n];
            int[] arr1 = new int[n];
            Random rnd = new Random();
            int max = 0, sum = 0, maxi = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = rnd.Next(-50, 50);
                    Console.Write(arr[i, j] + "  ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
                sum += arr[0, i];

            max = sum;
            for (int i = 1; i < n; i++)
            {
                sum = 0;
                for (int j = 0; j < n; j++)
                {
                    sum += arr[i, j];
                }
                if (sum > max)
                {
                    max = sum;
                    maxi = i;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                arr1[i] = arr[maxi, i];
                Console.Write(arr1[i] + "  ");
            }
        }
        static void esimInch()
        {
            int n = int.Parse(Console.ReadLine());

            int[,] arr = new int[n, n];
            int k = 1;
            for (int i = 0; i < n; i++)
            {
                k = i + 1;
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = k;
                    if (k == n)
                        k = 0;
                    k++;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(arr[i, j] + "  ");
                Console.WriteLine();
            }
        }
        static void texerovToxeryPoxel()
        {
            int n = int.Parse(Console.ReadLine());

            int[,] arr = new int[n, n];
            Random rnd = new Random();
        Li:
            int k1 = int.Parse(Console.ReadLine());
            int k2 = int.Parse(Console.ReadLine());
            if ((k1 > n || k2 > n) && (k1 < 0 || k2 < n))
                goto Li;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = rnd.Next(0, 10);
                    Console.Write(arr[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == k1)
                        Console.Write(arr[k2, j] + "  ");
                    else if (i == k2)
                        Console.Write(arr[k1, j] + "  ");
                    else
                        Console.Write(arr[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
        static void jamslack()
        {

        }
        static void Main(string[] args)
        {
            //dziuQayl();
            //urishQayl();
            //amenamecTarerovVektor();
            //esimInch();
            //texerovToxeryPoxel();
            jamslack();

        }
    }
}
