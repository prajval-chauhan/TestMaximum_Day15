using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum_Day15
{
    class CheckingMaxGenerics<T> where T:IComparable
    {
        /// <summary>
        /// Member variable as the array would be taking multiple values
        /// </summary>
        public T[] array;
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckingMaxGenerics{T}"/> class.
        /// </summary>
        /// <param name="array">The array.</param>
        public CheckingMaxGenerics(T[] array)
        {
            this.array = array;
        }
        /// <summary>
        /// Sorts the array to get the max value
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns></returns>
        public T[] SortArray(T[] array)
        {
            Array.Sort(array);
            return array;
        }
        /// <summary>
        /// returns the maximum value stored at n-1 position
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns></returns>
        public T MaximumValue(T[] array)
        {
            var sortedArray = SortArray(array);
            return sortedArray[^1];
        }
        /// <summary>
        /// To call the MaximumValue method
        /// </summary>
        /// <returns></returns>
        public T MaxMethod()
        {
            var maxValue = MaximumValue(this.array);
            return maxValue;
        }
    }
}
