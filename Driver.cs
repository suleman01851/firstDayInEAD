using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstDayInEAD
{
    class Driver
    {
        public static void sum1()
        {
            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum of {0} and {1} is {2}", num1, num2, num1 + num2);
        }

        public static int sum2(int num1, int num2)
        {
            return num1 + num2;
        }

        public static void sum3(int num1, int num2)
        {
            Console.WriteLine("Sum of {0} and {1} is {2}", num1, num2, num1 + num2);
        }

        public static int sum4()
        {
            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            return num1 + num2;
        }

        private static void Main()
        {
            sum1();


            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum of {0} and {1} is {2}", num1, num2, sum2(num1, num2));


            sum3(num1, num2);

            int hum = sum4();


        }
    }
}
