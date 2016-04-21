using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.InterestsUtils
{
    public interface AmountInterest
    {
        decimal Amount
        {
            set;
            get;
        }

        double AnnualInterest
        {
            get;
        }
    }
}
