using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            list.RemoveFirstNode();
            list.Display();
            list.RemoveLastNode();
            list.Search(30);
            list.Add(40);

            Stack stack = new Stack();
            stack.push(56);
            stack.push(30);
            stack.push(70);
            stack.peek();

            Queue queue = new Queue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Dequeue();


        }
    }
}
