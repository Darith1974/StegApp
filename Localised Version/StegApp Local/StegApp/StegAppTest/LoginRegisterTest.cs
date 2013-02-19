using WindowsFormsApplication4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApplication4.DataAccess.DataModel;
using System.Drawing;
using System.Text;
using WindowsFormsApplication4.DataAccess;
using WindowsFormsApplication4.BusinessObjects;
using System.Configuration;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace StegAppTest
{
    
    
    /// <summary>
    ///This is a test class for LoginRegisterTest and is intended
    ///to contain all LoginRegisterTest Unit Tests
    ///</summary>
    [TestClass()]
    public class LoginRegisterTest
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
        ///A test for Cancel_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("WindowsFormsApplication4.exe")]
        public void Cancel_ClickTest()
        {
            LoginRegister_Accessor target = new LoginRegister_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.Cancel_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Register_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("WindowsFormsApplication4.exe")]
        public void Register_ClickTest()
        {
            LoginRegister_Accessor target = new LoginRegister_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.Register_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Login_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("WindowsFormsApplication4.exe")]
        public void Login_ClickTest()
        {
            LoginRegister_Accessor target = new LoginRegister_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.Login_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

       

        /// <summary>
        ///A test for loginFn
        ///</summary>
        [TestMethod()]
        public void loginFnTest1()
        {
            /*This test works on the function Loginfn which is the function that handles the initial login event. 
             * 100% code coverage achieved.
             */
            LoginRegister target = new LoginRegister(); // TODO: Initialize to an appropriate value
            string login = "david"; // TODO: Initialize to an appropriate value
            string password = "david1"; // TODO: Initialize to an appropriate value
            target.loginFn(login, password);
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
