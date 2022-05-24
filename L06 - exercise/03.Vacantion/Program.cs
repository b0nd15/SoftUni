using System;

namespace _03.Vacantion
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = Int32.Parse(Console.ReadLine());
            string group = Console.ReadLine();
            string day = Console.ReadLine();
            
            double discount = 1.0;
            double pricePerPerson = 0.0;

            if (group == "Students")
            {
                if (day == "Friday")
                {
                    pricePerPerson = 8.45;
                }
                else if (day == "Saturday")
                {
                    pricePerPerson = 9.80;
                }
                else if (day == "Sunday")
                {
                    pricePerPerson = 10.46;
                }
                if (numberOfPeople >= 30)
                {
                    discount = 1.0 - 0.15;
                }
            }
            else if (group == "Business")
            {
                if (day == "Friday")
                {
                    pricePerPerson = 10.90;
                }
                else if (day == "Saturday")
                {
                    pricePerPerson = 15.60;
                }
                else if (day == "Sunday")
                {
                    pricePerPerson = 16;
                }
                if (numberOfPeople >= 100)
                {
                    numberOfPeople -= 10;
                }
            }
            else if (group == "Regular")
            {
                if (day == "Friday")
                {
                    pricePerPerson = 15;
                }
                else if (day == "Saturday")
                {
                    pricePerPerson = 20;
                }
                else if (day == "Sunday")
                {
                    pricePerPerson = 22.50;
                }
                if (numberOfPeople >= 10 && numberOfPeople <= 20)
                {
                    discount = 1.0 - 0.05;
                }
            }

            double groupPrice = pricePerPerson * numberOfPeople * discount;
            Console.WriteLine($"Total price: {groupPrice:F2}");
        }
    }
}

