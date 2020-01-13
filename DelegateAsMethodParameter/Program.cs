using System;

namespace DelegateAsMethodParameter
{
    //A method can have a parameter of a delegate type and can invoke the delegate parameter
    class Program
    {
        //declare delegate
        public delegate void Print(int value);

        public static void PrintHelper(Print delegateFunc, int numToPrint)
        {
            //invoke the delegate
            delegateFunc(numToPrint);
        }

        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money: {0:C}", money);
        }
        static void Main(string[] args)
        {
            PrintHelper(PrintNumber, 10000);
            PrintHelper(PrintMoney, 10000);
        }
    }
}
