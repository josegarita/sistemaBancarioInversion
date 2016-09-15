using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Model.InterestCalculationStrategy;
using Model.InterestsUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model.InterestsUtils;



namespace Model.Tests
{
    [TestClass()]
    public class InterestPerformanceByAmountTests
    {
        [TestMethod()]
        public void InterestPerformanceByAmountTest()
        {
            //Assert.Fail();
        }

        [TestMethod()]
        public void setStrategyTest()
        {
            // Assert.Fail();
        }

        [TestMethod()]
        public void calculateBalanceTest()
        {
            AbstractInterestPerformance performance = new InterestPerformanceByAmount(new CalculateInterestByAmountStrategy());

            //Para cuentas corrientes
            InterestTable tabla = new TableCertificadoDeDeposito();
            performance.setInterestTable(tabla);
            Decimal ret = performance.calculateBalance(5,5);
            //Assert.AreNotEqual(performance.calculateBalance(1000000, 31), 1001722.22);
           // Assert.AreNotEqual(performance.calculateBalance(2650000, 21), 2653864.58);

                        
        }
    }
}