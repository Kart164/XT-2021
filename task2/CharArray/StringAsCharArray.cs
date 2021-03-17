using System;
using System.Collections.Generic;
using System.Text;

namespace UsefullThings
    //todo: Compare, static methods of convertation into this class, concat, override some operators, indexer, some useful methods
{
    public class StringAsCharArray: ICloneable
    {
        private char[] _chars;
        public int Length => _chars.Length;

        public StringAsCharArray():this(string.Empty)
        {
        }
        public StringAsCharArray(char[] value)
        {
            _chars = (char[])value.Clone();
            
        }
        public StringAsCharArray(string value)
        {
            _chars = value.ToCharArray();
        }


        


        public override string ToString()
        {
            var sb = new StringBuilder(_chars.Length);
            for (int i = 0; i < _chars.Length; i++)
            {
                sb.Append(_chars[i]);
            }
            return sb.ToString();
        }
        public char[] ToCharArray() =>  (char[])_chars.Clone();



        public override bool Equals(object obj)
        {
            return obj is StringAsCharArray array &&
                   EqualityComparer<char[]>.Default.Equals(_chars, array._chars) &&
                   Length == array.Length;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(_chars, Length);
        }




        public object Clone()
        {
            var arr = new char[Length];
            for (int i = 0; i < Length; i++)
            {
                arr[i] = _chars[i];
            }
            return arr;
        }
    }
}
