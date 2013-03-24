using System;
using System.Collections.Generic;

namespace ExtensionOfIEnumerable
{
    class ExtensionOfIEnumerableTest
    {
        static void Main(string[] args)
        {
            //Collection
            Console.WriteLine("Tests on int collection:");
            List<int> intCollection = new List<int> {4, 200, 9, 15, 1, 6, 5 };

            //Operations
            Console.WriteLine("Sum = {0}",ExtensionsOfIEnumerable.Sum(intCollection));
            Console.WriteLine("Product = {0}",ExtensionsOfIEnumerable.Product(intCollection));
            Console.WriteLine("Min element = {0}", ExtensionsOfIEnumerable.Min(intCollection));
            Console.WriteLine("Max element = {0}", ExtensionsOfIEnumerable.Max(intCollection));
            Console.WriteLine("Average = {0:F2}", ExtensionsOfIEnumerable.Average(intCollection));

            
        }
    }
}
