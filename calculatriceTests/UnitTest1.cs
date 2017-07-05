using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using calculatrice.Controllers;
using calculatrice.Models;
using System.Web.Mvc;


namespace calculatriceTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckSum()
        {
            int a = 6;
            int b = 9;
            int expectedResult = 15;

            HomeController c = new HomeController();
            JsonResult res = c.PerformOperation(new ComputationModel { FirstValue = a, SecondtValue = b, OperatorType = 1 });

            Assert.AreEqual(Convert.ToDouble(res.Data), Convert.ToDouble(expectedResult));
        }

        [TestMethod]
        public void CheckMinus()
        {
            int a = 6;
            int b = 9;
            int expectedResult = -3;

            HomeController c = new HomeController();
            JsonResult res = c.PerformOperation(new ComputationModel { FirstValue = a, SecondtValue = b, OperatorType = 2 });

            Assert.AreEqual(Convert.ToDouble(res.Data), Convert.ToDouble(expectedResult));
        }

        [TestMethod]
        public void CheckMultiply()
        {
            int a = 6;
            int b = 9;
            int expectedResult = 54;

            HomeController c = new HomeController();
            JsonResult res = c.PerformOperation(new ComputationModel { FirstValue = a, SecondtValue = b, OperatorType = 3 });

            Assert.AreEqual(Convert.ToDouble(res.Data), Convert.ToDouble(expectedResult));
        }


        [TestMethod]
        public void CheckDivide()
        {
            int a = 14;
            int b = 7;
            int expectedResult = 2;

            HomeController c = new HomeController();
            JsonResult res = c.PerformOperation(new ComputationModel { FirstValue = a, SecondtValue = b, OperatorType = 4 });

            Assert.AreEqual(Convert.ToDouble(res.Data), Convert.ToDouble(expectedResult));
        }
    }
}
