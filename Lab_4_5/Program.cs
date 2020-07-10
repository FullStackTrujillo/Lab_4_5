using System;
using System.Collections.Generic;

namespace Lab_4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Step 1");
            List<int> scores = new List<int>();
            scores.Add(4400);
            scores.Add(8900);
            scores.Add(1200);
            scores.Add(3700);
            scores.Add(7200);

            foreach (int s in scores)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Step 2");

            scores.Sort();

            foreach (int s in scores)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Step 3");

            scores.Reverse();

            foreach (int s in scores)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Step 4");

            scores.Add(2400);

            foreach (int s in scores)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Step 5");

            scores.Remove(4400);

            foreach (int s in scores)
            {
                Console.WriteLine(s);
            }
 





        }
    }
}
