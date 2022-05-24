using System;

namespace _04.Print_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = Int32.Parse(Console.ReadLine());
            int end = Int32.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
                sum += i; 
            }
            
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
