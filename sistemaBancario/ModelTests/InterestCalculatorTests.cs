using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Tests
{
    [TestClass()]
    public class InterestCalculatorTests
    {
        [TestMethod()]
        public void InterestCalculatorTest()
        {
            //Assert.Fail();
        }

        [TestMethod()]
        public void calculateInterestPerformanceTest()
        {
            //Cuenta Corriente
            
            InterestCalculator calculator = new InterestCalculator("CuentaCorriente");
            decimal finalBalance = calculator.calculateInterestPerformance(1000000, 31, Model.Products.MoneyType.Colones);
            /*
            Assert.AreEqual(Math.Round(finalBalance, 2), 1001722.22M);

            finalBalance = calculator.calculateInterestPerformance(2650000, 21, Model.Products.MoneyType.Colones);
            Assert.AreEqual(Math.Round(finalBalance, 2), 2653864.58M);
            */

            //Vista Pactada
            
            calculator = new InterestCalculator("CertificadoDeDeposito");
            finalBalance = calculator.calculateInterestPerformance(2500000, 48, Model.Products.MoneyType.Colones);
            Assert.AreEqual(Math.Round(finalBalance, 2), 2516560.00M);
            

          

        }
    }
}