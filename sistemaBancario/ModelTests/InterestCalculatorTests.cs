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
        public void cuentaCorrienteTest()
        {
            CalculatorMessage result;
            InterestCalculator calculator;


            //Cuenta Corriente
            
            calculator = new InterestCalculator("CuentaCorriente");
            
            result = calculator.calculateInterestPerformance(1000000, 31, Model.Products.MoneyType.Colones);
            Assert.AreEqual(Math.Round(result.FinalBalance, 2), 1001722.22M);
            Assert.AreEqual(Math.Round(result.InterestEarned, 2), 1722.22M);
            
            //Verificador
            result = calculator.calculateInterestPerformance(10, 31, Model.Products.MoneyType.Colones);
            Assert.AreEqual(result.FinalBalance, 0);

            result = calculator.calculateInterestPerformance(2650000, 21, Model.Products.MoneyType.Colones);
            Assert.AreEqual(Math.Round(result.FinalBalance, 2), 2653864.58M);
            Assert.AreEqual(Math.Round(result.InterestEarned, 2), 3864.58M);
            

               
           
            
        }

        [TestMethod()]
        public void CertificadoTest()
        {
            CalculatorMessage result;
            InterestCalculator calculator;

            //Certificado 

            calculator = new InterestCalculator("CertificadoDeDeposito");
            result = calculator.calculateInterestPerformance(2500000, 48, Model.Products.MoneyType.Colones);

            Assert.AreEqual(Math.Round(result.FinalBalance, 2), 2516560.00M); //saldo final
            Assert.AreEqual(result.InterestEarned, 18000); // intereses ganados en el plazo
            Assert.AreEqual(result.TaxApplied, 1440); // impuesto de la renta
             
        }

        [TestMethod()]
        public void VistaPactadaTest()
        {
            CalculatorMessage result;
            InterestCalculator calculator = new InterestCalculator("InversionVistaPactada");
            
            //Vista Pactada en colones
            result = calculator.calculateInterestPerformance(1200000, 56, Products.MoneyType.Colones);
            Assert.AreEqual(Math.Round(result.FinalBalance, 2), 1209221.33M);

            //Vista Pactada en dólares
            result = calculator.calculateInterestPerformance(8500, 150, Products.MoneyType.Dolares);
            Assert.AreEqual(Math.Round(result.FinalBalance, 2), 8551);

        }
    }
}