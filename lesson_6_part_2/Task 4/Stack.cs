using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_6_part_2
{
    public class Stack<T>
    {
        public T[] elements;
        public int size;
        public int capacity;

        public Stack(int capacity)
        {
            elements = new T[capacity];
            this.capacity = capacity;
            size = 0;
        }

        public T Pop()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T item = elements[--size];
            return item;
        }

        public void Push(T item)
        {
            if (size == capacity)
            {
                throw new InvalidOperationException("The stack is full");
            }

            elements[size++] = item;
        }

        public T Peek()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }
            return elements[size - 1];
        }

        public int Count
        {
            get { return size; }
        }
    }
}
