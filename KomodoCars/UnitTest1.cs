using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KomodoCars
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SUV suv = new SUV("Dodge", "Journey", "#000000");

            Exception exception = null;

            try
            {
                suv.TurnLeft();
            }
            catch (Exception e)
            {
                exception = e;
                Console.WriteLine(e.Message);
            }

            Assert.IsNotNull(exception);
            Assert.IsInstanceOfType(exception, typeof(NotImplementedException));
        }
    }
}
