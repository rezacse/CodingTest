using Programming.HackerRank;
using System;

namespace Programming
{
    class Program
    {
        static void Main(string[] args)
        {

            //var obj = new ArrayManipulation();
            //var a = new int[3][];
            //a[0] = new int[] { 1, 2, 100 };
            //a[1] = new int[] { 2, 5, 100 };
            //a[2] = new int[] { 3, 4, 100 };
            var obj = new MinimumSwap();

            int[] a = { 7, 1, 3, 2, 4, 5, 6 };
            Console.WriteLine(obj.Solution(a));

            Console.ReadKey();
        }


    }
}
