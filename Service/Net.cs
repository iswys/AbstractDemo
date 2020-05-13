using AbstractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDemo.Service
{
    public class Net : AbstractLanguage, IService
    {
        public void Grade()
        {
            Console.WriteLine("Number  Net");
        }

        public override void HelloWord()
        {
            Console.WriteLine("Net Hello World!");
        }

        public override void SystemLanguage()
        {
            Console.WriteLine("Net");
        }
    }
}
