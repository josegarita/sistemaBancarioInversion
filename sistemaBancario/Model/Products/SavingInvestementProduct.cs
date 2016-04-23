using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Products
{
    public abstract class SavingInvestementProduct
    {
        protected decimal amount;
        protected int termInDays;
        protected MoneyType currency;
        protected DateTime creationDate;

        public decimal Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }

       
        public int TermInDays
        {
            get
            {
                return termInDays;
            }
            set
            {
                termInDays = value;
            }
        }
        
        public MoneyType Currency
        {
            get
            {
                return currency;
            }
            set
            {
                currency = value;
            }
        }
       
        public DateTime CreationDate
        {
            get
            {
                return creationDate;
            }
            set
            {
                creationDate = value;
            }
        }


        public abstract void calculateInterest();

        public abstract decimal getFinalBalance();

        public abstract float getAnnualInterest();

        public abstract decimal InterestEarned();

        public abstract void setInterestTable(InterestsUtils.InterestTable interest);


    }
   
}
