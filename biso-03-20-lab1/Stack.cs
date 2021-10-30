using System;
using System.Collections.Generic;
using System.Text;

namespace biso_03_20_lab1
{
    class Stack
    {
        private List<int> stack = new List<int>();

        public void Push(int value)
        {
            stack.Add(value);
        }

        public int Pop()
        {
            int result = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);

            return result;
        }

        public int Count()
        {
            return stack.Count;
        }


    }
}
