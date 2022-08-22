using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_08_22
{
    internal class Assignment13
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 5, 200, 22, 2244, 213, 111 };
            List<int> l = new List<int>();
            foreach (var item in arr)
            {
                if (item > 100)
                    l.Add(item);
            }
            foreach (var item in l)
            {
                Console.WriteLine(item);
            }
            #region using GroupByMethod
            var partitions = arr.GroupBy(x => x > 100);
            foreach (var partition in partitions)
            {
                Console.WriteLine(String.Join(", ", partition));
            } 
            #endregion

        }
    }
}
