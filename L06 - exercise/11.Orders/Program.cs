using System;

namespace _11.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int ordersCount = Int32.Parse(Console.ReadLine());

            double totalPrice = 0;

            for (int currentOrder = 1; currentOrder <= ordersCount; currentOrder++)
            {
                Double pricePerCapsule = Double.Parse(Console.ReadLine());
                int daysInMonth = Int32.Parse(Console.ReadLine());
                int capsulesCount = Int32.Parse(Console.ReadLine());

                double currentOrderPrice = daysInMonth * capsulesCount * pricePerCapsule;
                totalPrice += currentOrderPrice;

                Console.WriteLine($"The price for the coffee is: ${currentOrderPrice:F2}");
            }

            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
