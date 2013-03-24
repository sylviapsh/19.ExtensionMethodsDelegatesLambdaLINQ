using System;
using System.Collections.Generic;
using System.Linq;

// Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.

namespace ExtensionOfIEnumerable
{
    public static class ExtensionsOfIEnumerable
    {
        public static decimal Sum<T>(this IEnumerable<T> collection) where T : IComparable, IConvertible, IComparable<T>
        {
            if (collection == null)
            {
                throw new ArgumentNullException("The collection has no elements!");
            }
            else
            {
                decimal sum = 0;
                foreach (T element in collection)
                {
                    sum = sum + (dynamic)element; 
                }

                return sum;
            }
        }

        public static decimal Product<T>(this IEnumerable<T> collection) where T : IComparable, IConvertible, IComparable<T>
        {
            if (collection == null)
            {
                throw new ArgumentNullException("The collection has no elements!");
            }
            else
            {
                decimal product = 1;
                foreach (T element in collection)
                {
                    product = product * (dynamic)element;
                }

                return product;
            }
        }

        public static T Min<T>(this IEnumerable<T> collection) where T : IComparable
        {
            if (collection == null)
            {
                throw new ArgumentNullException("The collection has no elements!");
            }
            else
            {
                return collection.OrderBy(x => x).First();
            }
        }

        public static T Max<T>(this IEnumerable<T> collection) where T : IComparable
        {
            if (collection == null)
            {
                throw new ArgumentNullException("The collection has no elements!");
            }
            else
            {
                return collection.OrderByDescending(x => x).First();
            }
        }

        public static decimal Average<T>(this IEnumerable<T> collection) where T : IComparable, IConvertible, IComparable<T>
        {
            if (collection == null)
            {
                throw new ArgumentNullException("The collection has no elements!");
            }
            else
            {
                decimal sum = Sum(collection);

                if (collection.Count<T>() == 0)
                {
                    throw new ArgumentException("The collection has no elements! Average value cannot be calculated!");
                }
                else
                {
                    decimal average = 0;
                    average = sum / collection.Count<T>();

                    return average;
                }             
            }
        }
    }
}
