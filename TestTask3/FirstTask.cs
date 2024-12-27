using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask3
{
    internal class FirstTask
    {
        public static double[] GetNumbers(int count)
        {
            double[] n = new double[count];
            Random rnd = new Random();
            string numbers = "";
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = Math.Round(rnd.NextDouble() * 10, 2);
                numbers += n[i] + " ";
            }
            Console.WriteLine(numbers);
            return n;
        }
        public static void MinValue(double[] n)
        {
            double min = n[0];

            for (int i = 0; i < n.Length; i++)
            {
                if (min > n[i])
                {
                    min = n[i];
                }
            }
            Console.WriteLine("Min value: " + min);
        }
        public static void MaxValue(double[] n)
        {
            double max = n[0];

            for (int i = 0; i < n.Length; i++)
            {
                if (max < n[i])
                {
                    max = n[i];
                }
            }
            Console.WriteLine("Max value: " + max);
        }
        public static void AvgValue(double[] n)
        {
            double sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum += n[i];
            }
            double avg = Math.Round(sum / n.Length, 2);
            Console.WriteLine("Avg value: " + avg);
        }
    }
}
