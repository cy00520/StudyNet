using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("陈远");
            Console.WriteLine("\n 第一种装扮：");
            TShirts shirts = new TShirts();
            BigTrouser bigTrouser = new BigTrouser();
            Sneakers sneakers = new Sneakers();

            shirts.Show();
            bigTrouser.Show();
            sneakers.Show();
            person.Show();
            Console.ReadLine();
        }
    }
}
