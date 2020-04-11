using System;
using System.Numerics;

namespace Lesson4
{
    class Program
    {
        static void n1()
        {
            //Jam-i u rope-i kazmac ankyun@
            int jam = Convert.ToInt32(Console.ReadLine());
            int rope = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Abs((double)((jam % 12 * 30 + (double)rope / 2) - (rope % 12 * 30))));
        }
        static void n2()
        {
            //FIXME
        }
        static void n3()
        {
            //qaranish tiv
            int a, b, c, d;

            for (int i = 1000; i < 10000; i++)
            {
                a = i / 1000;
                b = i / 100 % 10;
                c = i / 10 % 10;
                d = i % 10;

                if (a * b - c * d == a + b + c + d)
                    Console.WriteLine(i);
            }
        }
        static void n4()
        {/*
            int q = 2,n = int.Parse(Console.ReadLine());
            int x = n;
            while (x >= 1) { 
                if (x % q == 0) { 
                    x /= q;
                    if (x % (q + 1) != 0) 
                    {
                        Console.WriteLine($"{n}-@ {q}-i faktorial e");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"{n}-@ faktorial che");
                    break;
                }
                q++;
            }
            */

            //Tiv@ faktorial e?
            int q = 0, n = int.Parse(Console.ReadLine());
            do
            {
                q++;
                if (n % q ==0)
                {
                    n /= q;
                }
            } while (n != 1);
            Console.WriteLine($"{q}-i faktorial e");
        }
        static void n5()
        {
            //Fibonachi
            int f1 = 0, f2 = 1, fn = 1, n = Convert.ToInt32(Console.ReadLine());

            while (n != 0)
            {
                fn = f1;
                f1 = f2 + fn;
                f2 = fn;
                
                n--;
            }
            Console.WriteLine(f1);
        }
        static void n6()
        {
            //Parz tiv + Sargsyani sharq
            int n = Convert.ToInt32(Console.ReadLine());
            int parz_t = 1;

            for (int i = 1; i <= n; i++)
            {
                bool parz = false;
                do
                {
                    parz_t++;
                    parz = true;
                    for (int j = 2; j <= Math.Sqrt(parz_t); j++)
                    {
                        if (parz_t % j == 0)
                        {
                            parz = false;
                            break;
                        }
                        if (parz)
                        {
                            parz = true;
                        }
                    }
                } while (!parz);
                Console.Write(parz_t + 1 + "\t");
            }
            Console.WriteLine();
        }
        static void n7()
        {
            //Parz tiv + Zarai sharq
            int n = Convert.ToInt32(Console.ReadLine());
            int k = 2;
            int parz_t = 1;

            for (int i = 1; i <= n; i++)
            {

                bool parz = false;
                do
                {
                    parz_t++;
                    parz = true;
                    for (int j = 2; j <= Math.Sqrt(parz_t); j++)
                    {
                        if (parz_t % j == 0)
                        {
                            parz = false;
                            break;

                        }
                        if (parz)
                        {
                            parz = true;
                        }
                    }

                } while (!parz);
                Console.Write(10 * i - parz_t + "\t");
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
        }
    }
}
