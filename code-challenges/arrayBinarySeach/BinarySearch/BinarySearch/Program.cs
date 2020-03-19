using System;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 6, 7, 8, 9 };
            int key = 8;
            BinarySearch(array, key);
        }
        /// <summary>
        /// This method loops over the array to locate the search key. When key equals the element in the index,
        /// the declared int will change to = the index. If not, it will return -1.
        /// </summary>
        /// <returns>the index location or -1</returns>
        public static int BinarySearch(int[] myArray, int key)
        {9
            int neg = -1;
            for (int i = 0; i < myArray.Length; i++)
            {

                if (myArray[i] == key)
                {
                    neg = i;
                }
            }
            Console.WriteLine(neg);
            return neg;
        }

    }
}
