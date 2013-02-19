using WindowsFormsApplication4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.Text;

namespace StegAppTest
{
    
    
    /// <summary>
    ///This is a test class for EmbedClassTest and is intended
    ///to contain all EmbedClassTest Unit Tests
    ///</summary>
    [TestClass()]
    public class EmbedClassTest
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
        ///A test for Embed
        ///</summary>
        [TestMethod()]
        public void EmbedTest()
        {
            /*EmbedTest unit tests the functionality of the method embed. This method embeds the 
             * message inside an image. For this test I gave predetermined values to EmbedKey, EmbedMessage and image3- 
             * the bitmap into which the message is supposed to be embedded. I then run this function and proceed to run 
             * various assert statements to test whether certain variables are within certain ranges and are of a certain 
             * type. The code coverage results achieved are 86.49%.
             */
            EmbedClass target = new EmbedClass(); // TODO: Initialize to an appropriate value
            string Embedkey = "123456"; // TODO: Initialize to an appropriate value
            string EmbedMessage = "test2"; // TODO: Initialize to an appropriate value
            Bitmap image3 = null; // TODO: Initialize to an appropriate value
            image3 = new Bitmap(@"C:\Users\Admin\Documents\dt265\Project\Sky\sky-and-cloud.bmp", true);
            string a = "123456", b = "test2";
            target.Embed(Embedkey, EmbedMessage, image3);
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
            if (Embedkey.Length > 6 || Embedkey.Length < 0)
            {
                Assert.Fail("Key is out of range");
            }
            Assert.IsInstanceOfType(target.tmp2, typeof(string[]));
            Assert.IsInstanceOfType(target.b1, typeof(byte[]));
            if (target.b1.Length != target.temp4.Length)
            {
                Assert.Fail("B1 array does not have the correct lenght");
            }
            //Assert.IsInstanceOfType(target.image3, typeof(Bitmap));
            Assert.IsInstanceOfType(target.sb, typeof(StringBuilder));
            if (target.sb.Length != target.tmp3.Length)
            {
                Assert.Fail("Issue with Stringbuilder sb. Lenght not equal to 'tmp3'!");
            }
            if (target.z != target.StringLenght)
            {
                Assert.Fail("z != StringLenght");
            }
            if (target.c != EmbedMessage.Length)
            {
                Assert.Fail("c is not the lenght of the Message!");
            }
            Assert.AreEqual(target.Mask0, 254);
            Assert.AreEqual(target.Mask1, 1);
            Assert.IsInstanceOfType(target.NewBlue, typeof(byte));
            Assert.IsInstanceOfType(target.NewRed, typeof(byte));
            Assert.IsInstanceOfType(target.NewGreen, typeof(byte));
            Assert.IsInstanceOfType(target.pixelColor, typeof(Color));
            
        }

       
    }
}
