using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace FilesDemo
{
    internal class FileAssignment2
    {
        static void Main(string[] args)
        {




            Console.WriteLine("1.Create a File \n2.Copy to a Different Folder \n3.Copy to the same Folder  \n4.Move A File\n5.Delete a File \n6.Find the Extension of a file \n7.Find Creation Time of the File \n8.Directory of a File");
            Console.WriteLine("Enter a choice: ") ;
            int choice = Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    try
                    {
                        Console.WriteLine("===== File Creation using file Class========");
                        Console.WriteLine("Enter File Name");
                        string fName = Console.ReadLine();
                        File.Create(fName);
                    }catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 2:
                    try
                    {
                        Console.WriteLine("===========Copy to a Diffrent Folder=======");
                        File.Copy(@"D:\c#\FilesDemo\FilesDemo\bin\Debug\anand.txt", @"D:\c#\FilesDemo\varun.txt");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 3:
                    try
                    {
                        Console.WriteLine("========copy to the same Folder =======");
                        string path = @"D:\c#\FilesDemo\FilesDemo\bin\Debug\";
                        Console.WriteLine("Enter File Name");
                        String fName = Console.ReadLine();
                        File.Copy(path + "anand.txt", path + fName, true);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 4:
                    try
                    {
                        Console.WriteLine("=====Move a file ============");
                        File.Move(@"D:\c#\FilesDemo\FilesDemo\bin\Debug\anand.txt", @"D:\c#\FilesDemo\FilesDemo\bin\Debug\Anand\sam1.txt");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 5:
                    try
                    {
                        Console.WriteLine("===== File Deletion ========");
                        Console.WriteLine("Enter File Name");
                        string fName = Console.ReadLine();
                        File.Delete(fName);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 6:
                    try
                    {
                        Console.WriteLine("========Find the extension =======");
                        string path = @"D:\c#\FilesDemo\FilesDemo\bin\Debug\";
                        Console.WriteLine("Enter File Name");
                        String fName = Console.ReadLine();
                        fName = string.Concat(path, fName);
                        FileInfo f2 = new FileInfo(fName);
                        Console.WriteLine("extension of the file: " + f2.Extension);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 7:
                    try
                    {
                        Console.WriteLine("========Find the Creation Time=======");
                        string path = @"D:\c#\FilesDemo\FilesDemo\bin\Debug\";
                        Console.WriteLine("Enter File Name");
                        String fName = Console.ReadLine();
                        fName = string.Concat(path, fName);
                        FileInfo f2 = new FileInfo(fName);
                        Console.WriteLine("Creation Time of the file: " + f2.CreationTime);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 8:
                    try
                    {
                        Console.WriteLine("========Find the extension =======");
                        string path = @"D:\c#\FilesDemo\FilesDemo\bin\Debug\";
                        Console.WriteLine("Enter File Name");
                        String fName = Console.ReadLine();
                        fName = string.Concat(path, fName);
                        FileInfo f2 = new FileInfo(fName);
                        Console.WriteLine("Directory of the file: " + f2.Directory);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                default:
                    Console.WriteLine("Enter a valid Input");
                    break;
            }

        }
    }
}
