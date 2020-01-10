using System;

namespace 简易计算器
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("计算器【简单工厂模式】");
            try
            {

                Console.WriteLine("请输入第一个数");
                var NumberOne = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("输入+-*/0,1,2,3");
                var oper = OperationFactory.CreateOperation((OperationFactory.OperationStr)Convert.ToInt32(Console.ReadLine()));
                oper.NumberA = NumberOne;
                Console.WriteLine("请输入第二个数");
                var NumberTwo = Convert.ToDouble(Console.ReadLine());
                oper.NumberB = NumberTwo;

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
