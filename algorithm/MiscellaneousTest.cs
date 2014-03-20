using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace algorithm {
    [TestClass]
    public class MiscellaneousTest {
        [TestMethod]
        public void Fabonacci_1() {
            Assert.AreEqual(1, Miscellaneous.FabonacciIteration(1));
            Assert.AreEqual(1, Miscellaneous.FabonacciRecurse(1));
        }

        [TestMethod]
        public void Fabonacci_2() {
            Assert.AreEqual(1, Miscellaneous.FabonacciIteration(2));
            Assert.AreEqual(1, Miscellaneous.FabonacciRecurse(2));
        }

        [TestMethod]
        public void Fabonacci_3() {
            Assert.AreEqual(2, Miscellaneous.FabonacciIteration(3));
            Assert.AreEqual(2, Miscellaneous.FabonacciRecurse(3));
        }

        [TestMethod]
        public void Fabonacci_6() {
            Assert.AreEqual(8, Miscellaneous.FabonacciIteration(6));
            Assert.AreEqual(8, Miscellaneous.FabonacciRecurse(6));
        }

        [TestMethod]
        public void Factorial_1() {
            Assert.AreEqual(1, Miscellaneous.FactorialRecurse(1));
            Assert.AreEqual(1, Miscellaneous.FactorialIteration(1));
            Assert.AreEqual(1, Miscellaneous.FactorialStack(1));
        }

        [TestMethod]
        public void Factorial_2() {
            Assert.AreEqual(2, Miscellaneous.FactorialRecurse(2));
            Assert.AreEqual(2, Miscellaneous.FactorialIteration(2));
            Assert.AreEqual(2, Miscellaneous.FactorialStack(2));
        }

        [TestMethod]
        public void Factorial_3() {
            Assert.AreEqual(6, Miscellaneous.FactorialRecurse(3));
            Assert.AreEqual(6, Miscellaneous.FactorialIteration(3));
            Assert.AreEqual(6, Miscellaneous.FactorialStack(3));
        }

        [TestMethod]
        public void Factorial_6() {
            Assert.AreEqual(720, Miscellaneous.FactorialRecurse(6));
            Assert.AreEqual(720, Miscellaneous.FactorialIteration(6));
            Assert.AreEqual(720, Miscellaneous.FactorialStack(6));
        }
    }
}
