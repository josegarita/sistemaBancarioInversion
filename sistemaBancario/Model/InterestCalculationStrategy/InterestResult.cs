using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.InterestCalculationStrategy
{
    class InterestResult
    {
        private double _annualInterest;
        private decimal _interestEarned;
        private decimal _finalBalanceWithInterest;
        private string _message;

        public double AnnualInterest
        {
            set
            {
                _annualInterest = value;
            }
            get
            {
                return _annualInterest;
            }
        }

        public decimal InterestEarned
        {
            set
            {
                _interestEarned = value;
            }
            get
            {
                return _interestEarned;
            }
        }

        public decimal FinalBalance
        {
            set
            {
                _finalBalanceWithInterest = value;
            }
            get
            {
                return _finalBalanceWithInterest;
            }
        }

        public string Message
        {
            set
            {
                _message = value;
            }
            get
            {
                return _message;
            }
        }

        
    }
}
