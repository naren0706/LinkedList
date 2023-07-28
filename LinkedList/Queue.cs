using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Queue
    {
        internal Node head;
        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted to the Queue", node.data);
        }
        internal Node Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("nothing to remove");
                return null;
            }
            this.head = this.head.next;
            Console.WriteLine("First node has been removed");
            return this.head;
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("no data to display");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " | ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
