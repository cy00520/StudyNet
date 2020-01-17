using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 反射
{
    public class T101480 : IAPITest
    {
        public string APICode => "101480";

        public string APIName => "重点人口关注名单";

        public void Invoke(string testModel)
        {
            Console.WriteLine(APICode);
        }
    }
}
