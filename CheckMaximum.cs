using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum_Day15
{
    class CheckMaximum
    {
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
    }
}
