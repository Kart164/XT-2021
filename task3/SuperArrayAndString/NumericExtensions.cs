using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperArrayAndString
{
    public static class NumericExtensions
    {
        /// <summary>
        /// Returns sum of all elements in array
        /// </summary>
        /// <typeparam name="T">WORKS ONLY WITH NUMERIC TYPES</typeparam>
        /// <param name="array"></param>
        /// <returns>returns double for the largest data type coverage</returns>
        public static double SumOfAllelements<T>(this T[] array) where T : unmanaged
        {
            if (IsNumeric(array[0]))
            {
                double sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    double.TryParse(array[i].ToString(), out double temp);
                    sum += temp;
                }
                return sum;
            }
            else throw new ArgumentException("this method cannot work with non-numeric data");

        }
        /// <summary>
        /// returns the average value among all the elements for this array
        /// </summary>
        /// <typeparam name="T">ONLY NUMERIC TYPES!!</typeparam>
        /// <param name="array"></param>
        /// <returns>returns double for the largest data type coverage</returns>
        public static double Median<T>(this T[] array) where T : unmanaged
        {
            if (IsNumeric(array[0]))
            {
                return array.SumOfAllelements() / array.Length;
            }
            else throw new ArgumentException("this method cannot work with non-numeric data");
        }
        /// <summary>
        /// find all Most Frequent Elements
        /// </summary>
        /// <typeparam name="T">ONLY NUMERIC TYPES</typeparam>
        /// <param name="array"></param>
        /// <returns>returns IEnumerable collection of Most Frequent Elements</returns>
        public static IEnumerable<T> MostFrequentElement<T>(this T[] array) where T: unmanaged
        {
            if (IsNumeric(array[0]))
            {
                var dict = new Dictionary<T, int>();
                foreach (var item in array)
                {
                    if (dict.ContainsKey(item))
                    {
                        dict[item]++;
                    }
                    else
                    {
                        dict.Add(item, 0);
                    }
                }
                var querry = from item in dict
                             where item.Value == dict.Values.Max()
                             select item.Key;
                return querry;
            }
            else throw new ArgumentException("this method cannot work with non-numeric data");
        }
        private static bool IsNumeric<T>(T array) where T : unmanaged
        {
            if (array is char || array is bool)
            {
                return false;
            }
            else return true;
        }



        public static void EachElement<T>(this T[] array, Func<T, T> func) where T: unmanaged
        {
            if (IsNumeric(array[0]))
            {
                if (func != null)
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = func.Invoke(array[i]);
                    }
                }
            }
        }
    }
}
