using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesDemo
{
    internal class FileStreamDemo
    {
        static void Main(string[] args)
        {
            FileStream s1 = null;
            StreamWriter sw = null;
            try
            {
                 s1 = new FileStream("demo1.txt", FileMode.Create, FileAccess.Write);
                 sw = new StreamWriter(s1);
                sw.Write("already there is some content");
            }catch(Exception ex)
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
           
            
        }
    }
}
