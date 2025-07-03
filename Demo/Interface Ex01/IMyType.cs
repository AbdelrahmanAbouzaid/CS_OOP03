using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Ex01
{
    internal interface IMyType
    {
        // What Can Write Inside The Interface
        // 1. Signature Of Propreties
        // 2. Signature Of Methods  [Name , Parameter , Return Type]
        // 3. Default Emplemented Methods [Fully Implemented Method]


        // 1. Signature Of Propreties
        double Salary {  get; set; }

        // 2. Signature Of Methods  [Name , Parameter , Return Type]
        void MyFun();

        // 3. Default Emplemented Methods [Fully Implemented Method]
        void Print()
        {
            Console.WriteLine("Default Emplemented Methods [Fully Implemented Method]");
        }
    }
}
