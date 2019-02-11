using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.Pilindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ',', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries);
  
            Console.WriteLine(string.Join(", ", input.Where(w => IsPallindrome(w)).Distinct().OrderBy(w => w)));
        }
        public static bool IsPallindrome(string word)
        {
            int length = word.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (word[i] != word[length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
