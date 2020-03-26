using System;
using LinkedList.Class;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LinkList link = new LinkList();
            link.Insert(5);
            link.Insert(12);
            link.Insert(43);
            link.Insert(3);

            bool result = link.Includes(5);
            Console.WriteLine(result);

            Console.WriteLine(link.ToString());

            Console.WriteLine(link.KthFromEnd(2));
        }

    }
}
