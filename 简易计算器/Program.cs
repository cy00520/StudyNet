using System;

namespace 简易计算器
{
    class Program
    {
        static void Main(string[] args)
        {

            //V1();
            //V2();
            V3();

        }

        static void V1()
        {
            Console.WriteLine("请输入第一个数");
            var A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("输入+-*/");
            var B = Console.ReadLine();
            Console.WriteLine("请输入第二个数");
            var C = Convert.ToDouble(Console.ReadLine());
            double D = 0;
            if (B == "+") D = A + C;
            if (B == "-") D = A - C;
            if (B == "*") D = A * C;
            if (B == "/") D = A / C;
            Console.WriteLine("结果：" + D);
        }

        static void V2()
        {
            try
            {
                Console.WriteLine("请输入第一个数");
                var numberOne = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("输入+-*/");
                var operationType = Console.ReadLine();
                Console.WriteLine("请输入第二个数");
                var numberTwo = Convert.ToDouble(Console.ReadLine());
                double operationResult = 0;
                switch (operationType)
                {
                    case "+":
                        operationResult = numberOne + numberTwo;
                        break;
                    case "-":
                        operationResult = numberOne - numberTwo;
                        break;
                    case "*":
                        operationResult = numberOne * numberTwo;
                        break;
                    case "/":
                        if (numberTwo <= 0)
                        {
                            throw new Exception("除数不能为0");
                        }
                        operationResult = numberOne / numberTwo;
                        break;
                    default:
                        throw new Exception("运算符错误");
                }
                Console.WriteLine("结果：" + operationResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine("您的输入有错误;" + ex.Message);
            }
        }

        static void V3()
        {
            try
            {
                Console.WriteLine("请输入第一个数");
                var numberOne = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("输入+-*/");
                var operationType = Console.ReadLine();
                Console.WriteLine("请输入第二个数");
                var numberTwo = Convert.ToDouble(Console.ReadLine());
                double operationResult = OperationV3.CreateOperation(numberOne, numberTwo, operationType);
                Console.WriteLine("结果：" + operationResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine("您的输入有错误;" + ex.Message);
            }
        }
    }
}



//Console.WriteLine("计算器【简单工厂模式】");
//            try
//            {

//                Console.WriteLine("请输入第一个数");
//                var NumberOne = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("输入+-*/0,1,2,3");
//                var oper = OperationFactory.CreateOperation((OperationFactory.OperationStr)Convert.ToInt32(Console.ReadLine()));
//oper.NumberA = NumberOne;
//                Console.WriteLine("请输入第二个数");
//                var NumberTwo = Convert.ToDouble(Console.ReadLine());
//oper.NumberB = NumberTwo;

//                var Result = oper.GetResult();

//Console.WriteLine("答案:" + Result);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("输入错误:" + ex.Message);
//            }