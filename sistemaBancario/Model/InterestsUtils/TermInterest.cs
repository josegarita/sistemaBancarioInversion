using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.InterestsUtils
{
    public interface TermInterest
    {

        decimal Amount
        {
            set;
            get;
        }

        int Term
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
