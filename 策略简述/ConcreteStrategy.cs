using System;
using System.Collections.Generic;
using System.Text;

namespace 策略简述
{

    /// <summary>
    ///上下文
    /// </summary>
    public class Context
    {
        Strategy _strategy;
        public Context(Strategy strategy)
        {
            _strategy = strategy;
        }

        //上下文接口
        public void ContextInterface()
        {
            _strategy.AlgorithmInterface();
        }

    }
    public class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("A");
        }
    }

    public class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("B");
        }
    }

    public class ConcreteStrategyC : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("C");
        }
    }
}
