using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myStack
{
    internal interface IStack<T>
    {
        public void Push(T Data);
        public T Pop();
        public T? Peek();
        public void Clear();
        public bool IsEmpty();
    }
}
