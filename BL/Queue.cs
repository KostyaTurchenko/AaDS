using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Queue
    {
        Node<string> head;
        Node<string> tail;

        public int Count { get; private set; }

        public Queue ()
        {
            head = null; tail = null; int Count = 0;
        }
        public bool QueueIsEmpty()
        {
            return head == null;
        }

        public void InQueue(string value)
        {
            var N = new Node<string>(value, null);
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

        public void InQueueWithKeepingOfOrder (string value)
        {
            var comperable_item = head;
            if (string.Compare(value, comperable_item.Value) == -1)
            {
                var N = head;
                head = new Node<string>(value, N);
                Count++;
                return;
            }

            
            for (int i = 0; i < Count; i++)
            {
                if (comperable_item.Next == null)
                {
                    InQueue(value);
                    Count++;
                    return;
                }
                else if (string.Compare(value, comperable_item.Next.Value) == 1)
                {
                    comperable_item = comperable_item.Next;
                    continue;
                }

                else
                {
                    var N = new Node<string>(value, comperable_item.Next);
                    comperable_item.Next = N;
                    Count++;
                    return;
                }
                
            }
        }

        public string OutQueue ()
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
            Node<string> p = head;
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
