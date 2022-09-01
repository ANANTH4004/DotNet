using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class MergeSort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int j, temp;
            Console.WriteLine("Enter {0} Number", n);
            for (int i = 0; i < n; i++)
            {
                a[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("========= Before Sort ===========");
            Print(a);
            Sort(a, 0, a.Length - 1);
            Console.WriteLine("========= After Sort ===========");
            Print(a);
        }
        static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
        }
        static void Sort(int[] a , int low , int high)
        {
            if(low < high)
            {
                int mid = (low + high) / 2;
                Sort( a, low, mid);
                Sort( a, mid+1, high);
                Merge(a, low, mid, high);

            }
        }
        static void Merge(int[] a,int low , int mid , int high)
        {
            var leftArrayLength = mid - low + 1;
            var rightArrayLength = high - mid;
            var leftTempArray = new int[leftArrayLength];
            var rightTempArray = new int[rightArrayLength];
            int i, j;
            for (i = 0; i < leftArrayLength; ++i)
                leftTempArray[i] = a[low + i];
            for (j = 0; j < rightArrayLength; ++j)
                rightTempArray[j] = a[mid + 1 + j];
            i = 0;
            j = 0;
            int k = low;
            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (leftTempArray[i] <= rightTempArray[j])
                {
                    a[k++] = leftTempArray[i++];
                }
                else
                {
                    a[k++] = rightTempArray[j++];
                }
            }
            while (i < leftArrayLength)
            {
                a[k++] = leftTempArray[i++];
            }
            while (j < rightArrayLength)
            {
                a[k++] = rightTempArray[j++];
            }
        }
    
    }
}
