using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Model.InterestCalculationStrategy;
using Model.InterestsUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



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
            AbstractInterestPerformance performance = new InterestPerformanceByAmount(new CurrentAccountInterest(), new CalculateInterestByAmountStrategy());
            Assert.AreNotEqual(performance.calculateBalance(1000000, 31), 1001722.22);
            
            Assert.AreNotEqual(performance.calculateBalance(2650000, 21), 2653864.58);

                        
        }
    }
}