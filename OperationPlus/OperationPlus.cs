using ProOperation;
using System;

namespace OperationPlus
{
    public class OperationPlus : Operation
    {
        public OperationPlus(double n1, double n2) : base(n1, n2) { }

        public override string Type => "+";

        public override double GetResult()
        {
            return NumberOne + NumberTwo;
        }
    }
}
