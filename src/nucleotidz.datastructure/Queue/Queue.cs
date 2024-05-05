using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace nucleotidz.datastructure.Queue
{
    public class Queue
    {
        int Max;
        int[] queue;
        int tail;
        int head;
        public Queue(int _max)
        {
            Max = _max;
            queue= new int[Max];
            
        }
        public int[] Enqueue(int value)
        {
            if (tail >= Max)
            {
                throw new OverflowException();
            }
            queue[tail] = value;
            tail++;
            return queue;
        }
        public int Dequeue()
        {
            if (head >= Max)
            {
                throw new OverflowException();
            }
            return queue[head++];
        
        }

    }
}
