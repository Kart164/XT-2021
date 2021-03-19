using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace UsefullThings
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
            var temp = new char[Length + value.Length-1];
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
        public void Concat(string value)
        {
            var temp = new char[Length + value.Length-1];
            for (int i = 0; i < Length; i++)
            {
                temp[i] = this[i];
            }
            for (int i = Length, j = 0; i < value.Length + Length; i++, j++)
            {
                temp[i] = value[j];
            }
            _chars = temp;
        }


        //searching methods
        public bool Contains(char value)
        {
            for (int i = 0; i < Length; i++)
            {
                if (this[i]==value)
                {
                    return true;
                }
            }
            return false;
        }
        public bool Contains(string value)
        {
            if (Length >= value.Length)
                if (Equals(value))
                    return true;
                else
                {
                    var partOfStringLength = 0;
                    for (int i = 0, j = 0; i < Length; i++, j++)
                    {
                        if (this[i] == value[j]) 
                        {
                            partOfStringLength++;
                        }
                        else if(partOfStringLength==value.Length)
                        {
                            return true;
                        }
                        else
                        {
                            partOfStringLength=0;
                        }
                    }
                }
            return false;
        }
        public bool Contains(StringAsCharArray value)
        {
            if (Length >= value.Length)
                if (Equals(value))
                    return true;
                else
                {
                    var partOfStringLength = 0;
                    for (int i = 0, j = 0; i < Length; i++, j++)
                    {
                        if (this[i] == value[j])
                        {
                            partOfStringLength++;
                        }
                        else if (partOfStringLength == value.Length)
                        {
                            return true;
                        }
                        else
                        {
                            partOfStringLength = 0;
                        }
                    }
                }
            return false;
        }
        public int IndexOf(char value)
        {
            for (int i = 0; i < Length; i++)
            {
                if (this[i]==value)
                {
                    return i;
                }
            }
            return -1;
        }
        public int IndexOf(char value, int startIndex)
        {
            if(startIndex<Length)    
            for (int i = startIndex; i < Length; i++)
            {
                if (this[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
        public int IndexOf(string value)
        {
            if (Length >= value.Length) 
            { 
                    for (int i = 0, j = 0; i < Length; i++, j++)
                    {
                        if (this[i] != value[j])
                        {
                            j=0;
                        }
                        else if (j == value.Length)
                        {
                            return i-j;
                        }
                    }
            }
            return -1;
        }
        public int IndexOf(string value, int startIndex)
        {
            if(startIndex<Length)
            if (Length-startIndex >= value.Length)
            {
                for (int i = startIndex, j = 0; i < Length; i++, j++)
                {
                    if (this[i] != value[j])
                    {
                        j = 0;
                    }
                    else if (j == value.Length)
                    {
                        return i - j;
                    }
                }
            }
            return -1;
        }
        public int IndexOf(StringAsCharArray value)
        {
            if (Length >= value.Length)
            {
                for (int i = 0, j = 0; i < Length; i++, j++)
                {
                    if (this[i] != value[j])
                    {
                        j = 0;
                    }
                    else if (j == value.Length)
                    {
                        return i - j;
                    }
                }
            }
            return -1;
        }
        public int IndexOf(StringAsCharArray value, int startIndex)
        {
            if (startIndex < Length)
                if (Length - startIndex >= value.Length)
                {
                    for (int i = startIndex, j = 0; i < Length; i++, j++)
                    {
                        if (this[i] != value[j])
                        {
                            j = 0;
                        }
                        else if (j == value.Length)
                        {
                            return i - j;
                        }
                    }
                }
            return -1;
        }
        public int LastIndexOf(char value)
        {
            for (int i = Length-1; i >=0; i--)
            {
                if (this[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
        public int LastIndexOf(char value,int startIndex)
        {
            if (startIndex<Length)
            for (int i = Length - 1; i >=startIndex; i--)
            {
                if (this[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
        public int LastIndexOf(string value)
        {
            if(Length>=value.Length)
            for (int i = Length - 1,j=value.Length-1; i >= 0; i--,j--)
            {
                    if (this[i] != value[j])
                    {
                        j = value.Length - 1;
                    }
                    else if (j == 0)
                    {
                        return i;
                    }
                }
            return -1;
        }
        public int LastIndexOf(string value,int startIndex)
        {
            if (Length >= value.Length)
                for (int i = Length - 1, j = value.Length - 1; i >= startIndex; i--, j--)
                {
                    if (this[i] != value[j])
                    {
                        j = value.Length - 1;
                    }
                    else if (j == 0)
                    {
                        return i;
                    }
                }
            return -1;
        }
        public int LastIndexOf(StringAsCharArray value)
        {
            if (Length >= value.Length)
                for (int i = Length - 1, j = value.Length - 1; i >= 0; i--, j--)
                {
                    if (this[i] != value[j])
                    {
                        j = value.Length - 1;
                    }
                    else if (j == 0)
                    {
                        return i;
                    }
                }
            return -1;
        }
        public int LastIndexOf(StringAsCharArray value, int startIndex)
        {
            if (Length >= value.Length)
                for (int i = Length - 1, j = value.Length - 1; i >= startIndex; i--, j--)
                {
                    if (this[i] != value[j])
                    {
                        j = value.Length - 1;
                    }
                    else if (j == 0)
                    {
                        return i;
                    }
                }
            return -1;
        }

        public void Replace(char oldChar,char newChar)
        {
            for (int i = 0; i < Length; i++)
            {
                if (this[i] == oldChar)
                    this[i] = newChar;
            }
        }
        public void Replace(char oldChar, char newChar, int startIndex)
        {
            if(startIndex<Length)
            for (int i = startIndex; i < Length; i++)
            {
                if (this[i] == oldChar)
                    this[i] = newChar;
            }
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

        //operators block
        public static bool operator <(StringAsCharArray left, string right) => left.CompareTo(right) < 0;
        public static bool operator <=(StringAsCharArray left, string right) => left.CompareTo(right) <= 0;
        public static bool operator >(StringAsCharArray left, string right) => left.CompareTo(right) > 0;
        public static bool operator >=(StringAsCharArray left, string right) => left.CompareTo(right) >= 0;
        public static bool operator <(StringAsCharArray left, StringAsCharArray right) => left.CompareTo(right) < 0;
        public static bool operator <=(StringAsCharArray left, StringAsCharArray right) => left.CompareTo(right) <= 0;
        public static bool operator >(StringAsCharArray left, StringAsCharArray right) => left.CompareTo(right) > 0;
        public static bool operator >=(StringAsCharArray left, StringAsCharArray right) => left.CompareTo(right) >= 0;
        public static bool operator ==(StringAsCharArray left, StringAsCharArray right) => left.Equals(right);
        public static bool operator !=(StringAsCharArray left, StringAsCharArray right) => !left.Equals(right);
    }

}
