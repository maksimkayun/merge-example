// See https://aka.ms/new-console-template for more information

using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Foo2();
        }

        public static void Foo2()
        {
            Console.WriteLine(UtilClass.Sum(1,2));
        }
    }
}