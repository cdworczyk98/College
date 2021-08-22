using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsPayable
{
    class IPayable
    {
        public interface IPayable
        {
            decimal GetPaymentAmount();
        }
    }
}
