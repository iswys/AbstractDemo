using AbstractDemo.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDemo.Abstract
{
    public abstract class AbstractLanguage 
    {

        public string Test { get; set; }

        public abstract void HelloWord();
       
        public abstract void SystemLanguage();
    }
}
