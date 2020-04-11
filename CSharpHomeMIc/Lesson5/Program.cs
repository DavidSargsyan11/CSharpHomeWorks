using System;

namespace Lesson5
{
    class Program
    {
        static void n1()
        {
            int a, b, c, x, y;
            Console.Write("a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            b = Convert.ToInt32(Console.ReadLine());

            for (x = -a * b; x <= a * b; x++)
            {
                for (y = -a * b; y <= a * b; y++)
                {
                    if (a * x + b * y == a * b)
                    {
                        Console.WriteLine($"x={x}  y={y}");
                        Console.WriteLine($"{a}*{x}*{b}*{y}={a * b}"); Console.WriteLine();
                    }
                }
            }

        }
        static void n2()
        {
            //Tvi tvanshanneri u dranc qazakusineri gumar
            for (int i = 10; i < 100; i++)
            {
                int m = i % 10;
                int t = i / 10 % 10;
                if ((m + t) + Math.Pow((m + t), 2) == i)
                {
                    Console.WriteLine($"The number is {i}");
                }
            }
        }
        static void n3()
        {
            //Minchev n-@ bolor bajanararneri gumar@
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tiv - {i}");
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                        Console.WriteLine($"Bajanarar {j}");
                    }
                }
            }
            Console.WriteLine($"Bajanararneri gumar@ - {sum}");
        }
        static void n4()
        {
            int a, b, c, x, y;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            int aa = a;
            int bb = b;

            while (a % b != 0)
            {
                c = a % b;
                b = c;
            }
            for (x = -aa; x < aa; x++)
            {
                for (y = -bb; y < bb; y++)
                {
                    if (aa * x + bb * y == b)
                        Console.Write(x + "/t" + y);
                }
            }
        }
        static void n5()
        {
            int n = int.Parse(Console.ReadLine());
            for (int hav = 1; hav <= n; hav++)
            {
                for (int kov = 1; kov <= n; kov++)
                {
                    for (int vochxar = 1; vochxar <= n; vochxar++)
                    {
                        if (hav * 0.5 + vochxar * 5 + kov * 10 == n && hav + vochxar + kov == n)
                        {
                            Console.WriteLine($"Hav:{hav} Kov:{kov} Vochxar:{vochxar}");
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //n1();
            //n2();
            //n3();
            //n4();
            //n5();
        }
    }
}
