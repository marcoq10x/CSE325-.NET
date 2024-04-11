using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Variables for storing my values
            string myName = "Marco Quintero"; 
            string myLocation = "USA"; 

            //3.Interpolation 
            Console.WriteLine($"My name is {myName}, I am from {myLocation}.");

            //4. Date but not time
            Console.WriteLine($"Today's date is: {DateTime.Now.ToString("MM/dd/yyyy")}");

            //5.Days Until Christmas 
            DateTime today = DateTime.Now;
            DateTime nextChristmas = new DateTime(today.Year, 12, 25);
            if (today > nextChristmas) nextChristmas = nextChristmas.AddYears(1);
            int daysUntilChristmas = (nextChristmas - today).Days;
            Console.WriteLine($"Days until Christmas: {daysUntilChristmas}");

            //6.C# Programming Yellow Book example 2.1 Yellowbook
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("Please enter the width of the window/frame in meters:");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Please enter the height of the window/frame in meters:");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");

            //7. Prevent immediate termination for initial requirement
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey(); 
        }
    }
}
