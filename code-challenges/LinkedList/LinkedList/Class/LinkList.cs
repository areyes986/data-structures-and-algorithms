using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Class
{
    public class LinkList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }


        /// <summary>
        /// We are inserting the nodes inputted value as the head
        /// </summary>
        /// <param name="value"> The input </param>
        public void Insert(int value)
        {
            Node node = new Node();
            //the inputted data is set to value
            node.Value = value;
            // this sets next to head
            node.Next = Head;
            // set the new node as head
            Head = node;
        }

        /// <summary>
        /// This tranveres through the linklist to look for the value.
        /// if the current value equals the inserted value, it returns true, if not false.
        /// </summary>
        /// <param name="value"> the searched value </param>
        /// <returns></returns>
        public bool Includes(int value)
        {
            Current = Head;
            while (Current != null)
            {
                if( Current.Value == value)
                {
                    return true;
                }
            Current = Current.Next;
            }
            return false;
        }


        /// <summary>
        /// This prints out the nodes that are in the linkedlink
        /// </summary>
        /// <returns> returns the appended string</returns>
        public override string ToString()
        {
            Current = Head;
            StringBuilder sb = new StringBuilder();
            while (Current != null)
            {
                sb.Append($"{Current.Value} -> ");
                Current = Current.Next;
            }

            // we are at null at this point
            sb.Append("NULL");
            return sb.ToString();
        }

    }




}
