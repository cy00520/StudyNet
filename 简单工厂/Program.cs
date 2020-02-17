using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("请输入第一个数");
                var numberOne = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("输入+-*/");
                var operationType = Console.ReadLine();
                Console.WriteLine("请输入第二个数");
                var numberTwo = Convert.ToDouble(Console.ReadLine());

                var Operation = OperationFactory.CreateOperation(operationType);
                Operation.NumberOne = numberOne;
                Operation.NumberTwo = numberTwo;
                double operationResult = Operation.GetResult();
                Console.WriteLine("结果：" + operationResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine("您的输入有错误;" + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
