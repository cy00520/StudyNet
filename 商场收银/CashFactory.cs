using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 商场收银
{
    public class CashFactory
    {
        /// <summary>
        /// 收费对象生成工厂
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static CashSuper CreateCashAccecpt(string type)
        {
            CashSuper cashSuper = null;
            switch (type)
            {
                case "正常收费":
                    cashSuper = new CashNormal();
                    break;
                case "打8折":
                    cashSuper = new CashRebate("0.8");
                    break;
                case "满200减10":
                    cashSuper = new CashReturn("200", "10");
                    break;
                default:
                    break;
            }
            return cashSuper;
        }
        /// <summary>
        /// 正常收费
        /// </summary>
        class CashNormal : CashSuper
        {
            public override double AcceptCash(double money)
            {
                return money;
            }
        }

        /// <summary>
        /// 打折收费
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

        /// <summary>
        /// 满减收费
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

        /// <summary>
        /// 工厂抽象基类
        /// </summary>
        public abstract class CashSuper
        {
            public abstract double AcceptCash(double money);
        }
    }
}
