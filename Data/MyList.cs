using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary;

public class MyList<T> : IEnumerable<T>
{
    private readonly T[] _array;
    private int _length = 0;

    public MyList(int capacity = 100)
    {
        _array = new T[capacity];
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= _array.Length)
                throw new IndexOutOfRangeException();
            return _array[index];
        }
    }

    public void Add(T item)
    {
        if (_length == _array.Length)
            throw new ArgumentException();

        _array[_length++] = item;
    }

    #region IEnumerable
    public IEnumerator<T> GetEnumerator()
    {
        return (IEnumerator<T>)_array.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return _array.GetEnumerator();
    }
    #endregion
}
