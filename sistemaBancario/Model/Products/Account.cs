using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Products
{
    class Account:SavingInvestementProduct
    {
        public void calculateInterest(){
        }
        public MoneyType getFinalBalance() {
            MoneyType m =  MoneyType.Colones;
            return m;
        }
        public float getAnnualInterest() {
            return (float)1.1;
        }
        public MoneyType InterestEarned() {
            return MoneyType.Colones;
        }
    }
}
