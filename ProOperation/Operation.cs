using System;

namespace ProOperation
{
    public abstract class Operation
    {
        public double NumberOne { get; set; }
        public double NumberTwo { get; set; }
        public Operation(double n1, double n2)
        {
            NumberOne = n1;
            NumberTwo = n2;
        }

        //计算子类的计算类型+-*/
        public abstract string Type { get; }
        public abstract double GetResult();

    }
}
