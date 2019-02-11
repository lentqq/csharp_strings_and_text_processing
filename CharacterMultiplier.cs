using System;
using System.Linq;

namespace _04.CharacterMultiplier
{
    class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string word1 = input[0];
            string word2 = input[1];
            int sum = 0;

            for (int i = 0; i < Math.Min(word1.Length, word2.Length); i++)
            {
                sum += word1[i] * word2[i];
            }

            for (int i = Math.Min(word1.Length, word2.Length); i < Math.Max(word1.Length, word2.Length); i++)
            {
                if (word1.Length > word2.Length)
                {
                    sum += word1[i];
                }
                else
                {
                    sum += word2[i];
                }
                //try
                //{
                //    sum += word1[i];
                //}
                //catch 
                //{
                //    sum += word2[i];
                //}
            }
            Console.WriteLine(sum);
        }
    }
}
