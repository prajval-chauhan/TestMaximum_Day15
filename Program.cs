using System;
using System.Diagnostics.CodeAnalysis;

namespace TestMaximum_Day15
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckMaximum call = new CheckMaximum();
            Console.WriteLine("Welcome to the practice problem of day15");
            //Usin non generic methods to compare
            Console.WriteLine(call.CheckMaximumInt(1,2,3));
            Console.WriteLine(call.CheckMaximumDouble(1.1,1.2,1.111));
            Console.WriteLine(call.CheckMaximumString("11","22","33"));
            //Using generic method to compare
            Console.WriteLine(call.CheckMaximumGeneric<int>(1, 2, 3));
            Console.WriteLine(call.CheckMaximumGeneric<string>("22","22","22"));
            Console.WriteLine(call.CheckMaximumGeneric<double>(1.1,1.11,1.111));
            //using generic class to compare multiple values
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
            CheckingMaxGenerics<int> checkingMaxGenerics = new CheckingMaxGenerics<int>(array);
            Console.WriteLine("Maximum value in the array is : " +checkingMaxGenerics.MaximumValue(array));
        }
    }
}
