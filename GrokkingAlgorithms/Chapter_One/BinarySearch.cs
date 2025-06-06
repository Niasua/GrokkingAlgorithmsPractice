using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms.Chapter_One
{
    public class BinarySearch
    {
        public static void run()
        {
            
        }
        public static int binarySearch(int[] list, int item)
        {
            int low = 0;
            int high = list.Length - 1;

            while(low <= high)
            {
                int mid = (low + high) / 2;
                int guess = list[mid];
                if (guess == item) return mid;
                else if (guess > item) high = mid - 1;
                else low = mid + 1;
            }
            // if it got here it is because the element doesn't exist
            return -1;
        }
    }
}
