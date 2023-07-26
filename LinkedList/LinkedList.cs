using System;

namespace LinkedList
{
    internal class LinkedList
    {
        internal Node head;
        internal void Add(int data)
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
            Console.WriteLine("{0} inserted to the linked list", node.data);
        }
        internal void AddInReverseOrder(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                head = newNode;                
                head.next = temp;
            }
            Console.WriteLine("The data has been added in the reverse");
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
        internal Node InsertAtParticularPosition(int position, int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                return newNode;
            }
            if (position == 0)
            {
                newNode.next = this.head;
                this.head = newNode;
                return this.head;
            }
            Node prev = null;
            Node current = this.head;
            int count = 0;
            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            newNode.next = prev.next;
            Console.WriteLine("data has been inserted at the particular position");
            return this.head;
        }
        internal Node RemoveFirstNode()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            Console.WriteLine("First nodehas been removed");
            return this.head;
        }
        internal Node RemoveLastNode()
        {
            if (head == null)
                return null;
            if (head.next == null)
                return null;
            Node NewNode = head;
            while (NewNode.next.next != null)
            {
                NewNode = NewNode.next;
            }
            NewNode.next = null;
            Console.WriteLine("Last node has been removed");
            return head;
        }
        internal int Search(int value)
        {
            Node node = this.head;
            int count = 0;
            bool flag = false;
            while (node != null)
            {
                if (node.data == value)
                {
                    flag = true;
                    break;
                }
                node = node.next;
                count++;
            }
            if (!flag)
            {
                Console.WriteLine("value not found");
                return 0;
            }
            else
            {
                Console.WriteLine("the value is found in the index {0}", count);
                return count;
            }
            
        }
        internal void DeleteNodeAtParticularPosition(int position)
        {
            if (this.head == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            Node temp = this.head;
            if (position == 0)
            {
                this.head = temp.next;
                return;
            }
            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.next;
            }
            if (temp == null || temp.next == null)
            {
                return;
            }
            Node next = temp.next.next;
            temp.next = next;
            Console.WriteLine("the data has been deleted at the postion "+position);
            Size();
        }
        internal void Size()
        {
            Node temp = this.head;
            int count = 0;
            if (temp == null)
            {
                Console.WriteLine("no data to display");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " | ");
                temp = temp.next;
                count++;
            }
            Console.WriteLine("Length: " + count);
        }
    }
}
