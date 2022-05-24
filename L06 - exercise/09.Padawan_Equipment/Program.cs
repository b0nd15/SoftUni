using System;

namespace _09.Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = Double.Parse(Console.ReadLine());
            int numberOfStudents = Int32.Parse(Console.ReadLine());
            double lightsaberPrice = Double.Parse(Console.ReadLine());
            double robePrice = Double.Parse(Console.ReadLine());
            double beltPrice = Double.Parse(Console.ReadLine());

            double lightsaberTotalNumber = Math.Ceiling(numberOfStudents * 1.1);
            double belsTotalNumber = numberOfStudents - numberOfStudents / 6;

            double totalPrice = lightsaberTotalNumber * lightsaberPrice + numberOfStudents * robePrice + belsTotalNumber * beltPrice;

            if (totalPrice <= budget)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(totalPrice - budget):f2}lv more.");
            }
        }
    }
}
