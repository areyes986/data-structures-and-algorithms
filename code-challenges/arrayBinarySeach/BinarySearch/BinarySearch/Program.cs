using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 6, 7, 5, 2 };
            int key = 5;
            BinarySearch(array, key);
        }

        static void BinarySearch(int[] myArray, int key)
        {
            for (int i = 0; i < myArray.Length; i++)
            {

                if (myArray[i] == key)
                {
                    Console.WriteLine(i);
                }
                else if (myArray[i] != key)
                {

                }
            }

        }
    }
}
