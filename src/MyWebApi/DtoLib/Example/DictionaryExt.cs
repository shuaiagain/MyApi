using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLib
{
    public static class DictionaryExt
    {
        private static readonly object locker;

        public static void AddExt<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, TValue value)
        {
            if (!dictionary.ContainsKey(key))
            {
                lock (locker)
                {
                    if (!dictionary.ContainsKey(key))
                        dictionary.Add(key, value);
                }
            }
        }
    }
}
