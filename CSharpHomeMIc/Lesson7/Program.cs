using System;
using System.Globalization;

namespace Lesson7
{
    class Program
    {
        static void chkrknvox()
        {
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(100, 999);
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(arr[i] == arr[j] && i != j)
                    {
                        arr[i] = rnd.Next(10, 20);
                        i = 0;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + "\t");
            }
        }
        static void mekumej()
        {
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            Random rnd = new Random();

            Console.Write("Arr1:    ");
            for (int i = 0; i < n; i++)
            {
                arr1[i] = rnd.Next(1, 15);
                Console.Write(arr1[i] + "\t");
            }

            Console.Write("Arr2:    ");
            for (int i = 0; i < n; i++)
            {
                arr2[i] = rnd.Next(1, 15);
                Console.Write(arr2[i] + "\t");
            }

            int[] arr3 = new int[n * 2];
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                arr3[j] = arr1[i];
                arr3[j + 1] = arr2[i];
                j += 2;
            }

            Console.WriteLine();

            for (int i = 0; i < n*2; i++)
            {
                Console.Write(arr3[i] + "\t");
            }
        }
        static void kent()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(1, 50);
                Console.Write(a[i] + "\t");
            }

            int[] b = new int[n];
            int q = 0;
            for (int i = 0; i < n; i++)
            {      
                if (a[i] % 2 == 1)
                {
                    b[q] = a[i];
                    q++;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < q; i++)
            {
                Console.Write(b[i] + "\t");
            }
        }
        static void Main(string[] args)
        {
            //chkrknvox();
            //mekumej();
            kent();
        }
    }
}
