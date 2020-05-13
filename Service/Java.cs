using AbstractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDemo.Service
{
    public class Java : AbstractLanguage, IService
    {
        public void Grade()
        {
            Console.WriteLine("Number Java ");
        }

        public override void HelloWord()
        {
            Console.WriteLine("Java Hello World!");
        }

        public override void SystemLanguage()
        {
            Console.WriteLine("Java");
        }
    }
}
