using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_08_22
{
    internal class Assignment5
    {
        static void Main(string[] args)
        {
            int[][] s = new int[5][];

            s[0] = new int[1] { 34 };
            s[1] = new int[1] { 43 };
            s[2] = new int[1] { 45 };
            s[3] = new int[1] { 34 };
            s[4] = new int[1] { 56 };
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write("ClassRoom({0}): ", i + 1);
                for (int j = 0; j < s[i].Length; j++)
                {
                    Console.Write( "Student Count:"+s[i][j] + "\t");
                }
                Console.WriteLine();
            }

        }

        }
    }

