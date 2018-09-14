using System;
using System.Collections.Generic;
using System.Text;
using myapp;
using NUnit.Framework;
using Android.App;

namespace basetestprj
{
    [TestFixture]
    public class TestClass1
    {

        [Test]
        public void TestAndroid()
        {
            var app = Application.Context;
            Console.WriteLine($"{app.ToString()}");
            Assert.Pass("pass andoird app");
        }
        [Test]
        public void TestMethod()
        {
            // TODO: Add your test code here
            Assert.IsTrue((Calculate.minus(4, 2) == 2));
        }

        [Test]
        public void TestMulti()
        {
            // TODO: Add your test code here
            Assert.IsTrue((pcllib.Class1.mul(3, 4) == 12));
        }
    }
}
