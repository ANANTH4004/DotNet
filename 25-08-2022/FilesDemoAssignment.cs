using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesDemo
{
    internal class FilesDemoAssignment
    {
        static void Main(string[] args)
        {
            string path = "";
            Console.WriteLine("Enter the file name");
            string fname = Console.ReadLine();


            fname = string.Concat(path, fname);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1.File creation  2.Add Text 3.Edit File 4.Truncuate Text");
            int choice = Convert.ToInt32(Console.ReadLine());
            FileStream s1 = null;
            StreamWriter sw = null;
            switch (choice)
            {
                case 1:
                    FileStream f = new FileStream(fname, FileMode.Create);
                    break;
                case 2:
                    
                    try
                    {
                        s1 = new FileStream($"{fname}", FileMode.Create, FileAccess.Write);
                        sw = new StreamWriter(s1);
                        Console.Write("Enter the Content you want to Add:");
                        string s = Console.ReadLine();
                        sw.Write(s);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        sw.Flush();

                        s1.Flush();
                        sw.Close();
                        s1.Close();
                        sw.Dispose();
                        s1.Dispose();
                    }
                    break;
                case 3:
                    FileStream fs = null;
                    StreamWriter ss = null;
                    try
                    {
                         fs = new FileStream(fname, FileMode.Append);
                        ss = new StreamWriter(fs);
                        ss.WriteLine("hi everyone");
                        

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        ss.Close();
                        fs.Close();
                        Console.WriteLine(" append  successfully...");
                    }
                    break;
                case 4:
                    FileStream fs1 = new FileStream(fname, FileMode.Truncate);
                   // StreamWriter ss1 = new StreamWriter(fs1);
                    break;
                default:
                    Console.WriteLine("Enter a Valid Input");
                    break;
            }
            
               

        }
    }
}
