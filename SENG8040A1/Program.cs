using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENG8040A1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SENG8040 Assignment 1");
            Console.WriteLine("Please enter the initial radius:");
            double radius;
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out radius) && radius >= 0)
                    break;

                Console.Clear();
                Console.WriteLine("Incorrect input");
                Console.WriteLine("Please, insert the initial radius:");
            }

            Console.Clear();
            var circle = new Circle(radius);
            while (true)
            {
                DisplayRadius(circle);
                DisplayMenu();
                double tryParseResult;
                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        for (;;)
                        {
                            Console.Clear();
                            DisplayRadius(circle);
                            Console.WriteLine("\nPlease enter the number you want to add to the current radius:");
                            if (!double.TryParse(Console.ReadLine(), out tryParseResult)) continue;
                            circle.AddToRadius(tryParseResult);
                            break;
                        }

                        break;
                    case '2':
                        for (;;)
                        {
                            Console.Clear();
                            DisplayRadius(circle);
                            Console.WriteLine("\nPlease, enter the number you want to subtract from the current radius:");
                            if (!double.TryParse(Console.ReadLine(), out tryParseResult)) continue;
                            circle.SubtractFromRadius(tryParseResult);
                            break;
                        }

                        break;
                    case '3':
                        Console.Clear();
                        Console.WriteLine($"\nThe circle circumference is {circle.GetCircumference()} m");
                        break;
                    case '4':
                        Console.Clear();
                        Console.WriteLine($"\nThe circle area is {circle.GetArea()} m^2");
                        break;
                    case '5':
                        Environment.Exit(0);
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please, make your selection...");
                        break;
                }
            }
        }

        private static void DisplayRadius(Circle circle) => Console.WriteLine($"Current radius: {circle.Radius}");

        private static void DisplayMenu() => Console.WriteLine
        (@"
        Make your selection:
        1. Add to Circle Radius
        2. Subtract from Circle Radius
        3. Calculate Circle Circumference
        4. Calculate Circle Area
        5. Exit "
        );
    }
    
}
