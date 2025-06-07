using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms.Chapter_Two
{
    public class SelectionSort
    {
        public static void run()
        {
            List<int> arr = new List<int>() { 5, 3, 6, 2, 10 };
            List<int> sorted = selectionSort(arr);
            Console.WriteLine($"[{string.Join(", ", sorted)}]"); // [2, 3, 5, 6, 10]
        }

        public static int findSmallest(List<int> arr)
        {
            // this isn't the algorithm itself
            // this is a function to find the smallest element in an array
            // it returns the index of the smallest element
            int smallest = arr[0];
            int smallestIndex = 0;
            for (int i = 1; i < arr.Count; i++)
            {
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                    smallestIndex = i;
                }
            }
            return smallestIndex;
        }

        public static List<int> selectionSort(List<int> arr)
        {
            List<int> newArr = new List<int>();
            // create a copy to avoid modifying the original list
            List<int> tempList = new List<int>(arr);
            while(tempList.Count > 0)
            {
                // find the smallest in the original array
                int smallestIndex = findSmallest(tempList);
                // adds it to the new array
                newArr.Add(tempList[smallestIndex]);
                // then removes it from the original array
                tempList.RemoveAt(smallestIndex);
            }
            return newArr;
        } 
    }
}
