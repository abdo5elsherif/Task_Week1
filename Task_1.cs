using System;

namespace Task_1
{
    internal class Program
    {
        static short ReadYear()
        {
            
            Console.WriteLine( "\nPlease enter a year? ");
            short Year = short.Parse( Console.ReadLine());
            return Year;
        }
       static bool  isLeapYear(short Year)
        { 
            return (Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(isLeapYear(ReadYear())?"Is Leap Year": "Not Leap Year");
        }
    }
}
