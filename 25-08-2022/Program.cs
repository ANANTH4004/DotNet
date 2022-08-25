using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using logic;
using System.IO;
namespace FilesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\c#\FilesDemo\FilesDemo\bin\Debug\Anand\";
            Console.WriteLine("Enter File Name");
            string fName = Console.ReadLine();
            fName = path + fName; 
            //File.Create(fName);
            Console.WriteLine("File Created Successfully");
            string[] content = new string[2];
            content[0] = "hi i ama anand";
            File.WriteAllLines(fName,content);
            FileInfo info = new FileInfo(fName);
            //File.Create(path+);
            Console.WriteLine("full name :" + info.FullName);
            Console.WriteLine("full name :" + info.Directory);    
            Console.WriteLine("full name :" + info.CreationTime);
            // Directory.CreateDirectory("Anand");
            
            //Console.WriteLine("Enter the file name");
           // string fname = Console.ReadLine();
            //File.Create(path+fname);
           // fname = string.Concat(path, fname);
            //  File.Create(fname);
            //Console.WriteLine("file created successfully...");
            //Console.WriteLine("Enter your file contents");
            //string con=Console.ReadLine();
            //string[] contents = new string[2];
            //contents[0] = con;
            //File.WriteAllLines(fname, contents);
            //File.WriteAllText(fname, con);
            //File.AppendAllText(fname, con);
            //Console.WriteLine("file created successfully with contents...");
            // File.Copy(fname, "copiedFile.txt");
            //File.Move(fname, "MovedFile.txt");
            //Console.WriteLine("Successful....");
            //bool fileExists=File.Exists(fname);
           
            //Console.WriteLine("File Exists=  " + fileExists);
            //string contents=File.ReadAllText(fname);
            //Console.WriteLine(contents);
            //FileInfo fileInfo = new FileInfo(fname);
            //Console.WriteLine(fileInfo.FullName + "  Full Name");
            //    Console.WriteLine(fileInfo.DirectoryName + " DirectoryName");
            //Console.WriteLine(fileInfo.CreationTime);
           // Directory.CreateDirectory("MyDir");

        }
    }
}
