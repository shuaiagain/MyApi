using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    public class IEnumeratorExt
    {
        public static void Print()
        {
            MyEnumerable aa = new MyEnumerable() { };
            foreach (var item in aa)
            {
                Console.WriteLine("{0}", item);
            }
        }
    }

    public class MyEnumerable : IEnumerable
    {
        object[] _items;
        int _index = 0;

        public void SetItems(object obj)
        {
            object[] newArr = new object[0];
        }

        public IEnumerator GetEnumerator()
        {
            return new MyIEnumerator(_items);
        }
    }

    public class MyIEnumerator : IEnumerator
    {
        object[] _obj;
        int _position;
        object _current;

        public MyIEnumerator(object[] obj)
        {
            _obj = obj;
            _position = -1;
            _current = default(object);
        }

        public object Current
        {
            get
            {
                if (_position == -1 || _obj == null || _position >= _obj.Length)
                    return new InvalidOperationException();

                return _obj[_position];
            }
        }

        public bool MoveNext()
        {
            if (_obj == null || _position >= _obj.Length - 1)
                return false;

            _position++;
            _current = _obj[_position];
            return true;
        }

        public void Reset()
        {
            _position = -1;
        }
    }

}
