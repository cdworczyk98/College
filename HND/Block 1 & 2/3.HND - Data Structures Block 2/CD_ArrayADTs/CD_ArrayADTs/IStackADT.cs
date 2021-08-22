using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_ArrayADTs
{
    interface IStackADT
    {
        Boolean isEmpty();
        void push(int element);
        int pop();
        int size();
    }
}
