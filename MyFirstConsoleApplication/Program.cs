using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main()
        {
            // Create two variables to store your values
            string name = "Brienna Sambrano", location = "Utah";

            // Output two WriteLine statements that display those using String Interpolation.
            Console.WriteLine("My name is " + name);
            Console.WriteLine("I am from " + location);

            // Output the current date, but not the current time. (Ex: 04 / 06 / 1830)
            DateTime currentDate = DateTime.Today;
            Console.WriteLine("Today is " + currentDate.ToString("d"));

            // Output the number of days until Christmas this year
            DateTime christmasThisYear = new DateTime(2023, 12, 25);
            TimeSpan timeUntilChristmas = christmasThisYear - currentDate;
            int daysUntilChristmas = timeUntilChristmas.Days;
            Console.WriteLine("There are " + daysUntilChristmas  + " days until Christmas.");

            // Add the program example from section 2.1 in the C# Programming Yellow Book by Rob Miles.
            // Provide appropriate text labels when requesting dimensional input.
            // Cause the program to pause in the console so that the application does not automatically terminate when launched from the Visual Studio run debugger tool.

            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.WriteLine("Try the window glazer calculator");
            Console.Write("What is the width of the window? ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.Write("What is the height of the window? ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");
            Console.ReadKey();



        }
    }
}
