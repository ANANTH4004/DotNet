using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_and_Attributes
{
    internal class ReflectionAnswers
    {
        static void Main(string[] args)
        {
            string path = @"D:\c#\Reflection and Attributes\Reflection Demo\bin\Debug\Reflection Demo.dll";
            Assembly asm = Assembly.LoadFile(path);
            Console.WriteLine("Full Name : " + asm.GetName().Name);
            Type t = asm.GetType("Reflection_Demo.Maths");
            object obj = Activator.CreateInstance(t);
            PropertyInfo prop = t.GetProperty("Number");
            prop.SetValue("Number",101.00);

            t.InvokeMember("Cube", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj,new object[1] { prop });


        }
        
    }
}
