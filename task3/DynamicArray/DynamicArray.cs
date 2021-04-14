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
                    for (int i = 0; i < value; i++)
                    {
                        arr[i] = _array[i];
                    }
                    _array = arr;
                    Length = arr.Length;
                }
            }
        }

        #region ctors
        public DynamicArray()
        {
            _array = new T[8];
            Length = 0;
        }
        public DynamicArray(int capacity)
        {
            _array = new T[capacity];
            Length = 0;
        }
        public DynamicArray(IEnumerable<T> array)
        {
            _array = new T[array.Count()];
            int i = 0;
            foreach (var item in array)
            {
                _array[i] = item;
                i++;
            }
            Length = i;
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
            var arrCount = array.Count();
            if (arrCount + Length > Capacity)
            {
                Capacity += arrCount + Length;
            }
            foreach (var item in array)
            {
                _array[Length] = item;
                Length++;
            }
            Length--;
        }

        public bool Remove(T elem)
        {
            var oldLength = Length;
            while (_array.Contains<T>(elem))
            {
                int index = Array.IndexOf(_array, elem);
                Array.Copy(_array, index + 1, _array, index, Length - index - 1);
                _array[Length - 1] = default;
                Length--;
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
            if (Math.Abs(index) > Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index), $"{nameof(index)} outside the array boundary");
            }
            else
            {
                if (Length + 1 > Capacity)
                {
                    Capacity *= 2;
                }
                if (index < 0)
                {
                    index += Length;
                }
                Array.Copy(_array, index, _array, index + 1, Length - index);
                _array[index] = elem;
                Length++;
                return true;
            }
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
                if (Math.Abs(i) > Length - 1)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    if (i < 0)
                    {
                        i += Length;
                    }
                    return _array[i];
                }
            }
            set
            {
                if (Math.Abs(i) > Length - 1)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    if (i < 0)
                    {
                        i += Length - 1;
                    }
                    _array[i] = value;
                }
            }
        }


    }
}
