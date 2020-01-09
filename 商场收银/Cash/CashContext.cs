using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 商场收银.Cash
{
    /// <summary>
    /// 策略工厂，暴露对外目前是具体实现方法
    /// </summary>
    public class CashContext
    {
        private readonly ICashSuper _cashSuper;
        public CashContext(string style)
        {
            switch (style)
            {
                case "正常收费":
                    _cashSuper = new CashNormal();
                    break;
                case "打8折":
                    _cashSuper = new CashRebate("0.8");
                    break;
                case "满200减10":
                    _cashSuper = new CashReturn("200", "10");
                    break;
                default:
                    break;
            }
        }
        public double GetResult(double money)
        {
            return _cashSuper.AcceptCash(money);
        }
    }
}
