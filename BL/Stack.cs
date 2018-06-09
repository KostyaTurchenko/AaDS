using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{

    class Stack<T>
    {

        private Node<T> _head;

        private int _count = 0;

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public List<T> print ()
        {
            var output_list = new List<T>();

            while (_count != 0)
            {
                T value = _head.Value;
                _head = _head.Next;
                _count--;

                output_list.Add(value);
            }

            return output_list;
        }

        public void Push (T value)
        {
            _head = new Node<T>(value, _head);
            _count++;
        }

        public T Pop ()
        {
            T value = _head.Value;
            _head = _head.Next;
            _count--;

            return value;
        }





    }
}
