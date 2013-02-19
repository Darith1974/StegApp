using WindowsFormsApplication4.DataAccess.DataModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.Objects.DataClasses;

namespace StegAppTest
{
    
    
    /// <summary>
    ///This is a test class for PictureTypeTest and is intended
    ///to contain all PictureTypeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PictureTypeTest
    {


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
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for PictureType Constructor
        ///</summary>
        [TestMethod()]
        public void PictureTypeConstructorTest()
        {
            PictureType target = new PictureType();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CreatePictureType
        ///</summary>
        [TestMethod()]
        public void CreatePictureTypeTest()
        {
            int pictureTypeId = 0; // TODO: Initialize to an appropriate value
            string typeDescription = string.Empty; // TODO: Initialize to an appropriate value
            PictureType expected = null; // TODO: Initialize to an appropriate value
            PictureType actual;
            actual = PictureType.CreatePictureType(pictureTypeId, typeDescription);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PictureTypeId
        ///</summary>
        [TestMethod()]
        public void PictureTypeIdTest()
        {
            PictureType target = new PictureType(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.PictureTypeId = expected;
            actual = target.PictureTypeId;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Pictures
        ///</summary>
        [TestMethod()]
        public void PicturesTest()
        {
            PictureType target = new PictureType(); // TODO: Initialize to an appropriate value
            EntityCollection<Picture> expected = null; // TODO: Initialize to an appropriate value
            EntityCollection<Picture> actual;
            target.Pictures = expected;
            actual = target.Pictures;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TypeDescription
        ///</summary>
        [TestMethod()]
        public void TypeDescriptionTest()
        {
            PictureType target = new PictureType(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.TypeDescription = expected;
            actual = target.TypeDescription;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
