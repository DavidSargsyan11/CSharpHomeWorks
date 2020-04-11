using System;

namespace Lesson10
{
    class Program
    {
        public static bool p(int n)
        {
            bool parz = false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    parz = false;

            return parz;
        }
        public void parzTarrer()
        {
            Console.WriteLine("Enter N");
            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[,] arr = new int[n, n];
            int count = 0, sum = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = rnd.Next(-50, 98);
                    if (p(arr[i, j]) && arr[i, j] > 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        count++;
                        sum += arr[i, j];
                    }
                    Console.Write(arr[i, j] + "\t");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            Console.ResetColor();
            Console.WriteLine("sum=" + sum);
            Console.WriteLine("count=" + count);
            Console.WriteLine("mijtv=" + (double)sum / count);
        }
        static void parzPlusPlus()
        {
            Console.WriteLine("Enter N");
            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[] arr = new int[n];
            int m = 2, i = 0;
            while (i != n)
            {
                if (p(m))
                {
                    arr[i] = m;
                    Console.Write(arr[i] + 1 + "\t");
                    i++;
                }
                m++;
            }
        }
        public static void ojPlusGlx(int[,] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                int m = arr[i, i];
                arr[i, i] = arr[i, n - i - 1];
                arr[i, n - i - 1] = m;
            }
            for (int i = 0; i < n; i++)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public void texapoutyun()
        {
            Console.WriteLine("Enter N");
            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[,] arr = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = rnd.Next(-20, 20);
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            ojPlusGlx(arr, n);
        }
        static void Main(string[] args)
        {
            //parzTarrer();
            //parzPlusPlus();
            //texapoxutyun();
        }
    }
}
