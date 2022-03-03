using System;

namespace reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1234;
            int result = 0;
            int remainder;
            while (num != 0)
            {
                remainder = num % 10;
                result = result * 10 + remainder;
                num = num / 10;
            }

            Console.WriteLine(result);
            

        }
    }
}
