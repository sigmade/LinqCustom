using System;
using System.Collections.Generic;

namespace LinqCustom
{
    public static class LinqExtension
    {
        public static int CustomSum(this IEnumerable<int> source)
        {
            var sum = 0;

            foreach (var item in source)
            {
                sum += item;
            }

            return sum;
        }

        public static int CustomSum<T>(this IEnumerable<T> source, Func<T, int> func)
        {
            var sum = 0;

            foreach (var item in source)
            {
                sum += func(item);
            }

            return sum;
        }

        public static int CustomMax(this IEnumerable<int> source) 
        { 
            var maxValue = int.MinValue;

            foreach (var item in source)
            {
                if (item > maxValue)
                {
                    maxValue = item;
                }
            }

            return maxValue;
        }
    }
}
