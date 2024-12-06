using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_6_part_2
{
    public class Queue<T>
    {
        public T[] elements;
        public int size;
        public int head;
        public int tail;
        public int capacity;

        public Queue(int capacity)
        {
            elements = new T[capacity];
            this.capacity = capacity;
            head = 0;
            tail = -1;
            size = 0;
        }

        public void Enqueue(T item)
        {
            if (size == capacity)
            {
                throw new InvalidOperationException("The queue is full");
            }
            tail = (tail + 1) % capacity;
            elements[tail] = item;
            size++;
        }

        public T Dequeue()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("The queue is empty");
            }
            T item = elements[head];
            head = (head + 1) % capacity;
            size--;
            return item;
        }

        public T Peek()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("The queue is empty");
            }
            return elements[head];
        }

        public int Count
        {
            get { return size; }
        }
    }
}
