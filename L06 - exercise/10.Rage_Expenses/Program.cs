using System;

namespace _10.Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalLostGames = Int32.Parse(Console.ReadLine());
            double priceHeadset = Double.Parse(Console.ReadLine());
            double priceMouse = Double.Parse(Console.ReadLine());
            double priceKeyboard = Double.Parse(Console.ReadLine());
            double priceDisplay = Double.Parse(Console.ReadLine());

            double headsetPriceTotal = 0;
            double mousePriceTotal = 0;
            double keyboardPriceTotal = 0;
            int keyboardCount = 0;
            double displayPriceTotal = 0;

            for (int currentLostGame = 1; currentLostGame <= totalLostGames; currentLostGame++)
            {
                if (currentLostGame % 2 == 0)
                {
                    headsetPriceTotal += priceHeadset;
                }
                if (currentLostGame % 3 == 0)
                {
                    mousePriceTotal += priceMouse;
                }
                if (currentLostGame % 2 == 0 && currentLostGame % 3 == 0)
                {
                    keyboardPriceTotal += priceKeyboard;
                    keyboardCount++;
                }
                if (keyboardCount % 2 == 0 && keyboardCount != 0)
                {
                    displayPriceTotal += priceDisplay;
                    keyboardCount = 0;
                }
                // short solution
                // n = 8
                // 8/2=4
                // 8/3 = 2
                // 8/6 = 1
                // 1/2 = 0
            }

            double totalPrice = headsetPriceTotal + mousePriceTotal + keyboardPriceTotal + displayPriceTotal;

            Console.WriteLine($"Rage expenses: {totalPrice:F2} lv.");

        }
    }
}
