using System.Collections.Generic;

namespace BoxOfT
{
    public class Box<T>
    { 
        private Stack<T> myStack = new Stack<T>();
        public int Count => Count;

        public void Add(T item)
        {
            myStack.Push(item);
        }
        public T Remove()
        {
            T element = myStack.Peek();
            myStack.Pop();
            return element;
        }
    }
}
