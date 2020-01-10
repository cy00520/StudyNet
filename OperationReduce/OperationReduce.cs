using ProOperation;
using System;

namespace OperationReduce
{
    public class OperationReduce : Operation
    {
        public OperationReduce(double n1, double n2) : base(n1, n2) { }

        public override string Type => "-";

        public override double GetResult()
        {
            return NumberOne - NumberTwo;
        }
    }
}
