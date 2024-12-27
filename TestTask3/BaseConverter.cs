using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask3
{
    internal class BaseConverter
    {
        public static double convert(string convName, double c)
        {
            switch (convName)
            {
                case "Фаренгейты":
                    return c * 1.8 + 32;
                case "Кельвины":
                    return c + 273.15;
                default:
                    Console.WriteLine("Такого варианта нет");
                    return 0;
            }
            
        }
    }
}
