using System;
using Xunit;
using BinarySearch;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void ReturnsKey()
        {
            int[] array = new int[] { 3, 6, 7, 8, 9 };
            int key = Program.BinarySearch(array, 7);
            Assert.Equal(2, key);
        }

        [Fact]
        public void ReturnsNeg()
        {
            int[] array = new int[] { 3, 6, 7, 8, 9 };
            int key = Program.BinarySearch(array, 1);
            Assert.Equal(-1, key);
        }
    }
}
