using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask4
{
    class Program
    {
        // Task: calculate the infinite sum of 1/i^8 + 1/(i+1)^8 + 1/(i+2)^8... until 1/(i+n)^8 less than epsilon (e).
        // Student: Subbotin Alexey. Group: SE-17-1.
        static void Main(string[] args)
        {
            // Epsilon
            double e;

            // Getting the epsilon.
            bool ok;
            do
            {
                Console.Write("Enter the accutacy (epsilon): ");
                ok = Double.TryParse(Console.ReadLine(), out e);
                if (!ok || e <= 0)
                    Console.WriteLine("Input error! Perhaps you didn't enter a real number greater than 0");
            } while (!ok || e <= 0);

            // The sum.
            double sum = 0;
            // i.
            int i = 1;

            // While greater or equals e.
            while(1 / Math.Pow(i, 8) >= e)
            {
                sum += 1 / Math.Pow(i, 8);
                i++;
            }

            Console.WriteLine("Result: {0}", sum);
            Console.ReadLine();
        }
    }
}
