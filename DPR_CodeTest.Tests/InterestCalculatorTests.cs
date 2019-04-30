using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DPR_CodeTest.Calculators;

namespace DPR_CodeTest.Tests
{
    [TestClass]
    public class InterestCalculatorTests
    {
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void CalculatorShouldThrowExceptionIfBalanceIsNegative()
        {
            var InterestCalculator = new InterestCalculator();
            var interestPaid = InterestCalculator.Calculate(-1);
        }

        [DataTestMethod]
        [DataRow("0.00", "0.00", DisplayName = "ZeroBalance")]
        [DataRow("0.01", "0.00", DisplayName = "1p")]
        [DataRow("1.00", "0.01", DisplayName = "£1")]
        [DataRow("999.99", "10.00", DisplayName = "£999.99")]
        [DataRow("999.00", "9.99", DisplayName = "£999.00")]
        public void CalculateOnePercentInterest(string bankBalance, string interestToBePaid)
        {
            // Arrange.
            var bankBalanceAsDecimal = decimal.Parse(bankBalance);
            var interestToBePaidAsDecimal = decimal.Parse(interestToBePaid);
            var InterestCalculator = new InterestCalculator();

            // Act.
            var interestPaid = InterestCalculator.Calculate(bankBalanceAsDecimal);

            // Assert.
            Assert.AreEqual(interestToBePaidAsDecimal, interestPaid);
        }

        [DataTestMethod]
        [DataRow("1000.00", "15.00", DisplayName = "£1000")]
        [DataRow("1001.00", "15.02", DisplayName = "£1000")]
        [DataRow("4999.99", "75.00", DisplayName = "£4999.99")]
        public void CalculateOnePointFivePercentInterest(string bankBalance, string interestToBePaid)
        {
            // Arrange.
            var bankBalanceAsDecimal = decimal.Parse(bankBalance);
            var interestToBePaidAsDecimal = decimal.Parse(interestToBePaid);
            var InterestCalculator = new InterestCalculator();

            // Act.
            var interestPaid = InterestCalculator.Calculate(bankBalanceAsDecimal);

            // Assert.
            Assert.AreEqual(interestToBePaidAsDecimal, interestPaid);
        }

        [DataTestMethod]
        [DataRow("5000.00", "100.00", DisplayName = "£5000")]
        [DataRow("9999.99", "200.00", DisplayName = "£9999.99")]
        public void CalculateTwoPercentInterest(string bankBalance, string interestToBePaid)
        {
            // Arrange.
            var bankBalanceAsDecimal = decimal.Parse(bankBalance);
            var interestToBePaidAsDecimal = decimal.Parse(interestToBePaid);
            var InterestCalculator = new InterestCalculator();

            // Act.
            var interestPaid = InterestCalculator.Calculate(bankBalanceAsDecimal);

            // Assert.
            Assert.AreEqual(interestToBePaidAsDecimal, interestPaid);
        }

        [DataTestMethod]
        [DataRow("10000.00", "250.00", DisplayName = "£10000")]
        [DataRow("49999.99", "1250.00", DisplayName = "£49999.99")]
        public void CalculateTwoPointFivePercentInterest(string bankBalance, string interestToBePaid)
        {
            // Arrange.
            var bankBalanceAsDecimal = decimal.Parse(bankBalance);
            var interestToBePaidAsDecimal = decimal.Parse(interestToBePaid);
            var InterestCalculator = new InterestCalculator();

            // Act.
            var interestPaid = InterestCalculator.Calculate(bankBalanceAsDecimal);

            // Assert.
            Assert.AreEqual(interestToBePaidAsDecimal, interestPaid);
        }

        [DataTestMethod]
        [DataRow("50000.00", "1500.00", DisplayName = "£50000")]
        //[DataRow("4999.99", "74.99")]
        public void CalculateThreePercentInterest(string bankBalance, string interestToBePaid)
        {
            // Arrange.
            var bankBalanceAsDecimal = decimal.Parse(bankBalance);
            var interestToBePaidAsDecimal = decimal.Parse(interestToBePaid);
            var InterestCalculator = new InterestCalculator();

            // Act.
            var interestPaid = InterestCalculator.Calculate(bankBalanceAsDecimal);

            // Assert.
            Assert.AreEqual(interestToBePaidAsDecimal, interestPaid);
        }
    }
}
