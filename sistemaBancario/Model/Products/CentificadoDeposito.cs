using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Products
{
    public class CentificadoDeposito : InvestementProduct
    {

        public CentificadoDeposito()
        {
            _interestPerformance = new InterestPerformanceByTerm();
            taxStrategy = new TaxStrategy.CertificadoRentaDeductionStrategy();
        }

        public override void calculateInterest()
        {
            _interestPerformance.calculateBalance(this.amount, this.termInDays);
        }

        public override float getAnnualInterest()
        {
            return _interestPerformance.getAnnualInterest;
        }

        public override decimal getFinalBalance()
        {
            decimal taxDeduction = taxStrategy.calculateTaxDedution(_interestPerformance.getInterestEarned);
            decimal amountWithTax = (this.amount + _interestPerformance.getInterestEarned) - taxDeduction;
            return amountWithTax;
        }

        public override decimal InterestEarned()
        {
            return taxStrategy.calculateTaxDedution(_interestPerformance.getInterestEarned);
        }
    }
}
