using System;

namespace NumbersCSharp
{
    class Program
    {
        static void WorkingWithIngtegers() 
        {
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);
            //subtraction
            c = a - b;
            Console.WriteLine(c);
            //division
            c = a / b;
            Console.WriteLine(c);
            //mulitiplication
            c = a * b;
            Console.WriteLine(c);
        }

        static void OrderPrecedence()
        {
           // WorkingWithIngtegers();
            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine(d);
            d = (a + b) * c;
            Console.WriteLine(d);
            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);
            int e = 7;
            int f = 4;
            int g = 3;
            int h = (e + f) / g;
            Console.WriteLine(h);
        }

        static void TestLimits()
        {
            // WorkingWithIngtegers();
            // OrderPrecedence();
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range for integers are from {min} to {max}");
            int what = max + 3;
            Console.WriteLine($"An example of overflow is {what}");
        }

        static void WorkingWithDoubles()
        {
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            Console.WriteLine(d);
            double e = 19;
            double f = 23;
            double g = 8;
            double h = (e + f) / g;
            Console.WriteLine(h);
            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"Doubles range from {min} to {max}");
            double third = 1.0 / 3.0;
            Console.WriteLine(third);
        }

        static void Main() 
        {
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"Decimals range from {min} to {max}");
            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);

            double radius = 2.50;
            double area = (radius * radius) * Math.PI;
            Console.WriteLine(area);
        }
    }
}