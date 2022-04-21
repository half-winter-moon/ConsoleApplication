// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2.
            string name = "Jennie Handy";
            string location = "North Carolina";

            // 3.
            Console.WriteLine($"Hello, my name is {name}. I am from {location}.");

            // 4.
            DateTime today = DateTime.Today;
            Console.WriteLine($"Today is {today.ToString("MMMM dd, yyyy")}.");

            // 5.
            // today.Year
            DateTime christmasDay = new DateTime(today.Year, 12, 25);
            TimeSpan difference = christmasDay - today;

            Console.WriteLine($"There are {difference.TotalDays} days until Christmas.");

            // 6. 
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("Please enter the width of your window in meters: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Please enter the height of your window in meters: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");


            // 7.
            Console.WriteLine("Press any key to end.");
            Console.ReadKey();
        }
    }
}