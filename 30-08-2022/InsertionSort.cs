using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class InsertionSort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int j, temp;
            Console.WriteLine("Enter {0} Number",n);
            for (int i = 0; i < n; i++)
            {
                a[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("========= Before Sort ===========");
            Print(a);
            for (int i = 1; i < a.Length; i++)
            {
                temp = a[i];
                j = i - 1;
                while (j>=0 && a[j]>temp)
                {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = temp;
            }
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
    }
}
