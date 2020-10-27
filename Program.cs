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
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
            CheckingMaxGenerics<int> checkingMaxGenerics = new CheckingMaxGenerics<int>(array);
            Console.WriteLine("Maximum value in the array is : " +checkingMaxGenerics.MaximumValue(array));
        }
    }
}
