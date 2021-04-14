using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    public class CycledDynamicArray<T> : DynamicArray<T>
    {
        public CycledDynamicArray() : base() { }

        public CycledDynamicArray(int value) : base(value) { }

        public CycledDynamicArray(IEnumerable<T> array) : base(array) { }

        public new IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i <= Length; i++)
            {
                if (i == Length)
                {
                    i = 0;
                }
                yield return this[i];
            }
        }
    }
}
