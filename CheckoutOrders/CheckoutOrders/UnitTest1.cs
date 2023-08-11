using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CheckoutOrders
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Checkout()
        {
            var CheckoutOrder = new CheckoutOrder();

            CheckoutOrder.Add(10);
            CheckoutOrder.Add(20);
            CheckoutOrder.Add(30);
            CheckoutOrder.Add(25);
            CheckoutOrder.Add(30);

            var Total = CheckoutOrder.GetTotal();

            Assert.AreEqual(115, Total);


        }
    }

    public class CheckoutOrder
    {
        public int Total { get; set; }

        internal void Add(int v)
        {
            Total = Total + v; 
        }

        internal int GetTotal()
        {
            return Total;
        }
    }
}
