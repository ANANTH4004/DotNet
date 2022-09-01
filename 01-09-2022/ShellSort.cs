using System;

namespace DataStructure
{
    internal class ShellSort
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
            for (int gap = a.Length / 2; gap >= 1; gap = gap / 2)
            {
                for (j = gap; j < a.Length; j++)
                {
                    for (int i = j - gap; i >= 0; i = i - gap)
                    {
                        if (a[i + gap] > a[i])
                        {
                            break;
                        }
                        else
                        {
                            temp = a[i + gap];
                            a[i + gap] = a[i];
                            a[i] = temp;
                        }
                    }
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
