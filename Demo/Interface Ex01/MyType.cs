using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Ex01
{
    internal class MyType : IMyType
    {
        public double Salary {  get; set; }
        public void MyFun()
        {
            Console.WriteLine("Hello World");
        }
    }
}
