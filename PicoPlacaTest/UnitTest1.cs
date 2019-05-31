using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PicoPlaca;

namespace PicoPlacaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("31/05/2019 18:30", "ABC-1239")]
        public void TestMethod1(string date, string plateNumber)
        {
            Evaluate frmEvaluate = new Evaluate();
            var result = frmEvaluate.ValidateTest(plateNumber, Convert.ToDateTime(date));
            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow("31/05/2019 22:30", "ABC-1239")]
        public void TestMethod2(string date, string plateNumber)
        {
            Evaluate frmEvaluate = new Evaluate();
            var result = frmEvaluate.ValidateTest(plateNumber, Convert.ToDateTime(date));
            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow("01/06/2019 18:30", "ABC-1239")]
        public void TestMethod3(string date, string plateNumber)
        {
            Evaluate frmEvaluate = new Evaluate();
            var result = frmEvaluate.ValidateTest(plateNumber, Convert.ToDateTime(date));
            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow("03/06/2019 18:30", "ABC-1239")]
        public void TestMethod4(string date, string plateNumber)
        {
            Evaluate frmEvaluate = new Evaluate();
            var result = frmEvaluate.ValidateTest(plateNumber, Convert.ToDateTime(date));
            Assert.IsTrue(result);
        }
    }
}
