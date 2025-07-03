using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Ex02
{
    internal interface ISeries
    {
        int Current { set; get; }
        void Next();
        void Reset();
    }
}
