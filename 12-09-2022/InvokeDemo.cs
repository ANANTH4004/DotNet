using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_and_Attributes
{
    public class InvokeDemo
    {
        static void Main(string[] args)
        {
            string path = @"D:\c#\Reflection and Attributes\Reflection Demo\bin\Debug\Reflection Demo.dll";


            Assembly asm = Assembly.LoadFile(path);
            Type t = asm.GetType("Reflection_Demo.Maths");
            Console.WriteLine("Class Name : " + t);
            MethodInfo[] minfoAll = t.GetMethods();
            foreach (var item in minfoAll)
            {
                Console.WriteLine("Methods Name : "+ item.Name);
            }
            MethodInfo minfo = t.GetMethod("Cube");
            MethodInfo minfo2 = t.GetMethod("Sqrt");
            //PropertyInfo prop = null;
            //try
            //{
            //     prop = t.GetProperty("Number");
            //    prop.SetValue("set_Number", 12.342);
            //    object ans = prop.GetValue(t,null);
            //    Console.WriteLine("Get Value : " + ans);
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine("Message : " + ex.Message);
            //}
          
           
            if(minfo != null && minfo2 != null)
            {
                object Result = null;
                ParameterInfo[] parInfo = minfo.GetParameters();
                ParameterInfo[] parInfo2 = minfo2.GetParameters();
                object CreateInstance = Activator.CreateInstance(t, null);
                if(parInfo.Length == 0)
                {
                    Result = minfo.Invoke(CreateInstance, null);
                    Console.WriteLine("Cube Result : " + Result);
                    Result = minfo2.Invoke(CreateInstance, null);
                    Console.WriteLine("Cube Result : " + Result);
                }
                else
                {
                    object[] par = new object[] {22};
                    Result = minfo.Invoke(CreateInstance, par); 
                    Console.WriteLine("Cube Result : " + Result);
                    Result = minfo2.Invoke(CreateInstance, par);
                    Console.WriteLine("Sqrt : " + Result);

                }

                
            }
        }
      
    }
}
