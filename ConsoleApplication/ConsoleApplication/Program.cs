using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {

            //Output two WriteLine statements that display those two variables with proper labels (My name is..., I am from...) using String Interpolation.
            string name, country;
            Console.Write("What is your name? ");
            name = Console.ReadLine();

            Console.Write("Where are you from? ");
            country = Console.ReadLine();

             Console.WriteLine($"My name is, {name}! I am from {country}");

            //Output the current date but not the current time.
            DateTime todayDate = DateTime.Now;
            Console.WriteLine("The date today " + todayDate.ToString("dd/MM/yyyy"));

            //Output the number of days until Christmas with an appropriate label.
            DateTime christmasDate = new DateTime(2018, 12, 25);
            TimeSpan daysToChristmas = christmasDate - todayDate;
            // or you can also use: TimeSpan daysToChristmas = christmasDat.Subtract(todayDate);
            Console.WriteLine("There are " + daysToChristmas.Days + "left to Christmas");

            //Add the program example from section 2.1 of the C# and
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            //1. Provide appropriate text labels when requesting dimensional input, and
            Console.Write("Introduce the width of the window: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Introduce the height of the window: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");

                Console.WriteLine("Do you want to continue (Y/N)? ");
            } while (Console.ReadLine() != "Y");
        }
    }
}
