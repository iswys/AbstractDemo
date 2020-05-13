using AbstractDemo.Abstract;
using System;

namespace AbstractDemo.Service
{
    public class Python : AbstractLanguage, IService
    {
        public void Grade()
        {
            Console.WriteLine("Number Python");
        }

        public override void HelloWord()
        {
            Console.WriteLine("Python Hello World!");
        }

        public override void SystemLanguage()
        {
            Console.WriteLine("Python");
        }
    }
}
