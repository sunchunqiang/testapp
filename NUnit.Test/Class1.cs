using System;
using NUnit.Framework;
using myapp;
namespace NUnit.Test
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void TestMethod()
        {
            // TODO: Add your test code here
            Assert.IsTrue((Calculate.add(2,3) == 5));
        }
    }
}
