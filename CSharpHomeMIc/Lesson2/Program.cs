using System;

namespace Lesson2
{
    class Program
    {
        static void n1()
        {
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            if (a < b)
            {
                c = b / a;
                Console.WriteLine($"Ktexavorvi {c} hat qarakusi");
            }
            else
            {
                Console.WriteLine($"{a} > {b}");
            }
        }
        static void n2()
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            int c = Convert.ToInt32(a % b == 0 || b % a == 0);
            Console.WriteLine($"Patasxann e {c}");
        }
        static void n3()
        {
            int a;
            a = Convert.ToInt32(Console.ReadLine());

            if (a % 7 == 0 && a % 3 == 0)
            {
                Console.WriteLine($"{a}-n 7-i ev 3-i bazmapatik e");
            }
            else
            {
                Console.WriteLine($"{a}-n bazmapatik che");
            }
        }
        static void n4()
        {
            int sum = 0;
            for (int i = 1000; i <= 9999; i++)
            {
                int hz = i / 1000;
                int h = i / 100 % 10;
                int t = i / 10 % 10;
                int m = i % 10;
                if (Math.Pow(hz, 4) + Math.Pow(h, 4) + Math.Pow(t, 4) + Math.Pow(m, 4) == i)
                {
                    sum += i;
                    Console.WriteLine($"I - {i}, sum = {sum}");
                }
            }
        }
        static void n5()
        {
            int r = Convert.ToInt32(Console.ReadLine());

            int x, y, q = 0;

            for (x = -r; x <= r; x++)
            {
                for (y = -r; y <= r; y++)
                {
                    if (x * x + y * y <= r * r)
                    {
                        q += 1;
                    }
                }
            }
            Console.WriteLine(q);
        }
        static void n6()
        {
            double x = Convert.ToInt32(Console.ReadLine());
            double y = Convert.ToInt32(Console.ReadLine());
            double z;
            if ((x / 2 + y / 2 <= 1) && (x * x + y * y >= 1) && x >= 0 && y >= 0)
            {
                Console.WriteLine("Ket@ patkanum e tiruytin");
                z = Math.Pow(x, 3) + Math.Pow(y, 3);
            }
            else
            {
                Console.WriteLine("Ket@ chi patkanum tiruytin");
                z = -3;
            }
            Console.WriteLine($"Z={z}");
        }
        static void n7()
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double z;
            if ((y >= Math.Abs(x)) && (y >= 0) && (x * x + y * y <= 1))
            {
                Console.WriteLine("ket@ patkanum e tiruytin");
                z = 5 * Math.Pow(x, 3) + y;
            }
            else
            {
                z = -3;
                Console.WriteLine("ket@ chi patkanum tiruytin");
            }
            Console.WriteLine(z);      
        }
        static void n8()
        {
            int k = 0, x = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= x; j++)
                {
                    if (i >= j)
                        k++;
                    else
                        k = 0;
                    Console.Write(k + "\t");
                }
                Console.WriteLine();
            }
        }
        static void n9()
        {
            int k = 0, x = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= x; j++)
                {
                    if(i > j && i + j < x + 1)
                    {
                        k = 4;
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (i < j && i + j > x + 1)
                    {
                        k = 2;
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else if (i < j && i + j < x + 1)
                    {
                        k = 1;
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (i == j || i + j == x + 1)
                    {
                        k = 0;
                        Console.ResetColor();
                    }
                    else
                    {
                        k = 3;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    Console.Write(k + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            //n1();
            //n2();
            //n3();
            //n4();
            //n5();
            //n6();
            //n7();
            //n8();
            //n9();
        }
    }
}
