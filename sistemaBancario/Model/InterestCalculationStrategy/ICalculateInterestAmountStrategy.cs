﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Model.InterestsUtils;

namespace Model.InterestCalculationStrategy
{
    public interface ICalculateInterestAmountStrategy
    {
        InterestResult calculateInterest(int pCantDias, AmountInterest interest);
    }
}
