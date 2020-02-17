using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂
{
    public class OperationFactory
    {
        /// <summary>
        /// 算法工厂类，根据调用者需要什么方法进行实例化什么方法给它即可
        /// </summary>
        /// <param name="opertion"></param>
        /// <returns></returns>
        public static Operation CreateOperation(string operationStr)
        {

            Operation oper;
            switch (operationStr)
            {
                case "+":
                    oper = new OperationPlus();
                    break;
                case "-":
                    oper = new OperationReduce();
                    break;
                case "*":
                    oper = new OperationRide();
                    break;
                case "/":
                    oper = new OperationExcept();
                    break;
                default:
                    throw new Exception("请输入正确的+-*/");
            }
            return oper;
        }
    }

    /// <summary>
    /// 加法实现类
    /// </summary>
    class OperationPlus : Operation
    {
        public override double GetResult()
        {
            return NumberOne + NumberTwo;
        }
    }
    /// <summary>
    /// 减法实现类
    /// </summary>
    class OperationReduce : Operation
    {
        public override double GetResult()
        {
            return NumberOne - NumberTwo;
        }
    }
    /// <summary>
    /// 乘法实现类
    /// </summary>
    class OperationRide : Operation
    {
        public override double GetResult()
        {
            return NumberOne * NumberTwo;
        }
    }
    /// <summary>
    /// 除法实现类
    /// </summary>
    class OperationExcept : Operation
    {
        public override double GetResult()
        {
            if (NumberTwo == 0)
            {
                throw new Exception("除数不能等于0");
            }
            return NumberOne / NumberTwo;
        }
    }
}
