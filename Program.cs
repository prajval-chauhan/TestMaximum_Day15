using System;

namespace TestMaximum_Day15
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckMaximum call = new CheckMaximum();
            Console.WriteLine("Welcome to the practice problem of day15");
            Console.WriteLine(call.CheckMaximumInt(1,2,3));
            Console.Write(call.CheckMaximumDouble(4.100, 4.10, 4.1));
            Console.WriteLine(call.CheckMaximumString("11","22","01"));
        }
    }
}
