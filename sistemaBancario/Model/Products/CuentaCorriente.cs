using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Products
{
    public class CuentaCorriente : Account
    {

        

        public CuentaCorriente ()
        {
            
        }

        public override void calculateInterest()
        {
            _interestPerformance.calculateBalance(this.amount, this.termInDays);
         
        }

        public override float getAnnualInterest()
        {
            throw new NotImplementedException();
        }

        public override decimal getFinalBalance()
        {
            throw new NotImplementedException();
        }

        public override decimal InterestEarned()
        {
            throw new NotImplementedException();
        }
    }
}
