using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class SelectionSort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int min ,temp;
            Console.WriteLine("Enter 5 Number");
            for (int i = 0; i < n; i++)
            {
                a[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("========= Before Sort ===========");
            Print(a);
            for(int i = 0; i < a.Length - 1; i++)
            {
                min = i;
                for (int j = i+1; j < a.Length; j++)
                {
                    if (a[j] < a[min])
                    {
                        min = j;
                    }
                }
                if(min != i)
                {
                    temp = a[i];
                    a[i] = a[min];
                    a[min] = temp;
                }
            }
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
    }
}
