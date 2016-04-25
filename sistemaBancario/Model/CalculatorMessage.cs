using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CalculatorMessage
    {
        public decimal InterestEarned
        {
            set;
            get;
        }

        public decimal TaxApplied
        {
            set;
            get;
        }

        public decimal FinalBalance
        {
            set;
            get;
        }

        public string Message
        {
            set;
            get;
        }
    }
}
