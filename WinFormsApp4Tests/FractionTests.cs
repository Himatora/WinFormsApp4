using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsApp4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4.Tests
{
    [TestClass()]
    public class FractionTests
    {
    
        [TestMethod()]
        public void VerboseTest()
        {
            var fraction= new Fraction(10, 100);
            Assert.AreEqual("10/100", fraction.Verbose());
        }
        [TestMethod()]
        public void AddNumberTest()
        {
            var fraction1 = new Fraction(10,100);
            var fraction2 = new Fraction(10,100); 
            Assert.AreEqual("1/5", (fraction1 + fraction2).Verbose());
            fraction1 = new Fraction(90, 100);
            fraction2 = new Fraction(90, 100);
            Assert.AreEqual("1 4/5", (fraction1 + fraction2).Verbose());
            fraction1 = new Fraction(90, 100);
            fraction2 = new Fraction(10, 100);
            Assert.AreEqual("1", (fraction1 + fraction2).Verbose());
        }
        [TestMethod()]
        public void SubNumberTest()
        {
            var fraction1 = new Fraction(20, 100);
            var fraction2 = new Fraction(10, 100);
            Assert.AreEqual("1/10", (fraction1 - fraction2).Verbose());
            fraction1 = new Fraction(80, 100);
            fraction2 = new Fraction(90, 100);
            Assert.AreEqual("-1/10", (fraction1 - fraction2).Verbose());
            fraction1 = new Fraction(-90, 100);
            fraction2 = new Fraction(10, 100);
            Assert.AreEqual("-1", (fraction1 - fraction2).Verbose());
            fraction1 = new Fraction(-90, 100);
            fraction2 = new Fraction(20, 100);
            Assert.AreEqual("-1 1/10", (fraction1 - fraction2).Verbose());
            fraction1 = new Fraction(-90, 100);
            fraction2 = new Fraction(-20, 100);
            Assert.AreEqual("-7/10", (fraction1 - fraction2).Verbose());
        }
        [TestMethod()]
        public void MulByNumberTest()
        {
            var fraction1 = new Fraction(20, 100);
            var fraction2 = new Fraction(10, 100);
            Assert.AreEqual("1/50", (fraction1 * fraction2).Verbose());
            fraction1 = new Fraction(-20, 100);
            fraction2 = new Fraction(10, 100);
            Assert.AreEqual("-1/50", (fraction1 * fraction2).Verbose());
            fraction1 = new Fraction(-20, 100);
            fraction2 = new Fraction(-10, 100);
            Assert.AreEqual("1/50", (fraction1 * fraction2).Verbose());
        }
        [TestMethod()]
        public void DivByNumberTest()
        {
            var fraction1 = new Fraction(20, 100);
            var fraction2 = new Fraction(10, 100);
            Assert.AreEqual("2", (fraction1 / fraction2).Verbose());
            fraction1 = new Fraction(-20, 100);
            fraction2 = new Fraction(10, 100);
            Assert.AreEqual("-2", (fraction1 / fraction2).Verbose());
            fraction1 = new Fraction(-20, 83);
            fraction2 = new Fraction(-10, 100);
            Assert.AreEqual("2 34/83", (fraction1 / fraction2).Verbose());
        }
    }
}