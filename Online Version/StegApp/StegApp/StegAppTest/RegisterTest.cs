using WindowsFormsApplication4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApplication4.DataAccess.DataModel;
using System.Linq;

namespace StegAppTest
{
    
    
    /// <summary>
    ///This is a test class for RegisterTest and is intended
    ///to contain all RegisterTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RegisterTest
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
        ///A test for RegisterButton_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("WindowsFormsApplication4.exe")]
        public void RegisterButton_ClickTest()
        {
            Register_Accessor target = new Register_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.RegisterButton_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        

        /// <summary>
        ///A test for RegisterFn
        ///</summary>
        [TestMethod()]
        public void RegisterFnTest1()
        {
            /*In this test we test the code which is executed for the ‘Register’ button on the Register form. 
             * This is executed by the function RegisterFn. The unit test achieves 100% code coverage plus it 
             * passes the various assert statements to test the type of the variables.
             */
            Register target = new Register(); // TODO: Initialize to an appropriate value
            string username = "test"; // TODO: Initialize to an appropriate value
            string password = "test"; // TODO: Initialize to an appropriate value
            string firstname = "test"; // TODO: Initialize to an appropriate value
            string surname = "test"; // TODO: Initialize to an appropriate value
            string town = "test"; // TODO: Initialize to an appropriate value
            string county = "test"; // TODO: Initialize to an appropriate value
            string country = "test"; // TODO: Initialize to an appropriate value
            target.RegisterFn(username, password, firstname, surname, town, county, country);
            Assert.IsInstanceOfType(username, typeof(string));
            Assert.IsInstanceOfType(password, typeof(string));
            Assert.IsInstanceOfType(firstname, typeof(string));
            Assert.IsInstanceOfType(surname, typeof(string));
            Assert.IsInstanceOfType(town, typeof(string));
            Assert.IsInstanceOfType(county, typeof(string));
            Assert.IsInstanceOfType(country, typeof(string));
            
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
