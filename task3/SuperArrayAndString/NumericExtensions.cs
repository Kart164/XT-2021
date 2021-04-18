using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperArrayAndString
{
    public static class NumericExtensions
    {
        #region Sum
        public static double Sum(this int[] array)
        {
            double sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                return sum;
        }
        public static double Sum(this short[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        public static double Sum(this ushort[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        public static double Sum(this byte[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        public static double Sum(this sbyte[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        public static double Sum(this uint[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        public static double Sum(this long[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        public static double Sum(this ulong[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        public static double Sum(this float[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        public static double Sum(this double[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        public static double Sum(this decimal[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            { 
                sum += Convert.ToDouble(array[i]);
            }
            return sum;
        }
        #endregion
        #region Average
        public static double Average(this byte[] array)
        {
                return array.Sum() / array.Length;
        }
        public static double Average(this sbyte[] array)
        {
            return array.Sum() / array.Length;
        }
        public static double Average(this short[] array)
        {
            return array.Sum() / array.Length;
        }
        public static double Average(this ushort[] array)
        {
            return array.Sum() / array.Length;
        }
        public static double Average(this int[] array)
        {
            return array.Sum() / array.Length;
        }
        public static double Average(this uint[] array)
        {
            return array.Sum() / array.Length;
        }
        public static double Average(this long[] array)
        {
            return array.Sum() / array.Length;
        }
        public static double Average(this ulong[] array)
        {
            return array.Sum() / array.Length;
        }
        public static double Average(this float[] array)
        {
            return array.Sum() / array.Length;
        }
        public static double Average(this double[] array)
        {
            return array.Sum() / array.Length;
        }
        public static double Average(this decimal[] array)
        {
            return array.Sum() / array.Length;
        }
        #endregion
        #region MostFrequentElement
        public static IEnumerable<byte> MostFrequentElements(this byte[] array)
        {
                var dict = new Dictionary<byte, int>();
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
            var maxCount = dict.Values.Max();
            var querry = dict.Where(x => x.Value == maxCount).Select(x=>x.Key);
                return querry;
        }
        public static IEnumerable<sbyte> MostFrequentElements(this sbyte[] array)
        {
            var dict = new Dictionary<sbyte, int>();
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
            var maxCount = dict.Values.Max();
            var querry = dict.Where(x => x.Value == maxCount).Select(x => x.Key);
            return querry;
        }
        public static IEnumerable<short> MostFrequentElements(this short[] array)
        {
            var dict = new Dictionary<short, int>();
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
            var maxCount = dict.Values.Max();
            var querry = dict.Where(x => x.Value == maxCount).Select(x => x.Key);
            return querry;
        }
        public static IEnumerable<ushort> MostFrequentElements(this ushort[] array)
        {
            var dict = new Dictionary<ushort, int>();
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
            var maxCount = dict.Values.Max();
            var querry = dict.Where(x => x.Value == maxCount).Select(x => x.Key);
            return querry;
        }
        public static IEnumerable<int> MostFrequentElements(this int[] array)
        {
            var dict = new Dictionary<int, int>();
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
            var maxCount = dict.Values.Max();
            var querry = dict.Where(x => x.Value == maxCount).Select(x => x.Key);
            return querry;
        }
        public static IEnumerable<uint> MostFrequentElements(this uint[] array)
        {
            var dict = new Dictionary<uint, int>();
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
            var maxCount = dict.Values.Max();
            var querry = dict.Where(x => x.Value == maxCount).Select(x => x.Key);
            return querry;
        }
        public static IEnumerable<long> MostFrequentElements(this long[] array)
        {
            var dict = new Dictionary<long, int>();
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
            var maxCount = dict.Values.Max();
            var querry = dict.Where(x => x.Value == maxCount).Select(x => x.Key);
            return querry;
        }
        public static IEnumerable<ulong> MostFrequentElements(this ulong[] array)
        {
            var dict = new Dictionary<ulong, int>();
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
            var maxCount = dict.Values.Max();
            var querry = dict.Where(x => x.Value == maxCount).Select(x => x.Key);
            return querry;
        }
        public static IEnumerable<float> MostFrequentElements(this float[] array)
        {
            var dict = new Dictionary<float, int>();
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
            var maxCount = dict.Values.Max();
            var querry = dict.Where(x => x.Value == maxCount).Select(x => x.Key);
            return querry;
        }
        public static IEnumerable<double> MostFrequentElements(this double[] array)
        {
            var dict = new Dictionary<double, int>();
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
            var maxCount = dict.Values.Max();
            var querry = dict.Where(x => x.Value == maxCount).Select(x => x.Key);
            return querry;
        }
        public static IEnumerable<decimal> MostFrequentElements(this decimal[] array)
        {
            var dict = new Dictionary<decimal, int>();
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
            var maxCount = dict.Values.Max();
            var querry = dict.Where(x => x.Value == maxCount).Select(x => x.Key);
            return querry;
        }
        #endregion

        public static void EachElement<T>(this T[] array, Func<T, T> func) where T : unmanaged
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
