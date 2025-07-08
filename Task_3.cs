using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static string ReadString()
        {
            Console.WriteLine("Please Enter Number String");

            string result = Console.ReadLine();
            return result;
        }

        static int ConvertStringToInt(string input)
        {
            int result;
            while (!int.TryParse(input, out result)) 
            {

            Console.WriteLine("This String Not Numbers");
                input = ReadString();
                
            }
            return result;
        }
        static int ReverseNumber(int num)
        {
            Console.WriteLine("String After Reversed: ");

            int reversed = 0;

            while (num != 0)
            {
                int digit = num % 10;         
                reversed = reversed * 10 + digit;
                num /= 10;                      
            }

            return reversed;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseNumber(ConvertStringToInt(ReadString())).ToString());
        }
    }
}
