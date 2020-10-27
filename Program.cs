using System;

namespace TestMaximum_Day15
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckMaximum call = new CheckMaximum();
            Console.WriteLine("Welcome to the practice problem of day15");
            Console.WriteLine(call.CheckMaximumGeneric<int>(1, 2, 3));
            Console.WriteLine(call.CheckMaximumGeneric<string>("22","22","22"));
            Console.WriteLine(call.CheckMaximumGeneric<double>(1.1,1.11,1.111));
        }
    }
}
