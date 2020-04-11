using System;

namespace Lesson1
{
    class Program
    {
        static void makeres()
        {
            Console.WriteLine("Please input the numbers");

            Console.Write("Number_1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number_2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number_3: ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a + b >= c) { 
                int p = (a + b + c) / 2;

                double heron = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                Console.WriteLine($"The result is: {heron}");
            }
            else
                Console.WriteLine("Ays tveric hnaravor che kazmel erankyun");
        }
        static void erknishTver()
        {
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((k + 1) / 2);//tvi hamar@
            Console.WriteLine((k + 1) / 2 + 9);//tiv@
            if (k % 2 == 0)//tvanshan@
                Console.WriteLine(((k + 1) / 2 + 9) % 10);
            else
                Console.WriteLine(((k + 1) / 2 + 9) / 10);
        }
        static void eranishTver()
        {
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((k + 2) / 3);//tvi hamar@
            Console.WriteLine((k + 2) / 3 + 99);//tiv@
            if (k % 3 == 0)//tvanshan@
                Console.WriteLine(((k + 1) / 2 + 9) % 10);
            else if(k % 3 == 1)
                Console.WriteLine(((k + 1) / 2 + 9) / 100);
            else
                Console.WriteLine(((k + 1) / 2 + 9) / 10 % 10);
        }
        static void max()
        {
            Console.WriteLine("Please input the numbers");

            Console.Write("Number_1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number_2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number_3: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int max = a;
            if (max < b)
                max = b;
            if (max < c)
                max = c;
            Console.WriteLine($"The maximum number is: {max}");

            max = Math.Max(Math.Max(a, b), c);
            Console.WriteLine($"The maximum number is: {max}");

        }
        static void kordinatner()
        {
            Console.WriteLine("Please input x and y");

            Console.Write("x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if(x > 0 && y > 0)
                Console.WriteLine("Arajin qarord");
            else if(x > 0 && y < 0)
                Console.WriteLine("Chorrord qarord");
            else if(x < 0 && y > 0)
                Console.WriteLine("Erkrord qarord");
            else if(x < 0 && y < 0)
                Console.WriteLine("Errord qarord");
            else
                Console.WriteLine("x = 0 and y = 0");
        }
        static void banadzev()
        {
            Console.WriteLine("Please input the numbers");

            Console.Write("a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            double y;

            if (x >= 3 && x <= 10)
                y = Math.Sqrt(Math.Sqrt(Math.Pow(x, 3) + Math.Pow(a, 2))) + (Math.Log(5) / Math.Log(4) * (Math.Pow(x, 2) + c));
            else if (x > 10)
                y = Math.Tan(Math.Pow(Math.Pow(x, 3) + Math.Sqrt(a), 3));
            else
                y = Math.Pow(x, b);
            Console.WriteLine($"The result is {y}");
        }
        static void qaranishTiv()
        {
            Console.WriteLine("Please input 4 digit number!");
            int number = Convert.ToInt32(Console.ReadLine());

            int hz = number / 1000;
            int h = number % 1000 / 100;
            int t = number % 100 / 10;
            int m = number % 10;

            int sum = hz + h + t + m;

            Console.WriteLine($"The digit_1 is {hz}, The digit_2 is {h}, The digit_3 is {t}, The digit_4 is {m}");
            Console.WriteLine($"The result is {sum}");
        }
        static void vayrkyan()
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int jam = m / 3600;
            int rope = (m - (jam * 3600)) / 60;
            int vayrkyan = m - ((jam * 3600) + (rope * 60));

            Console.WriteLine($"Ancel e {jam} jam, {rope} rope, {vayrkyan} vayrkyan");
        }
        static void Main(string[] args)
        {
            //makeres();
            //erknishTver();
            //eranishTver();
            //max();
            //kordinatner();
            //banadzev();
            //qaranishTiv();
            //vayrkyan();
        }
    }
}
