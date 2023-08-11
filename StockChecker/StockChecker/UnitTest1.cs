using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace StockChecker
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Product_Dictionary()
        {
            Dictionary<string, Int32> productCode = new Dictionary<string, Int32>
            {
                { "A", 10 },
                { "B", 20 },
                { "C", 30 }
            };

            int totalNumberOfProducts = productCode.CalculateTotal();

            Assert.AreEqual(60, totalNumberOfProducts);

        }

    }

    public class StockChcker
    {
        public int totalNumberOfProducts { get; set; }

        internal int CalculateTotal()
        {
            return totalNumberOfProducts;
        }

    }

}
