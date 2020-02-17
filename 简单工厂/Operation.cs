using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂
{
    /// <summary>
    /// 算法抽象基类
    /// </summary>
    public abstract class Operation
    {
        public double NumberOne { get; set; }
        public double NumberTwo { get; set; }
        public abstract double GetResult();
    }
}
