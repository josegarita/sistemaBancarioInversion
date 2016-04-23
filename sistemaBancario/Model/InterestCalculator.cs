﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model.Factory;
using Model.Products;
using Model.Verifiers;

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

        public string calculateInterestPerformance(decimal amount, int termInDays, MoneyType money)
        {
            

            SavingInvestementProduct product = _factory.createProduct();
            ServiceVerifier verifier = _factory.createVerify();

            


            return "Hola";
        }

    }
}