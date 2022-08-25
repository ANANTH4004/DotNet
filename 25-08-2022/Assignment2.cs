using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace Fileoperations
{
    public class Assignment2
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("enter userchoice!!!!!!!!\n 1.create the file \n 2.copythe file in same folder the file \n 3.copy the file in the different folder \n 4.Move the file \n 5.Delete the file \n 6.extension of file\n 7.creation date and time of file \n 8.directory of the file");

            int h = Convert.ToInt32(Console.ReadLine());
            switch (h)
            {
                case 1: createfile(); break;
                case 2: copyinsamefolder(); break;
                case 3: copyindifffolder(); ; break;
                case 4: movefile(); break;
                case 5: deletefile(); break;
                case 6: extensionoffile(); break;
                case 7: creationtimeoffile(); break;
                case 8: directoryoffile(); break;
                default:
                    break;
            }
            Console.Read();



        }

        private static void directoryoffile()
        {
            string fname;
            string path = @"D:\vscode C# Code\";
            Console.WriteLine("enter a  file name ");
            fname = Console.ReadLine();
            fname = string.Concat(path, fname);
            FileInfo f2 = new FileInfo(fname);
            Console.WriteLine("extension of the file: " + f2.Directory);
        }

        private static void creationtimeoffile()
        {
            string fname;
            string path = @"D:\vscode C# Code\";
            Console.WriteLine("enter a  file name ");
            fname = Console.ReadLine();
            fname = string.Concat(path, fname);
            FileInfo f2 = new FileInfo(fname);
            Console.WriteLine("extension of the file: " + f2.CreationTime);
        }

        private static void extensionoffile()
        {
            string fname;
            string path = @"D:\vscode C# Code\";
            Console.WriteLine("enter a  file name ");
            fname = Console.ReadLine();
            fname = string.Concat(path, fname);
            FileInfo f2 = new FileInfo(fname);
            Console.WriteLine("extension of the file: " + f2.Extension);
        }

        private static void deletefile()
        {
            string fname;
            string path = @"D:\vscode C# Code\";
            Console.WriteLine("enter a  file name ");
            fname = Console.ReadLine();
            fname = string.Concat(path, fname);
            File.Delete(fname);
            Console.WriteLine("file is deleted successfully!!!!!!!!!!!!!!!!!!!!!!1");
        }

        private static void movefile()
        {
            string fname;
            string path = @"D:\vscode C# Code\";
            Console.WriteLine("enter a source file name ");
            fname = Console.ReadLine();
            fname = string.Concat(path, fname);
            File.Move(fname, "movefile.txt");
            Console.WriteLine("file is moving successfully!!!!!!!!!!!!!!!!!");
        }

        private static void copyindifffolder()
        {
            string fname;
            string path = @"D:\vscode C# Code\";
            Console.WriteLine("enter a source file name ");
            fname = Console.ReadLine();
            fname = string.Concat(path, fname);
            File.Copy(fname, "copydiff.txt");
            Console.WriteLine("file is copying in the different folder successfully!!!!!!!!!!!!!!!!!");
        }

        private static void copyinsamefolder()
        {
            string fname, dname;
            string path = @"D:\vscode C# Code\";
            Console.WriteLine("enter a source file name ");
            fname = Console.ReadLine();
            fname = string.Concat(path, fname);
            Console.WriteLine("enter a destination file name ");
            dname = Console.ReadLine();
            dname = string.Concat(path, dname);
            File.Copy(fname, dname);
            Console.WriteLine("file is copying in the same folder successfully!!!!!!!!!!!!!!!!!");
        }

        private static void createfile()
        {
            string fname, con;
            string path = @"D:\vscode C# Code\";
            Console.WriteLine("enter a file name u want to create");
            fname = Console.ReadLine();
            fname = string.Concat(path, fname);
            //File.Create(fname);
            Console.WriteLine("enter the content");
            con = Console.ReadLine();
            File.WriteAllText(fname, con);
            Console.WriteLine("file is created successfully!!!!!!!!!!!!!!!!!");
        }
    }
}