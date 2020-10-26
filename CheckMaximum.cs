using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum_Day15
{
    class CheckMaximum
    {
        /// <summary>
        /// Checks the maximum integer of the given three integers
        /// </summary>
        /// <param name="firstNum">The first number.</param>
        /// <param name="secondNum">The second number.</param>
        /// <param name="thirdNum">The third number.</param>
        /// <returns></returns>
        public int CheckMaximumInt (int firstNum, int secondNum, int thirdNum)
        {
            Console.Write("Maximum of the three number is : ");
            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0)
                return firstNum;
            else if (secondNum.CompareTo(thirdNum) > 0)
                return secondNum;
            else if (thirdNum.CompareTo(secondNum) > 0)
                return thirdNum;
            else
            {
                Console.WriteLine("All the integers are equal");
                return 0;
            }
        }
        /// <summary>
        /// Checks the maximum double of the given three double
        /// </summary>
        /// <param name="firstNum">The first number.</param>
        /// <param name="secondNum">The second number.</param>
        /// <param name="thirdNum">The third number.</param>
        /// <returns></returns>
        public double CheckMaximumDouble(double firstNum, double secondNum, double thirdNum)
        {
            Console.Write("Maximum of the three number is : ");
            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0)
                return firstNum;
            else if (secondNum.CompareTo(thirdNum) > 0)
                return secondNum;
            else if (thirdNum.CompareTo(secondNum) > 0)
                return thirdNum;
            else
            {
                Console.WriteLine("All the integers are equal");
                return 0;
            }
        }
        /// <summary>
        /// Checks the maximum string of the given three strings of same length
        /// </summary>
        /// <param name="firstNum">The first number.</param>
        /// <param name="secondNum">The second number.</param>
        /// <param name="thirdNum">The third number.</param>
        /// <returns></returns>
        public string CheckMaximumString (string firstNum, string secondNum, string thirdNum)
        {
            Console.Write("Maximum of the three number is : ");
            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0)
                return firstNum;
            else if (secondNum.CompareTo(thirdNum) > 0)
                return secondNum;
            else if (thirdNum.CompareTo(secondNum) > 0)
                return thirdNum;
            else
            {
                Console.WriteLine("All the integers are equal");
                return null;
            }
        }
    }
}
