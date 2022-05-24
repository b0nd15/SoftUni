using System;

namespace _07.Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            //int coins = Int32.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double coinSum = 0;
            while (input != "Start")
            {
                double coinValue = Double.Parse(input);

                if (coinValue == 0.1 || coinValue == 0.2 || coinValue == 0.5 || coinValue == 1 || coinValue == 5)
                {
                    coinSum += coinValue;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coinValue}");
                }

                input = Console.ReadLine();

            }

            //Console.WriteLine("coinSum:" + coinSum);

            input = Console.ReadLine();
            double productPrice = 0.0;

            while (input != "End")
            {
                if (input == "Nuts")
                {
                    productPrice = 2.0;
                }
                else if (input == "Water")
                {
                    productPrice = 0.7;
                }
                else if (input == "Crisps")
                {
                    productPrice = 1.5;
                }
                else if (input == "Soda")
                {
                    productPrice = 0.8;
                }
                else if (input == "Coke")
                {
                    productPrice = 1.0;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    input = Console.ReadLine();
                    continue;
                }

                if (productPrice <= coinSum) 
                {
                    Console.WriteLine($"Purchased {input.ToLower()}");
                    coinSum -= productPrice;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Change: {coinSum:F2}");
        }
    }
}
