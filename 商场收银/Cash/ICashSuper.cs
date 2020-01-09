using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 商场收银.Cash
{
    /// <summary>
    /// 策略接口定义
    /// </summary>
    interface ICashSuper
    {
        double AcceptCash(double money);
    }
}
