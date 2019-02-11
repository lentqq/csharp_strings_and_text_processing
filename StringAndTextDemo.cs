using System;

namespace StringAndTextDemo
{
    class StringAndTextDemo
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new [] {',', ' '},StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (var word in words)
            {
                var replacment = new string('*', words.Length);
                text = text.Replace(word,replacment);
            }
            Console.WriteLine(text);
        }
    }
}
