using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class StringCalculator
    {
        public static int Calculate(string arg = null)
        {
            if (arg == null)
                return 0;
            
            if (arg.Contains(","))
            {
                string[] numbers = arg.Split(',');

                return int.Parse(numbers[0]) + int.Parse(numbers[1]);
            }

            if (arg.Contains("\n"))
            {
                string[] numbers = arg.Split('\n');

                return int.Parse(numbers[0]) + int.Parse(numbers[1]);
            }

            if (arg.Contains("\n") || arg.Contains(','))
            {
                int sum = 0;
               
                Char[] delimiters = { ',', '\n' };
                string[] numbers = arg.Split(delimiters);

                for (int i = 0;  i < numbers.Length; i++)
                 sum += int.Parse(numbers[i]);

                return sum;
            }

            if (arg.Contains("-"))
                throw new IndexOutOfRangeException("Negative number");

            return int.Parse(arg);

        }
    }
}
