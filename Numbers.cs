using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCSharp
{
    class Numbers
    {
        internal static void WorkWithIntegers()
        {

            int a = 24;
            int b = 3;
            int c = a + b;
            Console.WriteLine("***Work with integers***");
            Console.WriteLine(c);

            //subtraction
            Console.WriteLine(a - b);
            //multiplication
            Console.WriteLine(a * b);
            //division
            Console.WriteLine(a / b);
        }
        internal static void OrderPrecedence()
        {
            Console.WriteLine("***Order Precedence***");
            int a = 5;
            int b = 4;
            int c = 2;

            int d = a + b * c;
            Console.WriteLine($"{a}+{b}*{c}={d}");

            d = (a + b) * c;
            Console.WriteLine($"({a}+{b})*{c}={d}");

            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine($"({a} + {b}) - 6 * {c} + (12 * 4) / 3 + 12={d}");

            a = 7;
            b = 4;
            c = 3;
            d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: ({a} + {b}) / {c} = {d}");
            Console.WriteLine($"remainder: ({a} + {b}) % {c} = {e}");
        }

        internal static void TestLimits()
        {
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine("***Test Limits***");
            Console.WriteLine($"The range of integers is {min} to {max}");

            int what = max + 3;
            Console.WriteLine($"An example of overflow: int.MaxValue + 3 = {what}");
        }

        internal static void WorkWithDoubles()
        {
            double e = 19;
            double f = 23;
            double g = 8;
            double h = (e + f) / g;
            Console.WriteLine("***Work wit doubles***");
            Console.WriteLine($"({e}+{f})/{g} = {h}");

            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");

            double third = 1.0 / 3.0;
            Console.WriteLine($"third: 1.0/3.0 = {third}");
        }

        internal static void WorkWithDecimals()
        {
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine("***Work with decimals");
            Console.WriteLine($"The range of the decimal type is {min} to {max}");

            double a = 1.0;
            double b = 3.0;
            Console.WriteLine($"Doubles - third: {a / b}");

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine($"Decimals - third: {c / d}");

            //chalenge
            double radius = 2.5;
            Console.WriteLine($"Area of the circle whose radius is {radius} cm equals {radius * radius * Math.PI} cm2");
        }
    }
}
