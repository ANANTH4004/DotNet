using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class QuickSort
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            
            Console.WriteLine("Enter 5 Number");
            for (int i = 0; i < n; i++)
            {
                a[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("========= Before Sort ===========");
            Print(a);
            Quick(a, 0, a.Length-1);
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
        static void Quick(int[] arr , int low ,int high)
        {
            if(low < high)
            {
                int loc = part(arr, low, high);
                Quick(arr, low, loc - 1);
                Quick(arr, loc + 1, high);
            }
        }
        static int part(int[] arr, int low, int high)
        {
            int start, end, pivot,temp;
            pivot = arr[low];
            start = low;
            end = high;
            while (start < end) {
                while (arr[start] <= pivot)
                {
                    start++;
                }
                while (arr[end] > pivot)
                {
                    end--;
                }
                if(start < end)
                {
                    temp = arr[start];
                    arr[start] = arr[end];
                    arr[end] = temp;
                }
            }
            temp = arr[low];
            arr[low] = arr[end];
            arr[end] = temp;
            return end;
        }
    }
}
