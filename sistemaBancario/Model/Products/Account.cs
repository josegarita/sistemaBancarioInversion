using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Products
{
    public abstract class Account : SavingInvestementProduct
    {
        protected AbstractInterestPerformance _interestPerformance;

        public void setInterestPerformance(AbstractInterestPerformance interestPerformance)
        {
            _interestPerformance = interestPerformance;
        }

        public AbstractInterestPerformance getInterestPerformance()
        {
            return _interestPerformance;
        }

        public override void setInterestTable(InterestsUtils.InterestTable interest)
        {
            
        }

    }
}
