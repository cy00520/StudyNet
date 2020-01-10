using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 商场收银.Cash
{
    /// <summary>
    /// 实现满减收费接口
    /// </summary>
    class CashReturn : CashSuper
    {
        readonly double _moneyCondition = 0.0d;
        readonly double _moneyReturn = 0.0d;
        public CashReturn(string moneyCondition, string moneyReturn)
        {
            _moneyCondition = double.Parse(moneyCondition);
            _moneyReturn = double.Parse(moneyReturn);
        }
        public override double AcceptCash(double money)
        {
            var result = money;
            if (result >= _moneyCondition)
            {
                result = money - (Math.Floor(money / _moneyCondition) * _moneyReturn);
            }
            return result;
        }
    }
}
