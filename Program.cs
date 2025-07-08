using System;
using System.Linq;


namespace Task_2
{
    internal class Program
    {
        public static int MultiplicationAllMemmbers(int[] arr )
        {
            int result = arr
              .Where(num => num != 0)     
              .Aggregate(1, (all, num) => all * num);
            return result;
        }
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 0, 4, 5 };

            Console.WriteLine("Result : " + MultiplicationAllMemmbers(arr));

        }
    }
}
