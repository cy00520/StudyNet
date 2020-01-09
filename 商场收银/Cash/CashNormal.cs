using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 商场收银.Cash
{
    /// <summary>
    /// 实现正常收费接口
    /// </summary>
    class CashNormal : ICashSuper
    {
        public double AcceptCash(double money)
        {
            return money;
        }
    }
}
