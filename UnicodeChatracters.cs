using System;

namespace _03.UnicodeCharacters
{
    class UnicodeChatracters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            foreach (var symbol in input)
            {
                Console.Write($"\\u{(int)symbol:x4}");
            }
        }
    }
}
