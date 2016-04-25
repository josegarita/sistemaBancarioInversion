using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Products;

namespace Model.Verifiers
{
    public abstract class ServiceVerifier
    {
        protected MoneyType currency;
        protected decimal miniumMoneyAmount;
        protected SavingInvestementProduct product;

        public MoneyType Currency
        {
            get { return currency; }
            set { currency = value; }
        }
       

        public SavingInvestementProduct Product
        {
            get { return product; }
            set { product = value; }
        }
        

        public decimal MiniumMoneyAmount
        {
            get { return miniumMoneyAmount; }
            set { miniumMoneyAmount = value; }
        }

        public abstract ProductServiceMessage canServiceBeOpen();
    }
}
