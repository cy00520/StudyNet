using System;

namespace 策略简述
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new ConcreteStrategyB());
            context.ContextInterface();
        }
    }
}
