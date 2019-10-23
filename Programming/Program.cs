using System;

namespace Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 10, 50, 5, 1 };

            var obj = new Triagnle();

            Console.WriteLine(obj.Solution(A));

            Console.ReadKey();
        }


    }
}
