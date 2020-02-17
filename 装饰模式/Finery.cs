using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    abstract class Finery
    {
        public abstract void Show();
    }
    class TShirts : Finery
    {
        /// <summary>
        /// 大T恤
        /// </summary>
        public override void Show()
        {
            Console.Write("大 T 恤 ");
        }
    }

    class BigTrouser : Finery
    {
        /// <summary>
        /// 垮裤
        /// </summary>
        public override void Show()
        {
            Console.Write("垮裤 ");
        }
    }

    class Sneakers : Finery
    {
        /// <summary>
        /// 破球鞋
        /// </summary>
        public override void Show()
        {
            Console.Write("破球鞋 ");
        }
    }

    class Suit : Finery
    {
        /// <summary>
        /// 西装
        /// </summary>
        public override void Show()
        {
            Console.Write("西装 ");
        }
    }

    class Tie : Finery
    {
        /// <summary>
        /// 领带
        /// </summary>
        public override void Show()
        {
            Console.Write("领带 ");
        }
    }

    class LeatherShoes : Finery
    {
        /// <summary>
        /// 皮鞋
        /// </summary>
        public override void Show()
        {
            Console.Write("皮鞋 ");
        }
    }
}
