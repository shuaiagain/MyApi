using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLib.LeetCode
{
    public class ReverseWord
    {
        //3.	请使用C# 将字符串"I am a student"按单词逆序输出"student a am I"
        public  static void Reverse(string str)
        {
            //string temp 
            
            foreach (var item in str)
            {
                
            }

            Console.WriteLine("");
        }

        /// <summary>
        /// B还未赋值，此时B=0
        /// </summary>
        static readonly int A = B * 10;
         const int B = 10;
        public static void AA()
        {
            Console.WriteLine("A = {0}; B ={1}",A,B);
            Console.ReadLine();
        }

        //2.	编写一个函数来查找字符串数组中的最长公共前缀。说明:所有输入只包含小写字母 a-z.
        public static string Test(string[] strs)
        {
            if (strs.Length == 0) return string.Empty;

            string str = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(str) != 0)
                {
                    str = str.Substring(0, str.Length - 1);//如果字符串不匹配则长度减一继续
                }
            }
            return str;
        }

        //4.	给定一个字符串，找到它的第一个不重复的字符(字母都为小写)，并返回它的索引。如果不存在，则返回空字符串
        public static int firstUniqChar(string s)
        {
            char[] chars = s.ToCharArray();
            int len = chars.Length;
            //定义数组长度为26，表示26个字母   0-25  分别表示a-z的位置
            int[] arr = new int[26];
            int count = 1;
            //遍历字符数组，任何一个字母出现一次，都在arr数组对应位置加1
            for (int i = 0; i < len; i++)
            {
                arr[chars[i] - 'a'] += count;
            }
            for (int i = 0; i < len; i++)
            {
                if (arr[chars[i] - 'a'] == 1) return i;
            }
            return -1;
        }

    }

}
