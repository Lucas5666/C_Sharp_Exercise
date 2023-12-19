using System;
using System.Collections.Generic;

namespace StringAndArray
{
    class StringDS
    {
        private char[] data;

        public StringDS(char[] array)
        {
            data = new char[array.Length];
            for(int i = 0; i < data.Length; i++)
            {
                data[i] = array[i];
            }
        }

        public StringDS(string str)
        {
            data = new char[str.Length];
            for(int i = 0;i < data.Length; i++)
            {
                data[i] = str[i];
            }
        }

        public char this[int index]
        {
            get
            {
                return data[index];
            }
        }

        public int GetLength()
        {
            return data.Length;
        }

        /// <summary>
        /// 如果2个字符串一样 返回0
        /// 如果当前小于s 返回 -1
        /// 如果当前大于s 返回 1
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public int Cpmpare(StringDS s)
        {
            int index = -1;
            int Len = this.GetLength() < s.GetLength() ? this.GetLength() : s.GetLength();
            for(int i = 0; i < Len; i++)
            {
                if (this[i] != s[i])
                {
                    index = i;
                    break;
                }
                
            }
            if (index != -1)
            {
                if (this[index] > s[index])
                {
                    return 1;
                }
                else
                    return -1;
            }
            else
            {
                if(this.GetLength() == s.GetLength())
                {
                    return 0;
                }
                else
                {
                    if (this.GetLength() > s.GetLength())
                    {
                        return 1;
                    }
                    else
                        return -1;
                }
            }

        }

        public StringDS Substring(int index ,int length)
        {
            char[] newData = new char[length];
            for(int i = index; i < index + length;i++)
            {
                newData[i - index] = data[i];
            }
            return new StringDS(newData);
        }

        public static StringDS Concat(StringDS s1,StringDS s2)
        {
            char[] newData = new char[s1.GetLength() + s2.GetLength()];
            for (int i = 0; i < s1.GetLength(); i++)
            {
                newData[i] = s1[i];
            }
            for (int i = s1.GetLength() - 1; i < newData.Length; i++)
            {
                newData[i] = s2[i];
            }
            return new StringDS(newData);
        }

        
    }
    
}