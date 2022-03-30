using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Generic_types.Models
{
    class MyList<T> : IEnumerable<T>
    {
        private T[] _array;
        private T[] _capArray;

        public int Count 
        { get 
            { return _array.Length; }
        }
        public int Capacity { get; set; }

        public T this[int index]
        {
            get
            { 
                return _array[index];
            }

            set
            {
                _array[index] = value; 
            }
        }
        public MyList()
        {
            _array = new T[0];
        }

        public void Add(T value)
        {
            if (Capacity != Count)
            {
                _capArray = _array;
                _array = new T[_array.Length + 1];
                for (int i = 0; i < _capArray.Length; i++)
                {
                    _array[i] = _capArray[i];
                }
                _array[_array.Length - 1] = value;
            }
        }
        public void Clear()
        {
            Array.Resize(ref _array, 0);
        }




        public void Remove(T value)
        {
            int index = IndexOf(value);
            RemoveAt(index);
        }

        public void Reverse()
        {
            T eml;
            for (int i = 0; i < _array.Length / 2; i++)
            {
                eml = _array[i];
                _array[i] = _array[_array.Length - i - 1];
                _array[_array.Length - i - 1] = eml;
            }
        }
        public void RemoveAt(int index)
        {
            for (int i = 0; i < _array.Length - 1; i++)
            {
                if (i == index)
                {
                    _array[i] = _array[i + 1];
                    Array.Resize(ref _array, _array.Length - 1);
                }
            }
        }

        public int IndexOf(T value)
        {
            for (int i = 0; i < _array.Length - 1; i++)
            {
                if (_array[i].Equals(value))
                    return i;
            }
            return -1;
        }

        public void Insert(int index, T value)
        {
            if (Capacity != Count)
            {
                for (int i = 0; i < _array.Length - 1; i++)
                {
                    if (i == index)
                    {
                        Array.Resize(ref _array, _array.Length + 1);
                        _array[i] = _array[i + 1];
                    }
                }
                _array[index] = value;
            }
        }


        public IEnumerator<T> GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
