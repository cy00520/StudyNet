using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace 反射
{
    class Program
    {
        static void Main(string[] args)
        {
            //var testList = new List<IAPITest>();
            Assembly ass = Assembly.GetAssembly(typeof(IAPITest));
            Type[] types = ass.GetTypes();
            foreach (Type item in types)
            {
                try
                {
                    if (!item.IsClass || item.IsAbstract)
                        continue;

                    var x = item.GetConstructors();
                    if (x.Length == 0)
                        continue;

                    var obj = ass.CreateInstance(item.FullName);
                    if (obj is IAPITest)
                    {
                        var objapi = obj as IAPITest;
                        objapi.Invoke("11");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }


            Console.ReadLine();

        }
    }
}
