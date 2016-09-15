using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model.Factory;
using Model.Products;
using Model.Verifiers;
using Model.InterestsUtils;

namespace Model
{
    public class InterestCalculator
    {

        private AbstractProductServiceFactory _factory;
        private string _productType;

        public InterestCalculator(string productType)
        {
            _factory = ServiceFactory.GetFactoryFor(productType);
            _productType = productType;
        }

        public decimal calculateInterestPerformance(decimal amount, int termInDays, MoneyType money)
        {
            
            SavingInvestementProduct product = _factory.createProduct();

            product.Amount = amount;
            product.TermInDays = termInDays;
            product.Currency = money;
            
            ServiceVerifier verifier = _factory.createVerify();

            InterestTable interestTable = InterestTableFactory.GetInterestTableFor(_productType);

            

            product.setInterestTable(interestTable);


            product.calculateInterest();


            return product.getFinalBalance();
        }

    }
}
