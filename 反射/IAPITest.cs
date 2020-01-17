using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 反射
{
    interface IAPITest
    {
        string APICode { get; }
        string APIName { get; }

        void Invoke(string testModel);
    }
}
