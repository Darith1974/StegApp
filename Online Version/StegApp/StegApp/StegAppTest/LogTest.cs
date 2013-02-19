using WindowsFormsApplication4.BusinessObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StegAppTest
{
    
    
    /// <summary>
    ///This is a test class for LogTest and is intended
    ///to contain all LogTest Unit Tests
    ///</summary>
    [TestClass()]
    public class LogTest
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
        ///A test for Log Constructor
        ///</summary>
        [TestMethod()]
        public void LogConstructorTest()
        {
            Log target = new Log();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for EndUserID
        ///</summary>
        [TestMethod()]
        public void EndUserIDTest()
        {
            Log target = new Log(); // TODO: Initialize to an appropriate value
            Nullable<int> expected = new Nullable<int>(); // TODO: Initialize to an appropriate value
            Nullable<int> actual;
            target.EndUserID = expected;
            actual = target.EndUserID;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LogId
        ///</summary>
        [TestMethod()]
        public void LogIdTest()
        {
            Log target = new Log(); // TODO: Initialize to an appropriate value
            Nullable<int> expected = new Nullable<int>(); // TODO: Initialize to an appropriate value
            Nullable<int> actual;
            target.LogId = expected;
            actual = target.LogId;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MessageKey
        ///</summary>
        [TestMethod()]
        public void MessageKeyTest()
        {
            Log target = new Log(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.MessageKey = expected;
            actual = target.MessageKey;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PictureId
        ///</summary>
        [TestMethod()]
        public void PictureIdTest()
        {
            Log target = new Log(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.PictureId = expected;
            actual = target.PictureId;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SentDateTime
        ///</summary>
        [TestMethod()]
        public void SentDateTimeTest()
        {
            Log target = new Log(); // TODO: Initialize to an appropriate value
            DateTime expected = new DateTime(); // TODO: Initialize to an appropriate value
            DateTime actual;
            target.SentDateTime = expected;
            actual = target.SentDateTime;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UserId
        ///</summary>
        [TestMethod()]
        public void UserIdTest()
        {
            /*This test is for one of the Business objects classes: in this case log.cs. Within this class I am testing:
             * public int? UserId { get; set; } which is a constructor.  I use this class to hold a log object from the 
             * database and also to store information which will be stored in the database as a log object/row in the 
             * log table. 100% code coverage was achieved.

             */
            Log target = new Log(); // TODO: Initialize to an appropriate value
            Nullable<int> expected = new Nullable<int>(); // TODO: Initialize to an appropriate value
            Nullable<int> actual;
            expected = 10;
            target.UserId = expected;
            actual = target.UserId;
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
