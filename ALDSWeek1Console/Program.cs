using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALDSWeek1Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int num1, num2;

            Console.WriteLine("Enter 1st Number:");
            input = Console.ReadLine();
            num1 = Convert.ToInt32(input);

            Console.WriteLine("Enter 2nd Number:");
            input = Console.ReadLine();
            num2 = Convert.ToInt32(input);

            Console.WriteLine("{0} to the power of {1} is {2}", num1, num2, Power(num1, num2));
            Console.ReadKey();
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }

        static int Multiplication(int x, int y)
        {
            return x * y;
        }

        static int Power(int x, int y)
        {
            return (int)Math.Pow(x, y);
        }
    }
}
