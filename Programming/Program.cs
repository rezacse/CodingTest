using System;
using System.Collections.Generic;

namespace Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1, 2, 3, 1 };

            Console.WriteLine(Distinct(A));
            Console.ReadKey();
        }


        static int Distinct(int[] A)
        {
            int d = 0;
            var dicts = new HashSet<int>();
            foreach (var item in A)
            {
                if (!dicts.Contains(item))
                {
                    dicts.Add(item);
                    d++;
                }

            }

            return d;
        }
    }
}
