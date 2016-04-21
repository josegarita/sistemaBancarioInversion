using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.InterestsUtils
{
    class CurrentAccountInterest : AmountInterest
    {
        private decimal _amount;    

        public decimal Amount
        {
            set
            {
                _amount = value;
            }
        }

        public double AnnualInterest
        {
            get
            {
                if (_amount >= 25000 && _amount <= 500000)
                {
                    return 0.01; // 1 %
                }
                if (_amount > 500000 && _amount <= 1000000 )
                {
                    return 0.02; // 2 %
                }
                if (_amount > 1000000 && _amount <= 2500000)
                {
                    return 0.0225; // 2.25 %
                }
                if (_amount > 2500000 && _amount <= 10000000)
                {
                    return 0.025; //2.50 %
                }
                if (_amount > 1000000)
                {
                    return 0.0275; // 2.75 %
                }
                return 1.0;
            }
        }
    }
}
