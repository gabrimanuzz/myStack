using myStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myStack
{
    public class myStack<T> : IStack<T>
    {
        private Node<T>? top;

        public int Count { get; private set; }

        public myStack()
        {
            top = null;
        }

        public void Push(T Data)
        {
            Node<T>? newNode = new Node<T>(Data);
            
            if (top == null)
            {
                top = newNode;
                Count++;
                return;
            }

            newNode.Next = top;
            top = newNode;

            Count++;
        }

        public T Pop()
        {
            if (top == null)
                throw new Exception("Stack non valorizzato");
            
            T Data = top.Data;
            top = top.Next;
            Count--;

            return Data;
        }

        public T? Peek()
        {
            if (top == null)
                throw new Exception("Stack non valorizzato");
            
            return top.Data;
        }

        public void Clear()
        {
            top = null;
            Count = 0;
        }

        public bool IsEmpty()
        {
            return top == null;
        }
    }
}
