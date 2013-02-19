using WindowsFormsApplication4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.Text;

namespace StegAppTest
{
    
    
    /// <summary>
    ///This is a test class for RetreiveMessageClassTest and is intended
    ///to contain all RetreiveMessageClassTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RetreiveMessageClassTest
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
        ///A test for Retreive
        ///</summary>
        [TestMethod()]
        public void RetreiveTest()
        {
            /* This function tests the Retrieve method of RetrieveMessageClass.cs. The function to be tested is responsible 
             * for retrieving a message from an image. Again I set the key and the image to be used. I then test the range
             * and type of a number of variables concerned. Code coverage is 94.29 %.
             */
            RetrieveMessageClass target = new RetrieveMessageClass(); // TODO: Initialize to an appropriate value
            string KeyEntered = "123456"; // TODO: Initialize to an appropriate value
            Bitmap image4 = null; // TODO: Initialize to an appropriate value
            image4 = new Bitmap(@"C:\Users\Admin\Documents\dt265\Project\Testphoto_123456.bmp", true);
            target.Retrieve(KeyEntered, image4);

            Assert.IsInstanceOfType(target.KeyMessage, typeof(StringBuilder));
            Assert.IsInstanceOfType(target.RetreivedMessage, typeof(StringBuilder));
            Assert.IsInstanceOfType(target.KeyRetreived, typeof(string));
            Assert.IsInstanceOfType(target.pixelColor, typeof(Color));
            Assert.IsInstanceOfType(target.binary1, typeof(string));
            Assert.IsInstanceOfType(target.binary2, typeof(string));
            Assert.IsInstanceOfType(target.binary3, typeof(string));
            if (target.KeyMessage.Length != 48)
            {
                Assert.Fail("KeyMessage should be of lenght 48");
            }
            /*
            if (target.z != (80 + (8 * target.count3)))
            {
                Assert.Fail("z should be (80 + (8 * target.count3) after program run");
            }
            */
            Assert.IsInstanceOfType(target.count2, typeof(int));
            if (target.MessageLenght.Length != 32)
            {
                Assert.Fail("MessageLenght should be 32 after program run");
            }

            Assert.AreEqual(target.count2, (target.MessageLenght.Length) / 8, "1");
            Assert.AreEqual(target.z, (80 + (8 * target.count3)), "2");
            Assert.AreEqual(Convert.ToInt16(target.FinalMessageLenght), target.count3, "3");
            Assert.AreEqual(target.RetreivedMessage.Length, target.c - 80, "4");
            Assert.AreEqual(target.count1, target.FinalRetreivedMessage.Length / 8, "5");
            /*
            string KeyEntered = string.Empty; // TODO: Initialize to an appropriate value
            Bitmap image4 = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Retreive(KeyEntered, image4);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");*/
        }
    }
}
