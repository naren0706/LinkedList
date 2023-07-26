using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList list = new LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Display();
            list.DeleteNodeAtParticularPosition(3);
            list.Display();
            list.Search(7);
            list.Display();
            list.RemoveLastNode();
            list.Display();
            list.RemoveFirstNode();
            list.Display();
            list.InsertAtParticularPosition(3,3);
            list.Display();
            list.AddInReverseOrder(0);
            list.Display();
        }
    }
}
