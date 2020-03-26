using LinkedList.Class;
using System;

namespace LLMerge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LinkList link1 = new LinkList();
            link1.Append(2);
            link1.Append(4);
            link1.Append(6);
            link1.Append(8);


            LinkList link2 = new LinkList();
            link2.Append(1);
            link2.Append(3);
            link2.Append(5);
            link2.Append(7);


            MergeLists(link1, link2);
        }

        public static int MergeLists(LinkList link1, LinkList link2)
        {
            Node node1 = new Node();
            Node node2 = new Node();
            Node dummyNode = new Node();




        }

    }
}
