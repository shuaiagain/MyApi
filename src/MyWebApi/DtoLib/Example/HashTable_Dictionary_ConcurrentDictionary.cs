using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;

namespace DtoLib.Example
{
    public class HashTable_Dictionary_ConcurrentDictionary
    {
        public static void Print()
        {
            ExampleA2();
            //ExampleC();
            //ExampleB();
            //ExampleA();
        }

        public static void ExampleC()
        {
            Compare(5000000);
        }

        #region Compare
        private static void Compare(int count)
        {
            Dictionary<string, string> _dictionary = new Dictionary<string, string>();
            Hashtable _hashTable = new Hashtable(); ;
            ConcurrentDictionary<string, string> _conDictionary = new ConcurrentDictionary<string, string>();

            Stopwatch sw = new Stopwatch();

            #region 插入
            //sw.Start();
            //for (int i = 0; i < count; i++)
            //{
            //    _dictionary.Add("key" + i, "value" + i);
            //}
            //sw.Stop();
            //Console.WriteLine("_dictionary uses time = {0} seconds", sw.ElapsedMilliseconds / 1000);

            //sw.Restart();
            //for (int i = 0; i < count; i++)
            //{
            //    _hashTable.Add("key" + i, "value" + i);
            //}

            //sw.Stop();
            //Console.WriteLine("_hashTable uses time = {0} seconds", sw.ElapsedMilliseconds / 1000);

            sw.Restart();
            for (int i = 0; i < count; i++)
            {
                _conDictionary.TryAdd("key" + i, "value" + i);
            }

            sw.Stop();
            Console.WriteLine("_conDictionary uses time = {0} seconds", sw.ElapsedMilliseconds / 1000);
            #endregion

            string str = string.Empty;
            #region 插入
            //sw.Start();
            //for (int i = 0; i < _dictionary.Count; i++)
            //{
            //    str = _dictionary["key" + i];
            //}
            //sw.Stop();
            //Console.WriteLine("_dictionary search uses time = {0} seconds", sw.ElapsedMilliseconds / 1000);

            //dynamic stra = null;
            //sw.Restart();
            //for (int i = 0; i < _hashTable.Count; i++)
            //{
            //    stra = _hashTable["key" + i];
            //}

            //sw.Stop();
            //Console.WriteLine("_hashTable search uses time = {0} seconds", sw.ElapsedMilliseconds / 1000);

            sw.Restart();
            for (int i = 0; i < _conDictionary.Count; i++)
            {
                str = _conDictionary["key" + i];
            }

            sw.Stop();
            Console.WriteLine("_conDictionary search uses time = {0} seconds", sw.ElapsedMilliseconds / 1000);
            #endregion


        }

        #endregion

        #region Dictionary
        public static void ExampleB()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("1", "net1");
            dic.Add("2", "net2");
            dic.Add("3", "net3");

            try
            {
                Console.WriteLine(" dic.Contains('1','net1') = {0}", dic.Contains(new KeyValuePair<string, string>("1", "net1")));
                Console.WriteLine(" dic.ContainsKey('1','net1') = {0}", dic.ContainsKey("1"));
                Console.WriteLine(" dic.ContainsValue('1','net1') = {0}", dic.ContainsValue("net1"));
                dic.Add("1", "net1");

                dic.Remove("1");

                foreach (KeyValuePair<string, string> item in dic)
                {
                    Console.WriteLine("key = {0}，value = {1}", item.Key, item.Value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error：{0}", ex.Message);
            }
        }
        #endregion

        #region Hashtable
        private static void ExampleA()
        {
            Hashtable ht = new Hashtable();

            ht.Add("1111", "joye.net1111");
            ht.Add("111", "joye.net111");
            ht.Add("11", "joye.net11");
            ht.Add("1", "joye.net1");
            ht.Add("2", "joye.net2");
            ht.Add("3", "joye.net3");
            //ht.Remove("1");
            try
            {
                ht.Add("4", null);
                ht.Add(null, null);
                Console.WriteLine("IsFixedSize：{0}", ht.IsFixedSize);
            }
            catch (Exception ex)
            {
                Console.WriteLine("error：{0}", ex.Message);
            }

            foreach (var key in ht.Keys)
            {
                Console.WriteLine("key = {0}，value = {1} ", key, ht[key]);
            }

            Console.WriteLine("------");
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine("key= {0}，value= {1}", item.Key, item.Value);
            }
        }

        private static void ExampleA2()
        {
            Hashtable ht = new Hashtable();
            Thread t1 = new Thread(() =>
            {
                try
                {
                    ht.Add("1", "1");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error1：{0}", ex.Message);
                }
            });

            Thread t2 = new Thread(() =>
            {
                try
                {
                    ht.Add("1", "1");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error2：{0}", ex.Message);
                }
            });

            Thread t3 = new Thread(() =>
            {
                try
                {
                    ht.Add("1", "1");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error3：{0}", ex.Message);
                }
            });

            Thread t4 = new Thread(() =>
            {
                try
                {
                    ht.Add("1", "1");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error4：{0}", ex.Message);
                }
            });

            Thread t5 = new Thread(() =>
            {
                try
                {
                    ht.Add("1", "1");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error5：{0}", ex.Message);
                }
            });

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
        }
        #endregion
    }

}
