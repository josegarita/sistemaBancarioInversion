using System;
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
            
        }

        public override void calculateInterest()
        {
            throw new NotImplementedException();
        }

        public override float getAnnualInterest()
        {
            throw new NotImplementedException();
        }

        public override decimal getFinalBalance()
        {
            throw new NotImplementedException();
        }

        public override decimal InterestEarned()
        {
            throw new NotImplementedException();
        }
    }
}
