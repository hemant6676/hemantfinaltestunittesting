using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace COMP2084FinalF2017.Tests.Controllers
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void IndexValidLoadCountries()
        {
            var actual = (List<Country>)controller.Index().Model;

            CollectionAssert.AreEqual(Countries, actual);
        }

        [TestMethod]
        public void DetailsValidId()
        {
            var actual = (Country)controller.Details(1).Model;

            Assert.AreEqual(stores.ToList()[0], actual);
        }

        [TestMethod]
        public void DetailsInvalidId()
        {
            ViewResult actual = controller.Details(6);

            Assert.AreEqual("Error", actual.ViewName);
        }

        [TestMethod]
        public void DetailsNoId()
        {
            ViewResult actual = controller.Details(null);

            Assert.AreEqual("Error", actual.ViewName);
        }
    }
}
