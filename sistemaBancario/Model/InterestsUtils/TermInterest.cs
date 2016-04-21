using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.InterestsUtils
{
    interface TermInterest
    {
        int Term
        {
            set;
        }
        double AnnualInterest
        {
            get;
        }
    }
}
