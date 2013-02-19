using WindowsFormsApplication4.DataAccess.DataModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.EntityClient;
using System.Data.Objects;

namespace StegAppTest
{
    
    
    /// <summary>
    ///This is a test class for DatabaseEntitiesTest and is intended
    ///to contain all DatabaseEntitiesTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DatabaseEntitiesTest
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
        ///A test for DatabaseEntities Constructor
        ///</summary>
        [TestMethod()]
        public void DatabaseEntitiesConstructorTest()
        {
            EntityConnection connection = null; // TODO: Initialize to an appropriate value
            DatabaseEntities target = new DatabaseEntities(connection);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for DatabaseEntities Constructor
        ///</summary>
        [TestMethod()]
        public void DatabaseEntitiesConstructorTest1()
        {
            string connectionString = string.Empty; // TODO: Initialize to an appropriate value
            DatabaseEntities target = new DatabaseEntities(connectionString);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for DatabaseEntities Constructor
        ///</summary>
        [TestMethod()]
        public void DatabaseEntitiesConstructorTest2()
        {
            DatabaseEntities target = new DatabaseEntities();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for AddToLogs
        ///</summary>
        [TestMethod()]
        public void AddToLogsTest()
        {
            DatabaseEntities target = new DatabaseEntities(); // TODO: Initialize to an appropriate value
            Log log = null; // TODO: Initialize to an appropriate value
            target.AddToLogs(log);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AddToPictureTypes
        ///</summary>
        [TestMethod()]
        public void AddToPictureTypesTest()
        {
            DatabaseEntities target = new DatabaseEntities(); // TODO: Initialize to an appropriate value
            PictureType pictureType = null; // TODO: Initialize to an appropriate value
            target.AddToPictureTypes(pictureType);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AddToPictures
        ///</summary>
        [TestMethod()]
        public void AddToPicturesTest()
        {
            DatabaseEntities target = new DatabaseEntities(); // TODO: Initialize to an appropriate value
            Picture picture = null; // TODO: Initialize to an appropriate value
            target.AddToPictures(picture);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AddToUsers
        ///</summary>
        [TestMethod()]
        public void AddToUsersTest()
        {
            DatabaseEntities target = new DatabaseEntities(); // TODO: Initialize to an appropriate value
            User user = null; // TODO: Initialize to an appropriate value
            target.AddToUsers(user);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Logs
        ///</summary>
        [TestMethod()]
        public void LogsTest()
        {
            DatabaseEntities target = new DatabaseEntities(); // TODO: Initialize to an appropriate value
            ObjectSet<Log> actual;
            actual = target.Logs;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PictureTypes
        ///</summary>
        [TestMethod()]
        public void PictureTypesTest()
        {
            DatabaseEntities target = new DatabaseEntities(); // TODO: Initialize to an appropriate value
            ObjectSet<PictureType> actual;
            actual = target.PictureTypes;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Pictures
        ///</summary>
        [TestMethod()]
        public void PicturesTest()
        {
            DatabaseEntities target = new DatabaseEntities(); // TODO: Initialize to an appropriate value
            ObjectSet<Picture> actual;
            actual = target.Pictures;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Users
        ///</summary>
        [TestMethod()]
        public void UsersTest()
        {
            DatabaseEntities target = new DatabaseEntities(); // TODO: Initialize to an appropriate value
            ObjectSet<User> actual;
            actual = target.Users;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
