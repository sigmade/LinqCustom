using System;
using System.Collections.Generic;

namespace LinqCustom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, -2 };

            var sum = numbers.CustomMax();



            Console.WriteLine("Hello World!");
        }
    }
}
