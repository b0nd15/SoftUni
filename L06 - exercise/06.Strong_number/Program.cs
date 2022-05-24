using System;

namespace _06.Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Int32.Parse(Console.ReadLine());
            int digits = number;
            int digit;
            int factorialSum = 0;
            //145
            while(true)
            {
                digit = digits % 10;
                digits = digits / 10;
                //Console.WriteLine(digit);

                int factorial = 0;
                if (digit != 0)
                {
                    factorial = 1;
                    for (int i = 1; i <= digit; i++)
                    {
                        factorial *= i;
                    }
                }
               // Console.WriteLine("factorial:" + factorial);

                factorialSum += factorial;

                if (digits == 0)
                {
                    break;
                }
            }
            if (number == factorialSum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
