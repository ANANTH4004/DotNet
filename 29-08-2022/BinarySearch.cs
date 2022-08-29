using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class BinarySearch
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter a Element");
                a[i] = Int32.Parse(Console.ReadLine());
            }
            Array.Sort(a);
            Console.WriteLine("Enter a key to find");
            int key = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Element in the pos : {0}", BinarySearchIterative(a,key));
        }
        public static object BinarySearchIterative(int[] arr, int key)
        {
            int low = 0;
            int high = arr.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (key == arr[mid])
                {
                    return ++mid;
                }
                else if (key < arr[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return "Element Not Found";
        }
    }
}
