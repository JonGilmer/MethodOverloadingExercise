using System;

namespace MethodOverloadingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Add(1.12345m, 2.564m));
            Add(0, 1, true);
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public static string Add(int x, int y, bool isTrue)
        {
            if ((isTrue == true && x + y > 1) || (isTrue == true && x + y == 0))
            {
                var dollarsReturn = $"{ x + y } dollars.";
                Console.WriteLine(dollarsReturn);
                return dollarsReturn;
            }
            else
            {
                var singleDollarReturn = $"{ x + y } dollar.";
                Console.WriteLine(singleDollarReturn);
                return singleDollarReturn;
            }
        }
    }
}
