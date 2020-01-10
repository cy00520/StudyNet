using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace 简易计算器Reflection
{
    /// <summary>
    /// 反射扩展
    /// </summary>
    public class OperationFactory
    {
        //public static Operation GetOper(string type, double n1, double n2)
        //{
        //    Operation oper = null;
        //    //将前面add生成的dll文件放在debug下的plug文件夹下

        //    //获得当前的路径,当前的文件夹的路径
        //    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plug");

        //    //获得path路径下的所有文件的全路径
        //    string[] files = Directory.GetFiles(path, "*.dll");

        //    //遍历files，加载所有的程序集文件
        //    foreach (string item in files)
        //    {
        //        //动态的获得程序集
        //        Assembly ass = Assembly.LoadFile(item);

        //        //ass.GetType()获得指定的程序
        //        //ass.GetTypes() 获得所有的程序，不管是不是public
        //        //获得程序集文件中所有公开的数据类型
        //        Type[] types = ass.GetExportedTypes();

        //        foreach (Type tt in types)
        //        {
        //            //判断当前数据类型是否是我们需要的数据类型
        //            //tt是否是opeartion的子类，并且是抽象的
        //            if (tt.IsSubclassOf(typeof(Operation)) && !tt.IsAbstract)
        //            {
        //                //创建子类对象 赋值给oper
        //                oper = (Operation)Activator.CreateInstance(tt, n1, n2);
        //                if (type == oper.Type)
        //                {
        //                    return oper;
        //                }
        //                else
        //                {
        //                    oper = null;
        //                }
        //            }
        //        }
        //    }
        //    return oper;
        //}
    }
}
