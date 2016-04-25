using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Products
{
    public abstract class InvestementProduct  : SavingInvestementProduct
    {
        protected AbstractInterestPerformance _interestPerformance;

        public void setInterestPerformance(AbstractInterestPerformance interestPerformance)
        {
            _interestPerformance = interestPerformance;
        }

        public override void setInterestTable(InterestsUtils.InterestTable interest)
        {
            _interestPerformance.setInterestTable(interest);
        }

        public override decimal getTax()
        {
            return this.taxStrategy.calculateTaxDedution(this._interestPerformance.getInterestEarned);
        }

    }
}
