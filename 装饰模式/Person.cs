﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    class Person
    {
        private string name;
        public Person(string name)
        {
            this.name = name;
        }
        
        public void Show()
        {
            Console.WriteLine("装扮的" + this.name);
        }
    }
}
