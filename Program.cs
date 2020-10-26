using System;

namespace TestMaximum_Day15
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckMaximum call = new CheckMaximum();
            Console.WriteLine("Welcome to the practice problem of day15");
            Console.Write(call.CheckMaximumInt(4, 4, 4)); 
        }
    }
}
