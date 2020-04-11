using System;

namespace Lesson3
{
    class Program
    {
        static void n1()
        {
            int sum = 0, n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 10 == 3)
                {
                    sum += i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(sum);
        }
        static void n2()
        {
            int sum_z = 0, sum_k = 0, n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {

                if (n % 10 % 2 == 0)
                    sum_z += n % 10;
                else
                    sum_k += n % 10;
                n /= 10;
            }
            if (sum_z == sum_k)
                Console.WriteLine("True");
        }
        static void n3()
        {
            int sum_z = 0,sum_k = 0,q = 1, n = Convert.ToInt32(Console.ReadLine());
            while(n > 0)
            {
                
                if (q % 2 == 0)
                    sum_z += n % 10;
                else
                    sum_k += n % 10;
                n /= 10;
                q++;
            }
            if (sum_z == sum_k)
                Console.WriteLine("True");
        }
        static void n4()
        {
            int q = 0, n = Convert.ToInt32(Console.ReadLine());
            while (n > 1)
            {
                n /= 3;
                q++;
                Console.WriteLine(n);   
            }
            if (n == 1)
                Console.WriteLine($"Ereqi {q} astichan e");
            else
                Console.WriteLine("Astichan che");
        }
        static void n5()
        {
            int gum = 0,i = 5;
            Console.WriteLine($"Mutqagreq {i} hat tiv");
            while(i > 0)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                if (a % 2 == 0)
                    gum += a;
                i--;
            }
            Console.WriteLine(gum);
        }
        static void n6()
        {
            for (int i = 10000; i < 100000; i++)
            {
                int e = i % 10;
                int d = i / 10 % 10;
                int c = i / 100 % 10;
                int b = i / 1000 % 10;
                int a = i / 10000;

                if (a == d && a != b && a != c && a != e && + 
                    b == e && b != c && b != d && +
                    c != d && c != e && +
                    d != e)
                {
                    for (int j = 1000; j < 10000; j++)
                    {
                        int ee = j % 10;
                        int dd = j / 10 % 10;
                        int cc = j / 100 % 10;
                        int bb = j / 1000;

                        if (ee != dd && ee != cc && ee != bb && +
                            dd != cc && dd != bb &&+
                            cc != bb &&+
                            ee != a && ee != b && ee != c && ee != d && ee != e && +
                            dd != a && dd != b && dd != c && dd != d && dd != e && +
                            cc != a && cc != b && cc != c && cc != d && cc != e && +
                            bb != a && bb != b && bb != c && bb != d && bb != e)
                        {
                            int sum = i + j;

                            int eee = sum % 10;
                            int ddd = sum / 10 % 10;
                            int ccc = sum / 100 % 10;
                            int bbb = sum / 1000 % 10;
                            int aaa = sum / 10000;

                            if (aaa != a && aaa != b && aaa != c && aaa != d && aaa != e && aaa != bb && aaa != cc && aaa != dd && aaa != ee &&+
                                aaa != bbb && aaa != ccc && aaa != ddd && aaa != eee && +

                                eee != a && eee != b && eee != c && eee != d && eee != e && eee != bb && eee != cc && eee != dd && eee != ee && +
                                eee != bbb && eee != ccc && eee != ddd && eee != aaa && +

                                bbb != a && bbb == b && bbb != c && bbb != d && bbb == e && bbb != bb && bbb != cc && bbb != dd && bbb != ee && +
                                bbb != eee && bbb != ccc && bbb == ddd && bbb != aaa && +

                                ccc != a && ccc != b && ccc != c && ccc != d && ccc != e && ccc != bb && ccc != cc && ccc != dd && ccc == ee && +
                                ccc != eee && ccc != bbb && ccc != ddd && ccc != aaa && +

                                ddd != a && ddd == b && ddd != c && ddd != d && ddd == e && ddd != bb && ddd != cc && ddd != dd && ddd != ee && +
                                ddd != eee && ddd != ccc && ddd == bbb && ddd != aaa
                                ) 
                            {
                                Console.WriteLine($"{i} + {j} = {sum}");
                            }
                        }
                    }
                }
            }
        }
        static void n7()
        {
            for (int i = 1000; i < 10000; i++)
            {
                int d = i % 10;
                int c = i / 10 % 10;
                int b = i / 100 % 10;
                int a = i / 1000 % 10;

                if (a != d && a != b && a != c && +
                    b != c && b != d && +
                    c != d)
                {
                    for (int j = 1000; j < 10000; j++)
                    {
                        int dd = j % 10;
                        int cc = j / 10 % 10;
                        int bb = j / 100 % 10;
                        int aa = j / 1000 % 10;

                        if (aa == a && aa != b && aa != c && aa != d && +

                            bb != a && bb == b && bb != c && bb != d && +

                            cc != a && cc != b && cc == c && cc != d && +

                            dd != a && dd != b && dd != c && dd == d && +

                            aa != dd && aa != bb && aa != cc && +
                            bb != cc && bb != dd && +
                            cc != dd)
                        {
                            for (int k = 1000; k < 10000; k++)
                            {
                                int ddd = k % 10;
                                int ccc = k / 10 % 10;
                                int bbb = k / 100 % 10;
                                int aaa = k / 1000 % 10;

                                if (aaa == a && aaa != b && aaa != c && aaa != d && +
                                    aaa == aa && aaa != bb && aaa != cc && aaa != dd && +

                                    bbb != a && bbb == b && bbb != c && bbb != d && +
                                    bbb != aa && bbb == bb && bbb != cc && bbb != dd && +

                                    ccc != a && ccc != b && ccc == c && ccc != d && +
                                    ccc != aa && ccc != bb && ccc == cc && ccc != dd && +

                                    ddd != a && ddd != b && ddd != c && ddd == d && +
                                    ddd != aa && ddd != bb && ddd != cc && ddd == dd && +

                                    aaa != ddd && aaa != bbb && aaa != ccc && +
                                    bbb != ccc && bbb != ddd && +
                                    ccc != ddd
                                    )
                                {
                                    for (int l = 1000; l < 10000; l++)
                                    {
                                        int dddd = l % 10;
                                        int cccc = l / 10 % 10;
                                        int bbbb = l / 100 % 10;
                                        int aaaa = l / 1000 % 10;

                                        if (aaaa == a && aaaa != b && aaaa != c && aaaa != d && +
                                            aaaa == aa && aaaa != bb && aaaa != cc && aaaa != dd && +
                                            aaaa == aaa && aaaa != bbb && aaaa != ccc && aaaa != ddd && +

                                            bbbb != a && bbbb == b && bbbb != c && bbbb != d && +
                                            bbbb != aa && bbbb == bb && bbbb != cc && bbbb != dd && +
                                            bbbb != aaa && bbbb == bbb && bbbb != ccc && bbbb != ddd && +

                                            cccc != a && cccc != b && cccc == c && cccc != d && +
                                            cccc != aa && cccc != bb && cccc == cc && cccc != dd && +
                                            cccc != aaa && cccc != bbb && cccc == ccc && cccc != ddd && +

                                            dddd != a && dddd != b && dddd != c && dddd == d && +
                                            dddd != aa && dddd != bb && dddd != cc && dddd == dd && +
                                            dddd != aaa && dddd != bbb && dddd != ccc && dddd == ddd && +

                                            aaaa != dddd && aaaa != bbbb && aaaa != cccc && +
                                            bbbb != cccc && bbbb != dddd && +
                                            cccc != dddd
                                            )
                                        {
                                            for (int m = 1000; m < 10000; m++)
                                            {
                                                int ddddd = m % 10;
                                                int ccccc = m / 10 % 10;
                                                int bbbbb = m / 100 % 10;
                                                int aaaaa = m / 1000 % 10;

                                                if (aaaaa == a && aaaaa != b && aaaaa != c && aaaaa != d && +
                                                    aaaaa == aa && aaaaa != bb && aaaaa != cc && aaaaa != dd && +
                                                    aaaaa == aaa && aaaaa != bbb && aaaaa != ccc && aaaaa != ddd && +
                                                    aaaaa == aaaa && aaaaa != bbbb && aaaaa != cccc && aaaaa != dddd && +

                                                    bbbbb != a && bbbbb == b && bbbbb != c && bbbbb != d && +
                                                    bbbbb != aa && bbbbb == bb && bbbbb != cc && bbbbb != dd && +
                                                    bbbbb != aaa && bbbbb == bbb && bbbbb != ccc && bbbbb != ddd && +
                                                    bbbbb != aaaa && bbbbb == bbbb && bbbbb != cccc && bbbbb != dddd && +

                                                    ccccc != a && ccccc != b && ccccc == c && ccccc != d && +
                                                    ccccc != aa && ccccc != bb && ccccc == cc && ccccc != dd && +
                                                    ccccc != aaa && ccccc != bbb && ccccc == ccc && ccccc != ddd && +
                                                    ccccc != aaaa && ccccc != bbbb && ccccc == cccc && ccccc != dddd && +

                                                    ddddd != a && ddddd != b && ddddd != c && ddddd == d && +
                                                    ddddd != aa && ddddd != bb && ddddd != cc && ddddd == dd && +
                                                    ddddd != aaa && ddddd != bbb && ddddd != ccc && ddddd == ddd && +
                                                    ddddd != aaaa && ddddd != bbbb && ddddd != cccc && ddddd == dddd && +

                                                    aaaaa != ddddd && aaaaa != bbbbb && aaaaa != ccccc && +
                                                    bbbbb != ccccc && bbbbb != ddddd && +
                                                    ccccc != ddddd
                                                    )
                                                {
                                                    int sum = i + j + k + l + m;

                                                    int dddddd = sum % 10;
                                                    int cccccc = sum / 10 % 10;
                                                    int bbbbbb = sum / 100 % 10;
                                                    int aaaaaa = sum / 1000 % 10;

                                                    if (aaaaaa != a && aaaaaa != b && aaaaaa != c && aaaaaa != d && +
                                                        aaaaaa != aa && aaaaaa != bb && aaaaaa != cc && aaaaaa != dd && +
                                                        aaaaaa != aaa && aaaaaa != bbb && aaaaaa != ccc && aaaaaa != ddd && +
                                                        aaaaaa != aaaa && aaaaaa != bbbb && aaaaaa != cccc && aaaaaa != dddd && +
                                                        aaaaaa != aaaaa && aaaaaa != bbbbb && aaaaaa != ccccc && aaaaaa != ddddd && +

                                                        bbbbbb != a && bbbbbb != b && bbbbbb != c && bbbbbb != d && +
                                                        bbbbbb != aa && bbbbbb != bb && bbbbbb != cc && bbbbbb != dd && +
                                                        bbbbbb != aaa && bbbbbb != bbb && bbbbbb != ccc && bbbbbb != ddd && +
                                                        bbbbbb != aaaa && bbbbbb != bbbb && bbbbbb != cccc && bbbbbb != dddd && +
                                                        bbbbbb != aaaaa && bbbbbb != bbbbb && bbbbbb != ccccc && bbbbbb != ddddd && +

                                                        cccccc != a && cccccc != b && cccccc != c && cccccc != d && +
                                                        cccccc != aa && cccccc != bb && cccccc != cc && cccccc != dd && +
                                                        cccccc != aaa && cccccc != bbb && cccccc != ccc && cccccc != ddd && +
                                                        cccccc != aaaa && cccccc != bbbb && cccccc != cccc && cccccc != dddd && +
                                                        cccccc != aaaaa && cccccc != bbbbb && cccccc != ccccc && cccccc != ddddd && +

                                                        dddddd != a && dddddd != b && dddddd != c && dddddd != d && +
                                                        dddddd != aa && dddddd != bb && dddddd != cc && dddddd != dd && +
                                                        dddddd != aaa && dddddd != bbb && dddddd != ccc && dddddd != ddd && +
                                                        dddddd != aaaa && dddddd != bbbb && dddddd != cccc && dddddd != dddd && +
                                                        dddddd != aaaaa && dddddd != bbbbb && dddddd != ccccc && dddddd != ddddd && +

                                                        aaaaaa != dddddd && aaaaaa != bbbbbb && aaaaaa != cccccc && +
                                                        bbbbbb != cccccc && bbbbbb != dddddd && +
                                                        cccccc != dddddd)
                                                    {
                                                        if(sum < 10000)
                                                            Console.WriteLine($"{i} + {j} + {k} + {l} + {m} = {sum}");
                                                    }
                                                }
                                            }

                                        }
                                    }
                                }
                            }
                        }

                    }
                }
            }
        }
        static void n7_2()
        {
            for (int i = 1000; i < 10000; i++)
            {
                int d = i % 10;
                int c = i / 10 % 10;
                int b = i / 100 % 10;
                int a = i / 1000;

                if (a != d && a != b && a != c && +
                    b != c && b != d && +
                    c != d)
                {
                    int sum = i * 5;

                    int dd = sum % 10;
                    int cc = sum / 10 % 10;
                    int bb = sum / 100 % 10;
                    int aa = sum / 1000;

                    if (aa != a && aa != b && aa != c && aa != d && aa != bb && aa != cc && aa != dd && +
                        bb != a && bb != b && bb != c && bb != d && bb != aa && bb != cc && bb != dd && +
                        cc != a && cc != b && cc != c && cc != d && cc != aa && cc != bb && cc != dd && +
                        dd != a && dd != b && dd != c && dd != d && dd != aa && dd != bb && dd != cc && sum < 10000)
                    {
                        Console.WriteLine($"{i} + {i} + {i} + {i} + {i} = {sum}");
                    }
                }
            }
        }
        static void n8()
        {
            double sum,q = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            int x = k;
            while(x > 0)
            {
                x /= 10;
                q++;
            }
            Console.WriteLine(q);
            sum = n * Math.Pow(10, q) + k;
            Console.WriteLine(sum);
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
            //n7_2();
            //n8();
        }
    }
}
