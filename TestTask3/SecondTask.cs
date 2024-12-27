using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask3
{
    internal class SecondTask
    {
        public static void FindRepeat(string str)
        {
            Console.WriteLine("String: " + str);
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == str[i + 1])
                {
                    Console.WriteLine("Symbol: " + str[i]);
                    break;
                }
            }
        }
    }
}
