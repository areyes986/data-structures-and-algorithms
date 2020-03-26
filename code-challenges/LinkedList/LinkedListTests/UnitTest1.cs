using System;
using Xunit;
using LinkedList;
using LinkedList.Class;

namespace LinkedListTests
{
    public class UnitTest1
    {

        /// <summary>
        /// This test makes sure that the Node CLASS has a PROPERTY of Value.
        /// In order for this test to work, we needed to instantiate the Node object,
        /// Then make sure that the property of Value is an int
        /// First we had to make sure the Node class was created and that it had a property named Value
        /// </summary>
        [Fact]
        public void NodeHasValueProperty()
        {
            Node node = new Node();
            Assert.IsType<int>(node.Value);
        }

        /// <summary>
        /// This is a test to test the Get. First is making a node object by instantiating it.
        /// Then set the node Value to 5.
        /// And the Assert makes sure that the value equals to what is got.
        /// </summary>
        [Fact]
        public void CheckingTheGet()
        {
            Node node = new Node();
            node.Value = 5;
            Assert.Equal(5, node.Value);
        }


        /// <summary>
        /// This shows that the Value can change. We instantiate the object again.
        /// set the value to a number then change it to a different number
        /// The assert is testing if the set equals that new set number.
        /// </summary>
        [Fact]
        public void CheckingTheSet()
        {
            Node node = new Node();
            node.Value = 12;
            node.Value = 15;
            Assert.Equal(15, node.Value);
        }

        /// <summary>
        /// This tests for Node having the Next prop.
        /// Then we have node.Next equal to null because it doesnt know where to reference to yet.
        /// </summary>
        [Fact]
        public void NodeHasNextProperty()
        {
            Node node = new Node();
            Assert.Null(node.Next);
        }

        /// <summary>
        /// This tests that the Next prop can be set.
        /// We instantiate 2 node objects then make sure that the node.Next can reference to the 2nd node.
        /// </summary>
        [Fact]
        public void CanSetNextProp()
        {
            Node node = new Node();
            node.Value = 12;

            Node node2 = new Node();
            node.Next = node2;

            Assert.Equal(node.Next, node2);
        }

        /// <summary>
        /// This checkes that there is a head prop in the Linklist Class.
        /// First we had to made sure there was such a class created and 
        /// have a head prop for the test to pass.
        /// We make the head null because we want an empty linklist to be created
        /// </summary>
        [Fact]
        public void LinkedListClassHasHeadProp()
        {
            LinkList linkedList = new LinkList();
            Assert.Null(linkedList.Head);
        }

        /// <summary>
        /// Create a linked list object, insert 10 into the method to makes sure 
        /// that the value of the head is 10 to replace head with new node
        /// </summary>
        [Fact]
        public void CanAddNewNodeToLinkedListAsHead()
        {
            LinkList link = new LinkList();
            link.Insert(10);
            Assert.Equal(10, link.Head.Value);
        }

        /// <summary>
        /// We can add more than one linklist
        /// </summary>
        [Fact]
        public void CaninsertNewNodeAsHead()
        {
            LinkList link = new LinkList();
            link.Insert(12);
            link.Insert(5);

            Assert.Equal(5, link.Head.Value);
        }

        /// <summary>
        /// This tests that tests if a number exists as a nodes value.
        /// This specifically tests if that number is true.
        /// </summary>
        [Fact]
        public void FindNodeWithValue()
        {
            LinkList link = new LinkList();
            link.Insert(10);
            link.Insert(5);
            link.Insert(12);
            link.Insert(24);

            bool exists = link.Includes(12);
            Assert.True(exists);
        }

        /// <summary>
        /// This tests that tests if a number exists as a nodes value.
        /// This specifically tests if that number is False.
        /// </summary>
        [Fact]
        public void CannotNodeWithValue()
        {
            LinkList link = new LinkList();
            link.Insert(10);
            link.Insert(5);
            link.Insert(12);
            link.Insert(24);

            bool exists = link.Includes(35);
            Assert.False(exists);
        }

        /// <summary>
        /// This checks that the tostring method appended and printed out the expected string.
        /// </summary>
        [Fact]
        public void CanConvertLinkListToAString()
        {
            LinkList link = new LinkList();
            link.Insert(10);
            link.Insert(5);
            link.Insert(12);
            link.Insert(24);

            string newString = link.ToString();

            string expected = $"24 -> 12 -> 5 -> 10 -> NULL";
            Assert.Equal(expected, newString);

        }

        [Fact]
        public void CanAppendNewNodeAtEndOfList()
        {
            LinkList link = new LinkList();
            link.Append(20);
            link.Append(43);
            link.Append(2);
            link.Append(42);

            string newString = link.ToString();

            string expected = $"20 -> 43 -> 2 -> 42 -> NULL";
            Assert.Equal(expected, newString);
        }

        [Fact]
        public void ShowsExceptionWhenKIsGreaterThanList()
        {
            LinkList link = new LinkList();
            link.Append(20);
            link.Append(43);
            link.Append(2);
            link.Append(42);

            Exception error = Record.Exception(() => link.KthFromEnd(10));
            Assert.IsType<Exception>(error);
        }

        [Fact]
        public void KAndListLengthAreTheSame()
        {
            LinkList link = new LinkList();
            link.Append(20);
            link.Append(43);
            link.Append(2);
            link.Append(42);

            Exception error = Record.Exception(() => link.KthFromEnd(4));
            Assert.IsType<Exception>(error);
        }

        [Fact]
        public void KIsNotAPosInt()
        {
            LinkList link = new LinkList();
            link.Append(20);
            link.Append(43);
            link.Append(2);
            link.Append(42);

            Exception error = Record.Exception(() => link.KthFromEnd(-1));
            Assert.IsType<Exception>(error);
        }

        [Fact]
        public void ListIsSizeOfOne()
        {
            LinkList link = new LinkList();
            link.Append(20);

            int length = link.KthFromEnd(0);
            Assert.Equal(20, length);
        }

        [Fact]
        public void KNotInEndButInMiddle()
        {
            LinkList link = new LinkList();
            link.Append(20);
            link.Append(43);
            link.Append(2);
            link.Append(42);

            int middle = link.KthFromEnd(2);
            Assert.Equal(43, middle);
        }


    }
}
