using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_ADTs
{
    interface IStackADT
    {
        void push(int value);
        int pop();
        bool isEmpty();
        int size();
    }
}
