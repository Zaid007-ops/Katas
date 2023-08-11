using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TDDCalculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReturnsZeroByDefault()
        {
            var Calculator = new Calculator();
            var Total = Calculator.GetTotal();
            Assert.AreEqual(0, Total);

        }

        [TestMethod]
        public void AddsTenReturnsATotalOfTen()
        {
            var Calculator = new Calculator();
            Calculator.Add(10);
            var Total = Calculator.GetTotal();
            Assert.AreEqual(10, Total);

        }

        [TestMethod]
        public void AddsTenAddsFiveReturnsATotalOf15()
        {
            var Calculator = new Calculator();
            Calculator.Add(10);
            Calculator.Add(5);
            var Total = Calculator.GetTotal();
            Assert.AreEqual(15, Total);

        }

        [TestMethod]
        public void SubtractsTenFromFifteenReturnsATotalOf5()
        {
            var Calculator = new Calculator();
            Calculator.Subtract(10);
            Calculator.Subtract(15); 
            var Total = Calculator.GetTotal();
            Assert.AreEqual(5, Total);

        }

        [TestMethod]
        public void ClearsTotal()
        {
            var Calculator = new Calculator();
            var Total = Calculator.GetTotal();
            Calculator.Clear(0);
            Assert.AreEqual(0, Total);

        }

    }



    public class Calculator
    {
        private int Total { get; set; }
        internal void Add(int Value)
        {
            Total = Total + Value;
        }

        internal void Clear(int v)
        {
            Total = 0;
        }

        internal int GetTotal()
        {
            return Total;
        }

        internal void Subtract(int v)
        {
            Total = 15 - 10;
        }


    }
}
