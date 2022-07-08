using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 50;
            count = count + 1;
            Console.WriteLine(count);
            Console.WriteLine("Welcome to C#.NET...");

            Point point = new Point();
            point.X = 25;
            point.Y = 07;
            Console.WriteLine(point);

            DateTime birthDate1 = new DateTime(1997, 04, 25);
            Person p1 = new Person("Akshay", "Chorage", birthDate1, "9881234567", "abc@gmail.com");
            Console.WriteLine(p1);

            Console.Read();
        }
    }
}
