using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.TaxStrategy
{
    public class CertificadoRentaDeductionStrategy : TaxDeductionStrategy
    {
        public decimal calculateTaxDedution(decimal pAmount)
        {
            return pAmount * 0.08M;
        }
    }
}
