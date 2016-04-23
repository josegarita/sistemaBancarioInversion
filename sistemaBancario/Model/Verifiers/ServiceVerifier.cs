using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Products;

namespace Model.Verifiers
{
    public class ServiceVerifier
    {
        protected MoneyType currency;

        public MoneyType Currency
        {
            get { return currency; }
            set { currency = value; }
        }
        protected SavingInvestementProduct product;

        public SavingInvestementProduct Product
        {
            get { return product; }
            set { product = value; }
        }
        private decimal miniumMoneyAmount;

        public decimal MiniumMoneyAmount
        {
            get { return miniumMoneyAmount; }
            set { miniumMoneyAmount = value; }
        }
    }
}
