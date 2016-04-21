using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.InterestCalculationStrategy
{
    interface ICalculateInterestByAmountStrategy
    {
        InterestResult calculateInterest(int pCantDias);
    }
}
