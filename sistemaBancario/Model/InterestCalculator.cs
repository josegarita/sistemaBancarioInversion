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
            //Se obtiene la fábrica correspondiente
            _factory = ServiceFactory.GetFactoryFor(productType);
            _productType = productType;
        }

        public CalculatorMessage calculateInterestPerformance(decimal amount, int termInDays, MoneyType money)
        {
            //Se genera la caja para encapsular el resultado
            CalculatorMessage result = new CalculatorMessage();
      
            //Se obtiene los productos
            SavingInvestementProduct product = _factory.createProduct();
            
            product.Amount = amount;
            product.TermInDays = termInDays;
            product.Currency = money;
            
            //Se crea el verficador para procesar el producto de inversión y ahorro
            ServiceVerifier verifier = _factory.createVerify();
            verifier.Product = product;

            //Verificar la apertura del servicio
            ProductServiceMessage verifyMessage = verifier.canServiceBeOpen();

            if (verifyMessage.CanBeOpen == true)
            {
                //Se crea la tabla de intereses para el producto de inversión y ahorro; más se le adjunta al producto
                string tableInterest = _productType + money.ToString();
                InterestTable interestTable = InterestTableFactory.GetInterestTableFor(tableInterest);
                product.setInterestTable(interestTable);

                //Se calcula el rendimiento del producto
                product.calculateInterest();

                result.InterestEarned = product.InterestEarned();
                result.FinalBalance = product.getFinalBalance();
                result.TaxApplied = product.getTax();

            }
            else
            {
             
                result.InterestEarned = 0;
                result.FinalBalance = 0;
                result.TaxApplied = 0;
            }

            result.Message = verifyMessage.Message;
           return result;
        }

    }
}
