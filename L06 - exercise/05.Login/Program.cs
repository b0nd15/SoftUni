using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string username = Console.ReadLine();

            //char[] charArray = username.ToCharArray();
            //Array.Reverse(charArray);
            //string usernameReversed = new string(charArray);

            //while (true)
            //{

            //    string password = Console.ReadLine();

            //    count++;

            //    if (usernameReversed == password)
            //    {
            //        Console.WriteLine($"User {username} logged in.");
            //        break;
            //    }
            //    else if (count == 4)
            //    {
            //        Console.WriteLine($"User {username} blocked!");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Incorrect password. Try again.");
            //    }


            //}
            //B
            string password = "";
            for (int value = username.Length -1; value >= 0; value--)
            {
                //Console.WriteLine(username[value]);
                password += username[value];
            }
            Console.WriteLine(password);
        }
    }
}
