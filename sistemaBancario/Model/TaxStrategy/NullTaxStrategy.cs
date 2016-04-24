using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.TaxStrategy
{
    public class NullTaxStrategy : TaxDeductionStrategy
    {
        public decimal calculateTaxDedution(decimal pAmount)
        {
            return 0M;
        }
    }
}
