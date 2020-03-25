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


        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public void Append(int value)
        {
            Current = Head;

            
            if (Head == null)
            {
                Node node = new Node();
                node.Value = value;
                Head = node;
            }
            while (Current != null)
            {
            if (Current.Next == null)
            {
                Node node = new Node();
                node.Value = value;
                Current.Next = node;
                break;
            }
                Current = Current.Next;
            }

        }

        /// <summary>
        /// This method inserts a node with a new value before a value
        /// </summary>
        /// <param name="value"> value in list </param>
        /// <param name="newValue"> the new inputted value </param>
        public void InsertBefore(int value, int newValue)
        {
            // set current to head
            Current = Head;
            // create a new node
            Node node = new Node();
            //set that value to a newvalue
            node.Value = newValue;

            // if 
            if (Head.Value == value)
            {
                Insert(newValue);
                return;
            }

            // traversing until next isnt null
            while (Current.Next != null)
            {
                // if the next value = to the value we are searching for
                if (Current.Next.Value == value)
                {
                    // then that node next = to current next
                    node.Next = Current.Next;
                    // then current next = newly made node
                    Current.Next = node;
                }
                // current will keep going to next to traverse
                Current = Current.Next;
            }
        }

        /// <summary>
        /// This method had 2 while loops. The first one gets the length of the list, 
        /// Then that counter is minused from k. The other while loop increments a new counter and if
        /// the newcounter equals the newly reassigned counter, that should be the node we are looking for
        /// and returns the nodes value.
        /// </summary>
        /// <param name="k"> inputted argument that acts as an index </param>
        /// <returns></returns>
        public int KthFromEnd(int k)
        {
            Current = Head;

            int counter = 0;
            int newCounter = 0;

            while (Current != null)
            {
                counter++;
                Current = Current.Next;
            }

            Current = Head;
            counter = counter - k;

            while (Current != null)
            {
                newCounter++;
                if (newCounter == counter)
                {
                    return Current.Value;
                }
                Current = Current.Next;
            }

            throw new Exception ("Sorry, you are out of range.");

        }
    }




}
