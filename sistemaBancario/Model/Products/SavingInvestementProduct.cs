using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Products
{
    abstract class SavingInvestementProduct
    {
        protected decimal amount;

        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

       

        protected int ermInDays;

        public int ErmInDays
        {
            get { return ermInDays; }
            set { ermInDays = value; }
        }
        protected MoneyType currency;

        public MoneyType Currency
        {
            get { return currency; }
            set { currency = value; }
        }
        protected DateTime creationDate;

        public DateTime CreationDate
        {
            get { return creationDate; }
            set { creationDate = value; }
        }
     
      
    }
   
}
