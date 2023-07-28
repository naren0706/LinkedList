using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList

{
    internal class Stack
    {
        Node top;
        public Stack()
        {
            this.top = null;
        }
        internal void push(int data)
        {
            Node node = new Node(data);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} is pushed to stack", data);
        }
        internal void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " | ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
        internal void peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} is in the top", this.top.data);
        }
        internal void pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("stack is empty");
            }
            else
            {
                Console.WriteLine("the value poped is {0}", this.top.data);
                this.top = this.top.next;
            }
        }
        internal void IsEmpty()
        {
            while (this.top != null)
            {
                peek();
                pop();
            }
        }
    }
}
