using System;
using System.Collections.Generic;
using System.Text;
using myapp;
using NUnit.Framework;
namespace basetestprj
{
    [TestFixture]
    public class TestClass1
    {
        [Test]
        public void TestMethod()
        {
            // TODO: Add your test code here
            Assert.IsTrue((Calculate.minus(4,2) == 2));
        }
    }
}
