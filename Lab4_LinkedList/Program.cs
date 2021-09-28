using System;

namespace Lab4_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List");

            Link firstItem = new Link(1);
            Link secondItem = new Link(2, firstItem);
            Link thirdItem = new Link(3, secondItem);

            LinkList testList = new LinkList();
            testList.AddItem(5);
            testList.AddItem(8);
            testList.AddItem(25);

            Console.WriteLine("list contains {0}", testList.DisplayItems());
            Console.WriteLine("there are " + testList.Count() + " items in the list");

            Console.ReadKey();

        }
    }
}
