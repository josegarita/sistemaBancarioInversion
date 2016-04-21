using Model.InterestsUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.InterestCalculationStrategy
{
    public interface ICalculateInterestTermStrategy
    {
        InterestResult calculateInterest(TermInterest interest);
    }
}
