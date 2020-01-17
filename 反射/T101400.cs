using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 反射
{
    public class T101400 : IAPITest
    {
        public string APICode => "101400";

        public string APIName => "重点人口筛查";

        public void Invoke(string testModel)
        {
            Console.WriteLine(APICode);
        }
    }
}
