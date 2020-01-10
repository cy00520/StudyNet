using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 商场收银.Cash
{
    /// <summary>
    /// 实现打折收费接口
    /// </summary>
    class CashRebate : CashSuper
    {
        readonly double _moneyRebate = 1d;
        public CashRebate(string moneyRebate)
        {
            _moneyRebate = double.Parse(moneyRebate);
        }

        public override double AcceptCash(double money)
        {
            return money * _moneyRebate;
        }
    }
}
