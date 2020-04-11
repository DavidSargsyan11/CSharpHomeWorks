using System;

namespace Lesson11
{
    class Program
    {
        public void Word()
        {
            Console.WriteLine("Please input text");
            string text = Console.ReadLine();
            char[] text_arr = text.ToCharArray();
            int added = 0;
            for (int i = 0; i < text_arr.Length - 1; i++)
            {
                if (text_arr[i] == ',' && text_arr[i + 1] != ' ')
                {
                    text = text.Insert(i + ++added, " ");
                }
            }
            Console.WriteLine(text);
        }
        public void Replace()
        {
            Console.WriteLine("Write a text");
            string text = Console.ReadLine();
            Console.Write("To Replace: ");
            string toreplace = Console.ReadLine();
            Console.Write("Word: ");
            string word = Console.ReadLine();
            string[] splittedtext = text.Split(toreplace);
            string newstring = "";
            if (splittedtext.Length >= 2)
            {
                for (int i = 0; i < splittedtext.Length - 1; i++)
                    newstring += splittedtext[i] + word;
                newstring += splittedtext[splittedtext.Length - 1];
            }
            else
                newstring = text;
            Console.WriteLine(newstring);
        }
        public void sybolCount()
        {
            Console.WriteLine("Write a text");
            string text = Console.ReadLine();
            Console.Write("Symbol or Word: ");
            string symbol = Console.ReadLine();
            Console.WriteLine($"{symbol} Count In Text: {text.Split(symbol).Length - 1}");
        }
        public void delSymbol()
        {
            Console.WriteLine("Write a text");
            string text = Console.ReadLine();
            string newtext = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 == 0)
                    continue;
                newtext += text[i];
            }
        }
        public void numberCount()
        {
            Console.WriteLine("Write a text");
            string text = Console.ReadLine();
            int tryingparse = 0;
            int counting = 0;
            for (int i = 0; i < text.Length; i++)
                if (int.TryParse(text[i] + " ", out tryingparse))
                    counting++;
            Console.WriteLine(counting);
        }
        static void Main(string[] args)
        {
            //Word();
            //Replace();
            //symbolCount();
            //delSymbol();
            //numberCount();
        }
    }
}
