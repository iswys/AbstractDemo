using AbstractDemo.Abstract;
using AbstractDemo.Service;
using System;

namespace AbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Abstract Begin ");
            {
                AbstractLanguage abstractLanguage = new Java();
                abstractLanguage.SystemLanguage();
                abstractLanguage.HelloWord();

            }
            {
                AbstractLanguage abstractLanguage = new Net();
                abstractLanguage.SystemLanguage();
                abstractLanguage.HelloWord();

            }
            {
                AbstractLanguage abstractLanguage = new Python();
                abstractLanguage.SystemLanguage();
                abstractLanguage.HelloWord();

            }
            Console.WriteLine("Abstract End ");
            Console.WriteLine("");
            Console.WriteLine("=======================================================");
            Console.WriteLine("");
            Console.WriteLine("Interface Begin ");
            {
                IService service = new Java();
                service.Grade();

            }
            {
                IService service = new Net();
                service.Grade();

            }
            {
                IService service = new Python();
                service.Grade();
            }
            Console.WriteLine("Interface End ");
            Console.WriteLine("");
            Console.WriteLine("=======================================================");
            Console.WriteLine("");
            // 如何在接口 即打印 抽象方法  and 打印实现
            Console.WriteLine(" Abstract && Interface Begin ");
            {
                IService service = new Java();
                dynamic dService = service;
                dService.Grade();
                dService.SystemLanguage();
                dService.HelloWord();

            }
            {
                IService service = new Net();
                dynamic dService = service;
                dService.Grade();
                dService.SystemLanguage();
                dService.HelloWord();

            }
            {
                IService service = new Python();
                dynamic dService = service;
                dService.Grade();
                dService.SystemLanguage();
                dService.HelloWord();
            }
            Console.WriteLine(" Abstract && Interface End ");
        }
    }
}
