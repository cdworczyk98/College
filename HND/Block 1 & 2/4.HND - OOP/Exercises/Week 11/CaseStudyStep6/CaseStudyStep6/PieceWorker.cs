using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyStep6
{
    class PieceWorker:Employee
    {
        private decimal wage;
        private decimal pieces;

        // Property that gets and sets baseSalary
        public decimal Wage
        {
            get{return wage; }
            set{wage = value;}
        }

        public decimal Pieces
        {
            get{return pieces; }
            set{pieces = value;}
        }

        // 6 parameter constructor
        public PieceWorker(string first, string last, string ssn, decimal wage, decimal pieces)
            : base(first, last, ssn)
        {
            Wage = wage;
            Pieces = pieces;

        }

        // calculate earnings.  Override CommissionEmployee Earnings
        public override decimal Earnings()
        {
            return wage * pieces;

        }

        // return string representation of BasePlusCommissionEmployee object
        public override string ToString()
        {
            return string.Format("piece-worker {0}; wage: {1:C}; pieces: {2}", base.ToString(), Wage, Pieces);
        }
    }
}
