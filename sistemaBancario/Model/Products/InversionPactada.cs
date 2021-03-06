﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Products;
using Model.Verifiers;


namespace Model.Products
{
    public class InversionPactada : InvestementProduct
    {
        public InversionPactada()
        {
            _interestPerformance = new InterestPerformanceByTerm();
            taxStrategy = new TaxStrategy.NullTaxStrategy();
        }

        public override void calculateInterest()
        {
            _interestPerformance.calculateBalance(this.amount, this.termInDays);
        }

        public override float getAnnualInterest()
        {
            return _interestPerformance.getAnnualInterest;
        }

        public override decimal getFinalBalance()
        {
            decimal tax = taxStrategy.calculateTaxDedution(_interestPerformance.getInterestEarned);

            decimal realInterestEarned = _interestPerformance.getInterestEarned - tax;

            return this.amount + realInterestEarned;
        }

        public override decimal InterestEarned()
        {
            return _interestPerformance.getInterestEarned;
        }
    }
}
