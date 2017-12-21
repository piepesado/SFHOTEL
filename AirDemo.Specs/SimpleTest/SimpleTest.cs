using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirDemo.Specs.SimpleTest
{
    [TestFixture]
    public class SimpleTest
    {
        [Test]
        public void HelloWorldTest()
        {
            string a = "Hello";
            string b = ", World!";
            string expected = "Hello, World!";

            string result = a + b;

            Assert.AreEqual(expected, result);
        }
    }
}
