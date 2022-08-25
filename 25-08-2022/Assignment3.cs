using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FilesDemo
{
    internal class Assignment3
    {
        static void Main(string[] args)
        {

            Directory.CreateDirectory("Results");
            Directory.CreateDirectory("D:\\c#\\FilesDemo\\FilesDemo\\bin\\Debug\\Results\\Results 17-18");
            Directory.CreateDirectory("D:\\c#\\FilesDemo\\FilesDemo\\bin\\Debug\\Results\\Results 17-18\\jan");
            Directory.CreateDirectory("D:\\c#\\FilesDemo\\FilesDemo\\bin\\Debug\\Results\\Results 17-18\\feb");
            Directory.CreateDirectory("D:\\c#\\FilesDemo\\FilesDemo\\bin\\Debug\\Results\\Results 18-19");
            Directory.CreateDirectory("D:\\c#\\FilesDemo\\FilesDemo\\bin\\Debug\\Results\\Results 18-19\\march");
            Directory.CreateDirectory("D:\\c#\\FilesDemo\\FilesDemo\\bin\\Debug\\Results\\Results 18-19\\april");
            Directory.CreateDirectory("D:\\c#\\FilesDemo\\FilesDemo\\bin\\Debug\\Results\\Results 20-21\\");
            Directory.CreateDirectory("D:\\c#\\FilesDemo\\FilesDemo\\bin\\Debug\\Results\\Results 20-21\\may");
            Directory.CreateDirectory("D:\\c#\\FilesDemo\\FilesDemo\\bin\\Debug\\Results\\Results 20-21\\june");
            
            try
            { 
                string docPath = @"D:\c#\FilesDemo\FilesDemo\bin\Debug\Results";

                List<string> dirs = new List<string>(Directory.EnumerateDirectories(docPath));

                foreach (var dir in dirs)
                {
                    Console.WriteLine("{0}", dir.Substring(dir.LastIndexOf("\\") + 1));
                }
                Console.WriteLine($"{dirs.Count} directories found.");
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (PathTooLongException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
