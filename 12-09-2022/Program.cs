using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection_and_Attributes
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\c#\Reflection and Attributes\Reflection Demo\bin\Debug\Reflection Demo.dll";


            Assembly asm = Assembly.LoadFile(path);
            Type[] types = asm.GetTypes();

            foreach (var item in types)
            {
                Console.WriteLine("Name :" + item.Name);//classname
                Console.WriteLine("Full Name : " + item.FullName);//assemblyname/namespacename and class
                Console.WriteLine("IS Class= : " + item.IsClass);
                Console.WriteLine("IS Absatract : " + item.IsAbstract);
                Console.WriteLine("Is Public : " + item.IsPublic);


                Console.WriteLine("-----------------");
                MethodInfo[] methodInfos = item.GetMethods();
                foreach (var methodInfosItem in methodInfos)
                {

                    Console.WriteLine("Name : " + methodInfosItem.Name);
                    Console.WriteLine("IS PUBLIC : " + methodInfosItem.IsPublic);
                    Console.WriteLine("IS STATIC : " + methodInfosItem.IsStatic);

                    ParameterInfo[] pinfo = methodInfosItem.GetParameters();


                    if (methodInfosItem.Name == "Add")
                    {
                        Console.WriteLine("---Add method Parameters----");
                        foreach (var par in pinfo)
                        {
                            Console.WriteLine(par.Name);
                            Console.WriteLine(par.Position);
                            Console.WriteLine(par.ParameterType);

                        }
                   }

                }
                Console.WriteLine("for each loop complete a run==================");
            }
           
        }
    }
}
