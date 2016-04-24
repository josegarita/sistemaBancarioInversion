using Model.InterestCalculationStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class AbstractInterestPerformance
    {
        protected decimal _interestEarned;
        protected float _annualInterest;


        public decimal getInterestEarned
        {
            get
            {
                return _interestEarned;
            }
        }

        public float getAnnualInterest
        {
            get
            {
                return _annualInterest;
            }
        }

        public abstract decimal calculateBalance(decimal pAmount, int  pTermInDays);
        public abstract void setInterestTable(Model.InterestsUtils.InterestTable interest);

    }
}
