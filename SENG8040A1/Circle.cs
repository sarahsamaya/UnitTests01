using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENG8040A1
{

        public class Circle
        {
            public double Radius { get; set; }

            public Circle()
            {
                Radius = default(double);
            }

            public Circle(double radius)
            {
                Radius = radius >= 0 ? radius : default(double);
            }

            public double SubtractFromRadius(double num)
            {
                Console.Clear();
                if (!(Radius - num < 0) && num >= 0)
                    Radius -= num;
                else
                    Console.WriteLine("Unable to perform this operation, radius cannot be negative");
            return (Radius);
            }

            public double AddToRadius(double num)
            {
                Console.Clear();
                if (num >= 0) Radius += num;
                else
                    Console.WriteLine("Unable to perform this operation, radius cannot be negative");
            return (Radius);
            }

            public double GetCircumference() => Math.Round(2 * Math.PI * Radius,2);
            public double GetArea() => Math.Round(Math.PI * Radius * Radius,2);
        }
}


