using System;
using System.Text;
using System.Linq;

namespace _06.SumBigNumbers
{
    class SumBigNumbers
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();

            int sum = 0;
            int reminder = 0;
          

            if (num1.Length > num2.Length)
            {
                num2 = num2.PadLeft(num1.Length, '0');
            }
            else
            {
                num1 = num1.PadLeft(num2.Length, '0');
            }
            StringBuilder sb = new StringBuilder();

            for (int i = num1.Length - 1; i >= 0; i--)
            {
                 sum = num1[i] - '0' + num2[i] - '0' + reminder;
                if (sum > 9)
                {
                    reminder = 1;
                }
                else
                {
                    reminder = 0;    
                }
                int num = sum % 10;
                sb.Append(num);

                if (i == 0 && sum > 9)
                {
                    sb.Append(reminder);
                }
            }

            Console.WriteLine(sb.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray());
        }
    }
}
