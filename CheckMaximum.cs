using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum_Day15
{
    class CheckMaximum
    {
        /// <summary>
        /// Checks the maximum method generic
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="firstNum">The first number.</param>
        /// <param name="secondNum">The second number.</param>
        /// <param name="thirdNum">The third number.</param>
        /// <returns></returns>
        public T CheckMaximumGeneric<T>(T firstNum, T secondNum, T thirdNum) where T:IComparable
        {
            Console.Write("Maximum of the three values is : ");
            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0)
                return firstNum;
            else if (secondNum.CompareTo(thirdNum) > 0)
                return secondNum;
            else if (thirdNum.CompareTo(secondNum) > 0)
                return thirdNum;
            else
            {
                Console.WriteLine("All the values are equal");
                return default;
            }
        }
    }
}
