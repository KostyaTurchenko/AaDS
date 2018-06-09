using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Queue<T>
    {
        Node<T> head;
        Node<T> tail;

        public int Count { get; private set; }

        public Queue ()
        {
            head = null; tail = null; int Count = 0;
        }
        public bool QueueIsEmpty()
        {
            return head == null;
        }

        public void InQueue(T value)
        {
            var N = new Node<T>(value, null);
            if (QueueIsEmpty())
            {
                head = N; tail = N;
            }
            else
            {
                tail.Next = N;
                tail = N;

            }
            Count++;
        }

        public T OutQueue ()
        {
            var N = head;
            head = head.Next;
            Count--;

            return N.Value;
        }

        public string Print ()
        {
            string output;
            int L = 0;
            string[] str = new string[0];
            Node<T> p = head;
            while (p != null)
            {
                Array.Resize<string>(ref str, ++L);
                str[L - 1] = p.Value.ToString();
                p = p.Next;
            }
            output = String.Join("\n", str);
            return output;
        }



    }
}
