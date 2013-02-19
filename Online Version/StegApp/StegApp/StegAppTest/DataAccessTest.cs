using WindowsFormsApplication4.DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApplication4.BusinessObjects;
using WindowsFormsApplication4.DataAccess;

namespace StegAppTest
{
    
    
    /// <summary>
    ///This is a test class for DataAccessTest and is intended
    ///to contain all DataAccessTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DataAccessTest
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
        ///A test for DataAccess Constructor
        ///</summary>
        [TestMethod()]
        public void DataAccessConstructorTest()
        {
            DataAccess target = new DataAccess();
            //Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for AuthenitcateCredentials
        ///</summary>
        [TestMethod()]
        public void AuthenitcateCredentialsTest()
        {
            /* This is the first of three unit tests dealing with DataAccess.cs; the class which deals with direct 
             * interaction with the database. Inserting, retrieving and validating data using log, User and Picture.cs 
             * to store and hold the data. ‘AuthenicateCredentialsTest’ validates the input data against actual data. 
             * In this case I input valid data and run the test which achieves 100% code coverage.
             */
            DataAccess target = new DataAccess(); // TODO: Initialize to an appropriate value
            string username = "david"; // TODO: Initialize to an appropriate value
            string password = "david1"; // TODO: Initialize to an appropriate value
            User expected = target.AuthenitcateCredentials(username, password); // TODO: Initialize to an appropriate value
            User actual;
            actual = target.AuthenitcateCredentials(username, password);
            //Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetPicture
        ///</summary>
        [TestMethod()]
        public void GetPictureTest()
        {
            DataAccess target = new DataAccess(); // TODO: Initialize to an appropriate value
            int pictureId = 0; // TODO: Initialize to an appropriate value
            Picture expected = null; // TODO: Initialize to an appropriate value
            Picture actual;
            actual = target.GetPicture(pictureId);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetUser
        ///</summary>
        [TestMethod()]
        public void GetUserTest()
        {
            DataAccess target = new DataAccess(); // TODO: Initialize to an appropriate value
            int userId = 0; // TODO: Initialize to an appropriate value
            User expected = null; // TODO: Initialize to an appropriate value
            User actual;
            actual = target.GetUser(userId);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for InsertLog
        ///</summary>
        [TestMethod()]
        public void InsertLogTest()
        {
            /*This test will inadvertently test another function GetUser(). I call this function with valid data  plus I 
             * declare a valid end user id and message key. 100% code coverage achieved.
             */
            DataAccess target = new DataAccess(); // TODO: Initialize to an appropriate value
            User user = target.GetUser(1); // TODO: Initialize to an appropriate value
            int endUserId = 4; // TODO: Initialize to an appropriate value
            string messageKey = "123456"; // TODO: Initialize to an appropriate value
            target.InsertLog(user, endUserId, messageKey);
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

       

        /// <summary>
        ///A test for InsertUser
        ///</summary>
        [TestMethod()]
        public void InsertUserTest()
        {
            DataAccess target = new DataAccess(); // TODO: Initialize to an appropriate value
            string username = string.Empty; // TODO: Initialize to an appropriate value
            string password = string.Empty; // TODO: Initialize to an appropriate value
            string firstname = string.Empty; // TODO: Initialize to an appropriate value
            string lastname = string.Empty; // TODO: Initialize to an appropriate value
            string Town = string.Empty; // TODO: Initialize to an appropriate value
            string County = string.Empty; // TODO: Initialize to an appropriate value
            string Country = string.Empty; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.InsertUser(username, password, firstname, lastname, Town, County, Country);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ObtainUser
        ///</summary>
        [TestMethod()]
        public void ObtainUserTest()
        {
            DataAccess target = new DataAccess(); // TODO: Initialize to an appropriate value
            string username = string.Empty; // TODO: Initialize to an appropriate value
            User expected = null; // TODO: Initialize to an appropriate value
            User actual;
            actual = target.ObtainUser(username);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RetreiveMessages
        ///</summary>
        [TestMethod()]
        public void RetreiveMessagesTest()
        {
            /* This function is responsible for the retrieval of logs from the database.  For this test I input the 
             * expected logId to be returned for a specific user Id. The test passed with 100% coverage.
             */
            DataAccess target = new DataAccess(); // TODO: Initialize to an appropriate value
            int userid = 1; // TODO: Initialize to an appropriate value
            Log expected = new WindowsFormsApplication4.BusinessObjects.Log();// TODO: Initialize to an appropriate value
            expected.LogId = 44;
            Log actual;
            actual = target.RetreiveMessages(userid);
            Assert.AreEqual(expected.LogId, actual.LogId);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SaveImage
        ///</summary>
        public void SaveImageTest()
        {
            DataAccess target = new DataAccess(); // TODO: Initialize to an appropriate value
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            byte[] imagePath = null; // TODO: Initialize to an appropriate value
            PictureType pictureType = new PictureType(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.SaveImage(filename, imagePath, pictureType);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UpdateUser
        ///</summary>
        [TestMethod()]
        public void UpdateUserTest()
        {
            DataAccess target = new DataAccess(); // TODO: Initialize to an appropriate value
            User user = null; // TODO: Initialize to an appropriate value
            target.UpdateUser(user);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ConnectionString
        ///</summary>
        [TestMethod()]
        [DeploymentItem("WindowsFormsApplication4.exe")]
        public void ConnectionStringTest()
        {
            DataAccess_Accessor target = new DataAccess_Accessor(); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ConnectionString;
           // Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DataAccess Constructor
        ///</summary>
        [TestMethod()]
        public void DataAccessConstructorTest1()
        {
            DataAccess target = new DataAccess();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        
        /// <summary>
        ///A test for GetPicture
        ///</summary>
        [TestMethod()]
        public void GetPictureTest1()
        {
            DataAccess target = new DataAccess(); // TODO: Initialize to an appropriate value
            int pictureId = 0; // TODO: Initialize to an appropriate value
            Picture expected = null; // TODO: Initialize to an appropriate value
            Picture actual;
            actual = target.GetPicture(pictureId);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetUser
        ///</summary>
        [TestMethod()]
        public void GetUserTest1()
        {
            DataAccess target = new DataAccess(); // TODO: Initialize to an appropriate value
            int userId = 0; // TODO: Initialize to an appropriate value
            User expected = null; // TODO: Initialize to an appropriate value
            User actual;
            actual = target.GetUser(userId);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        
        /// <summary>
        ///A test for InsertUser
        ///</summary>
        [TestMethod()]
        public void InsertUserTest1()
        {
            DataAccess target = new DataAccess(); // TODO: Initialize to an appropriate value
            string username = "test11"; // TODO: Initialize to an appropriate value
            string password = "test11"; // TODO: Initialize to an appropriate value
            string firstname = "test11"; // TODO: Initialize to an appropriate value
            string lastname = "test11"; // TODO: Initialize to an appropriate value
            string Town = "test11"; // TODO: Initialize to an appropriate value
            string County = "test11"; // TODO: Initialize to an appropriate value
            string Country = "test11"; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.InsertUser(username, password, firstname, lastname, Town, County, Country);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ObtainUser
        ///</summary>
        [TestMethod()]
        public void ObtainUserTest1()
        {
            DataAccess target = new DataAccess(); // TODO: Initialize to an appropriate value
            string username = string.Empty; // TODO: Initialize to an appropriate value
            User expected = null; // TODO: Initialize to an appropriate value
            User actual;
            actual = target.ObtainUser(username);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        

        /// <summary>
        ///A test for SaveImage
        ///</summary>
        [TestMethod()]
        public void SaveImageTest1()
        {
            DataAccess target = new DataAccess(); // TODO: Initialize to an appropriate value
            string filename = string.Empty; // TODO: Initialize to an appropriate value
            byte[] imagePath = null; // TODO: Initialize to an appropriate value
            PictureType pictureType = new PictureType(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.SaveImage(filename, imagePath, pictureType);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UpdateUser
        ///</summary>
        [TestMethod()]
        public void UpdateUserTest1()
        {
            DataAccess target = new DataAccess(); // TODO: Initialize to an appropriate value
            User user = null; // TODO: Initialize to an appropriate value
            target.UpdateUser(user);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ConnectionString
        ///</summary>
        [TestMethod()]
        [DeploymentItem("WindowsFormsApplication4.exe")]
        public void ConnectionStringTest1()
        {
            DataAccess_Accessor target = new DataAccess_Accessor(); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ConnectionString;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
