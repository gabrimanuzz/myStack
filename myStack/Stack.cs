using myStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myStack
{
    public class Stack<T> : IStack<T>
    {
        private Node<T>? top;

        public int Count;

        public Stack()
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
                throw new Exception("Pila non valorizzata");
            
            T Data = top.Data;
            top = top.Next;
            Count--;

            return Data;
        }

        public T? Peek()
        {
            if (top == null)
                throw new Exception("");
            
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
