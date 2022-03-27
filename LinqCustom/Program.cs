using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqCustom
{
    internal class Program
    {
        delegate bool CustomDel(int source);
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3 };
            var points = new List<Point>
            {
                new(){ X = 1, Y = 2 },
                new(){ X = 3, Y = 5}
            };

            //Обычный делегат
            CustomDel customDel;
            customDel = Is3;
            var three1 = numbers.Where(customDel.Invoke);

            //Делегат Func
            var filterMethod = new Func<int, bool>(Is3);
            var three2 = numbers.Where(filterMethod);

            //Анонимный метод
            var three3 = numbers.Where(delegate (int s) { return s == 3; });
            //Лямбда
            var three4 = numbers.Where((int s) => { return s == 3; });
            //Лямбда
            var three5 = numbers.Where(s => s == 3);

            var sum = numbers.CustomMax();

            var sumD = numbers.CustomSum(i => i);
            var sumD2 = points.CustomSum(i => i.X * i.Y);
        }

        public static bool Is3(int source)
        {
            return source == 3;
        }
    }

    public class Point
    {
        public int X;
        public int Y;
    }
}
