using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Все задания раскидал по разным классам, кроме четвертого, так как сказали просто написать метод, я написал метод
            // Валидацию в тз не просили, ее тут почти нет
            Console.WriteLine("First task");    ///////////// Первое задание, класс FirstTask
            double[] n = FirstTask.GetNumbers(16);
            FirstTask.MinValue(n);
            FirstTask.MaxValue(n);
            FirstTask.AvgValue(n);


            Console.WriteLine("\nSecond task"); ///////////// Второе задание, класс SecondTask
            SecondTask.FindRepeat("Hello");


            Console.WriteLine("\nThird task"); ///////////// Третье задание, класс BaseConverter
            Console.Write("\"Кельвины\" или \"Фаренгейты\": ");
            string str = Console.ReadLine();
            Console.WriteLine("Ваши градусы в Цельсию: ");
            double c = double.Parse(Console.ReadLine());


            Console.WriteLine("\nFourth task"); ///////////// Четвертое задание, метод GetDegree
            Console.Write("Часы: ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Минуты: ");
            int minutes = int.Parse(Console.ReadLine());
            Console.WriteLine(GetDegree(hours, minutes));
        }
        private static double GetDegree(int hours, int minutes)
        {
            if(minutes == 60)
                minutes = 0;
            double hourDegree = (double)hours * 30 + (double)minutes / 60; // "minutes / 60" если часовая стрелка часов указывает промежуточное значение, а не точное
            double minuteDegree = minutes * 6;
            double resultDegree = Math.Round(Math.Abs(minuteDegree - hourDegree), 0);
            if (resultDegree > 180)
                return 360 - resultDegree;
            else
                return resultDegree;
        }
    }
}
