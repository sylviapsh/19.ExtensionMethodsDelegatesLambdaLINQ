using System;
using System.Linq;

namespace IntNumsDivisibleBy3And7
{
    class IntNumsDivisibleBy3And7
    {
        static void Main()
        {
            //Initialize an array of int numbers for testing purposes
            int[] numbers = new int[50];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 10;
            }

            //Lambda expression to return the numbers that are divisible by 3 and 7
            var divisibleNums = numbers.Where(x => x % 21 == 0);

            Console.WriteLine("The numbers that are divisible by 3 and 7 (lambda expression) are: ");
            foreach (var num in divisibleNums)
            {
                Console.WriteLine("{0} ", num);
            }

            //LINQ to return the numbers that are divisible by 3 and 7
            var divisibleNumsLINQ =
                from num in numbers
                where num % 21 == 0
                select num;

            Console.WriteLine("The numbers that are divisible by 3 and 7 (LINQ) are: ");
            foreach (var num in divisibleNumsLINQ)
            {
                Console.WriteLine("{0} ", num);
            }
        }
    }
}
