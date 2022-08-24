using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCode
{
    public class FileCreateDemo
    {
        public static void CreateFile(string path , string fName)
        {
            File.Create(path + "//" + fName );
        }
    }
}
