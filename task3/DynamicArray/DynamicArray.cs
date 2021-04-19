using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    public class DynamicArray<T> : IEnumerable<T>, IEnumerable, ICloneable
    {
        private T[] _array;
        public int Length { get; private set; }
        public int Capacity
        {
            get => _array.Length;
            set
            {
                ChangeCapacity(value);
            }
        }


        #region ctors
        public DynamicArray() : this(8)
        {
            Length = 0;
        }
        public DynamicArray(int capacity)
        {
            _array = new T[capacity];
            Length = 0;
        }
        public DynamicArray(IEnumerable<T> array)
        {
            var arr = array.ToArray();
            _array = new T[arr.Length];
            Array.Copy(arr, _array, arr.Length);
            Length = arr.Length;
        }
        #endregion

        public void Add(T item)
        {
            if (Length == Capacity)
            {
                Capacity *= 2;
            }
            _array[Length] = item;
            Length++;
        }

        public void AddRange(IEnumerable<T> array)
        {
            var arr = array.ToArray();
            if (arr.Length + Length > Capacity)
            {
                Capacity += arr.Length + 8;
            }
            Array.Copy(arr, 0, _array, Length, arr.Length);
            Length += arr.Length;
        }

        public bool Remove(T elem)
        {
            var oldLength = Length;
            int index = Array.IndexOf(_array, elem);
            while (index > -1)
            {
                Array.Copy(_array, index + 1, _array, index, Length - index - 1);
                Length--;
                index = Array.IndexOf(_array, elem);
            }
            if (oldLength == Length)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool Insert(T elem, int index)
        {
            index = IndexResolver(index) + 1;
            if (Length + 1 > Capacity)
            {
                Capacity *= 2;
            }
            Array.Copy(_array, index, _array, index + 1, Length - index);
            _array[index] = elem;
            Length++;
            return true;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Length; i++)
            {
                yield return _array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public object Clone()
        {
            return new DynamicArray<T>(_array);
        }

        public T[] ToArray()
        {
            var arr = new T[Length];
            for (int i = 0; i < Length; i++)
            {
                arr[i] = _array[i];
            }
            return arr;
        }

        public T this[int i]
        {
            get
            {
                i = IndexResolver(i);
                return _array[i];
            }
            set
            {
                i = IndexResolver(i);
                _array[i] = value;
            }
        }

        /// <summary>
        /// this method allows you to change the capacity of the array. If you set the capacity less 
        /// than the current one, some of the data will be deleted
        /// </summary>
        /// <param name="value">new capacity</param>
        private void ChangeCapacity(int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("capacity can't be negative or equalss 0", nameof(value));
            }
            else
            {
                if (value > Capacity)
                {
                    var arr = new T[value];
                    _array.CopyTo(arr, 0);
                    _array = arr;
                }
                else
                {
                    var arr = new T[value];
                    Array.Copy(_array, arr, value);
                    _array = arr;
                    Length = arr.Length;
                }
            }
        }
        private int IndexResolver(int i)
        {
            if (Math.Abs(i) >= Length)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                if (i >= 0)
                {
                    return i;
                }
                else
                {
                    return Length + i - 1;
                }
            }
        }

    }
}
