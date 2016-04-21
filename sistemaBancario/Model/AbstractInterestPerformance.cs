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
        protected double _annualInterest;

        public decimal getInterestEarned
        {
            get
            {
                return _interestEarned;
            }
        }

        public double getAnnualInterest
        {
            get
            {
                return _annualInterest;
            }
        }

        public abstract decimal calculateBalance(int  pTermInDays);
    }
}
