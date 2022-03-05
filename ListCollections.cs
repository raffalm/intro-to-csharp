using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCSharp
{
    class ListCollections
    {
        internal static void WorksWithStrings()
        {
            Console.WriteLine("***Works with strings");
            var names = new List<string> { "Rafal", "Ana", "Felipe" };

            foreach(var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
                Console.WriteLine($"Hello {name.ToUpper()}");

            Console.WriteLine($"My name is {names[0]}");
            Console.WriteLine($"I've add {names[names.Count - 2]} and {names[names.Count - 1]} to the list.");
            Console.WriteLine($"The list has {names.Count} people in it.");

            var index = names.IndexOf("Felipe");
            if (index == -1)
                Console.WriteLine($"When an index is not found, IndexOf returns {index}");
            else
                Console.WriteLine($"The name {names[index]} is at index {index}");
            index = names.IndexOf("Not found");
            if (index == -1)
                Console.WriteLine($"When an index is not found, IndexOf returns {index}");
            else
                Console.WriteLine($"The name {names[index]} is at index {index}");

            names.Sort();
            Console.WriteLine("Sorted list...");
            foreach (var name in names)
                Console.WriteLine($"Hello {name.ToUpper()}!");
        }
        internal static void WorksWithNumbers()
        {
            Console.WriteLine("*** Works with numbers ***");
            var fibonacciNumbers = new List<int> { 1, 1 };
            
            var last = fibonacciNumbers[fibonacciNumbers.Count - 1];
            var previous = fibonacciNumbers[fibonacciNumbers.Count - 2];

            fibonacciNumbers.Add(last + previous);

            foreach (var number in fibonacciNumbers)
                Console.Write(number + " ");
        }

        internal static void ChallengeAnswer()
        {
            int n = 20;
            var fibonacciNumbers = new List<int> { 1, 1 };
            
            while (fibonacciNumbers.Count < n) {
                var last = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 2];
                fibonacciNumbers.Add(last + previous);

            }
            Console.WriteLine($"The {n}th Fibonacci number is {fibonacciNumbers[n-1]}");
        }
    }
}
