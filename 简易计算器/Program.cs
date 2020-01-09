using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("计算器【简单工厂模式】");
            try
            {

                Console.WriteLine("请输入第一个数");
                var NumberA = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("输入+-*/|0,1,2,3");
                var oper = OperationFactory.CreateOperation((OperationFactory.OperationStr)Convert.ToInt32(Console.ReadLine()));
                oper.NumberA = NumberA;
                Console.WriteLine("请输入第二个数");
                oper.NumberB = Convert.ToDouble(Console.ReadLine());

                var Result = oper.GetResult();

                Console.WriteLine("答案:" + Result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("输入错误:" + ex.Message);
            }

        }
    }
}
