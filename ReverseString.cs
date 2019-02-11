using System;
using System.Text;
using System.Linq;

namespace _01.ReverseString
{
    class ReverseString
    {

        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder reversed = new StringBuilder();
            for (int i =text.Length -1 ; i >= 0; i--)
            {
              reversed.Append(text[i]);
            }
            Console.WriteLine(reversed);
        }
    }
}
