using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;

namespace CheckoutTDD
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ScanA_Returns10()
        {
            var checkoutOrder = new CheckoutOrder();
            checkoutOrder.Scan("A");
            Assert.AreEqual(10, checkoutOrder.GetTotal());
        }

        [TestMethod]
        public void ScanB_Returns20()
        {
            var checkoutOrder = new CheckoutOrder();
            checkoutOrder.Scan("B");
            Assert.AreEqual(20, checkoutOrder.GetTotal());
        }

        [TestMethod]
        public void ScanC_Returns30()
        {
            var checkoutOrder = new CheckoutOrder();
            checkoutOrder.Scan("C");
            Assert.AreEqual(30, checkoutOrder.GetTotal());
        }

    }

    public class CheckoutOrder 
    {
        public int Total { get; set; }

        internal int GetTotal()
        {
            return Total;
        }

        internal void Scan(string v)
        {
            if(v == "A")
            {
                Total = Total + 10;
            }
            else if (v == "B")
            {
                Total = Total + 20;
            }
            else if (v == "C")
            {
                Total = Total + 30;
            }
        }
    }
}
