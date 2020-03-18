using System;

namespace ArrayShift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] oldArray = new int[] { 1, 2, 4, 5 };
            InsertShiftArray(oldArray, 3);
        }

        static int[] InsertShiftArray(int[]array, int value)
        {
            int[] newArray = new int[array.Length + 1];
            decimal middleArray = Math.Floor(newArray.Length / 2m);
            int index = 0;

            for (int i = 0; i < newArray.Length; i++)
            {
                if (middleArray == i)
                {
                    newArray[i] = value;
                    index--;
                }

                else
                {
                    newArray[i] = array[index];
                }
                index++;
            }

            Console.WriteLine(String.Join(", ", newArray));
            return newArray;
        }
    }
}
