using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCSharp
{
    class BranchesAndLoops
    {
        internal static void ExploreIf()
        {
            Console.WriteLine("***Explore if***");
                int a = 5;
                int b = 3;
                if (a + b > 10)
                {
                    Console.WriteLine("The answer is greater than 10");
                }
                else
                {
                    Console.WriteLine("The answer is not greater than 10");
                }

                int c = 4;
                if ((a + b + c > 10) && (a > b))
                {
                    Console.WriteLine("The answer is greater than 10");
                    Console.WriteLine("And the first number is greater than the second");
                }
                else
                {
                    Console.WriteLine("The answer is not greater than 10");
                    Console.WriteLine("Or the first number is not greater than the second");
                }

                if ((a + b + c > 10) || (a > b))
                {
                    Console.WriteLine("The answer is greater than 10");
                    Console.WriteLine("Or the first number is greater than the second");
                }
                else
                {
                    Console.WriteLine("The answer is not greater than 10");
                    Console.WriteLine("And the first number is not greater than the second");
                }
          
        }

        internal static void ExploreLoops()
        {
            Console.WriteLine("*** Explore loops***");
            for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }
        }
        internal static void ChallengeAnswer ()
        {
            int result = 0;
            int start = 1;
            int end = 20;
            for (int i = start; i <= end; i++)
                if (i % 3 == 0) result += i;

            Console.WriteLine($"result: {result}");
            
        }
    }
}
