using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace UsefullThings
    //todo: Compare, concat, override some operators, some useful methods
{
    public class StringAsCharArray : IComparable<string>, IComparable<StringAsCharArray>, ICloneable, IEquatable<StringAsCharArray>, IEquatable<string>
    {
        private char[] _chars;
        public int Length => _chars.Length;
        public char this[int i]
        {
            get => _chars[i];
            set => _chars[i] = value;
        }
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


        

        //block with Convertation methods
        public override string ToString()
        {
            var sb = new StringBuilder(_chars.Length);
            for (int i = 0; i < Length; i++)
            {
                sb.Append(this[i]);
            }
            return sb.ToString();
        }
        public char[] ToCharArray() =>  MakeCopyOfCharArray();
        public static StringAsCharArray ConvertFromCharArray(char[] array)
        {
            return new StringAsCharArray(array);
        }
        public static StringAsCharArray ConvertFromString(string str)
        {
            return new StringAsCharArray(str);
        }


        //block of Equals and Compare methods
        public override bool Equals(object obj)
        {
            if (obj is string str)
            {
                    if (Length == str.Length)
                    {
                        for (int i = 0; i < Length; i++)
                        {
                            if (this[i] != str[i])
                                return false;
                        }
                        return true;
                    }
                    else return false;
            }
            else if (obj is char[] array)
                {
                    if (Length == array.Length)
                    {
                        for (int i = 0; i < Length; i++)
                        {
                            if (this[i] != array[i])
                                return false;
                        }
                        return true;
                    }
                    else return false;
            }
            else return false;
        }
        public bool Equals(string str)
        {
            if (Length == str.Length)
            {
                for (int i = 0; i < Length; i++)
                {
                    if (this[i] != str[i])
                        return false;
                }
                return true;
            }
            else return false;
        }
        public bool Equals(StringAsCharArray stringAsCharArray)
        {
            if (Length == stringAsCharArray.Length)
            {
                for (int i = 0; i < Length; i++)
                {
                   if (this[i] != stringAsCharArray[i])
                        return false;
                }
                return true;
            }
            else return false;
        }
        public int CompareTo(string other)
        {
            if (Equals(other))
                return 0;
            else
            {
                var length = Length >= other.Length ? Length : other.Length;
                for (int i = 0; i < length; i++)
                {
                    if (this[i] < other[i])
                    {
                        return -1;
                    }
                }
                if (length == other.Length)
                    return 1;
                else return -1;
            }
        }
        public int CompareTo(StringAsCharArray other)
        {
            if (Equals(other))
                return 0;
            else
            {
                var length = Length >= other.Length ? Length : other.Length;
                for (int i = 0; i < length; i++)
                {
                    if (this[i] < other[i])
                    {
                        return -1;
                    }
                }
                if (length == other.Length)
                    return 1;
                else return -1;
            }
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(_chars, Length);
        }


        
        
        
        
        
        
        public void Concat(StringAsCharArray value)
        {
            var temp = new char[Length + value.Length];
            for (int i = 0; i < Length; i++)
            {
                temp[i] = this[i];
            }
            for (int i = Length, j = 0; i < value.Length+Length; i++, j++)
            {
                temp[i] = value[j];
            }
            _chars = temp;
        }







        //block with cloning methods
        protected char[] MakeCopyOfCharArray()
        {
            var arr = new char[Length];
            for (int i = 0; i < Length; i++)
            {
                arr[i] = this[i];
            }
            return arr;
        }
        public object Clone()
        {
            return (object)new StringAsCharArray(_chars);
        }


        public static bool operator <(StringAsCharArray left, string right)
        {
            return left.CompareTo(right) < 0;
        }

        public static bool operator <=(StringAsCharArray left, string right)
        {
            return left.CompareTo(right) <= 0;
        }

        public static bool operator >(StringAsCharArray left, string right)
        {
            return left.CompareTo(right) > 0;
        }

        public static bool operator >=(StringAsCharArray left, string right)
        {
            return left.CompareTo(right) >= 0;
        }

        public static bool operator <(StringAsCharArray left, StringAsCharArray right)
        {
            return left.CompareTo(right) < 0;
        }

        public static bool operator <=(StringAsCharArray left, StringAsCharArray right)
        {
            return left.CompareTo(right) <= 0;
        }

        public static bool operator >(StringAsCharArray left, StringAsCharArray right)
        {
            return left.CompareTo(right) > 0;
        }

        public static bool operator >=(StringAsCharArray left, StringAsCharArray right)
        {
            return left.CompareTo(right) >= 0;
        }
    }

}
