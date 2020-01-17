using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace 简易计算器
{

    public class OperationV3
    {
        public static double CreateOperation(double numberOne, double numberTwo, string operationType)
        {
            double operationResult;
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
            return operationResult;
        }
    }


    public class OperationFactory
    {
        /// <summary>
        /// 算法工厂类，根据调用者需要什么方法进行实例化什么方法给它即可
        /// </summary>
        /// <param name="opertion"></param>
        /// <returns></returns>
        public static Operation CreateOperation(OperationStr operationStr)
        {

            Operation oper = null;
            switch (operationStr)
            {
                case OperationStr.Plus:
                    oper = new OperationPlus();
                    break;
                case OperationStr.Reduce:
                    oper = new OperationReduce();
                    break;
                case OperationStr.Ride:
                    oper = new OperationRide();
                    break;
                case OperationStr.Except:
                    oper = new OperationExcept();
                    break;
                default:
                    break;
            }
            return oper;
        }

        public enum OperationStr
        {
            Plus,
            Reduce,
            Ride,
            Except
        }
    }


    /// <summary>
    /// 加法实现类
    /// </summary>
    class OperationPlus : Operation
    {
        public override double GetResult()
        {
            return NumberA + NumberB;
        }
    }
    /// <summary>
    /// 减法实现类
    /// </summary>
    class OperationReduce : Operation
    {
        public override double GetResult()
        {
            return NumberA - NumberB;
        }
    }
    /// <summary>
    /// 乘法实现类
    /// </summary>
    class OperationRide : Operation
    {
        public override double GetResult()
        {
            return NumberA * NumberB;
        }
    }
    /// <summary>
    /// 除法实现类
    /// </summary>
    class OperationExcept : Operation
    {
        public override double GetResult()
        {
            if (NumberB == 0)
            {
                throw new Exception("除数不能等于0");
            }
            return NumberA / NumberB;
        }
    }

    /// <summary>
    /// 算法抽象基类
    /// </summary>
    public abstract class Operation
    {
        public double NumberA { get; set; }
        public double NumberB { get; set; }
        public abstract double GetResult();
    }
}
