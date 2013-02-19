using WindowsFormsApplication4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.Text;
using WindowsFormsApplication4.DataAccess;
using WindowsFormsApplication4.BusinessObjects;
using WindowsFormsApplication4.DataAccess.DataModel;
using System.Configuration;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace StegAppTest
{
    
    
    /// <summary>
    ///This is a test class for StegAppTest and is intended
    ///to contain all StegAppTest Unit Tests
    ///</summary>
    [TestClass()]
    public class StegAppTest
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
        public void EmbedTest()
        {
            /*
            StegApp target = new StegApp(); // TODO: Initialize to an appropriate value
            string Embedkey = "123456"; // TODO: Initialize to an appropriate value
            string EmbedMessage = "test2"; // TODO: Initialize to an appropriate value
            Bitmap image3 = null; // TODO: Initialize to an appropriate value
            image3 = new Bitmap(@"C:\Users\Admin\Documents\dt265\Project\Sky\sky-and-cloud.bmp",true);
            string a="123456",b="test2";
            target.Embed(Embedkey, EmbedMessage, image3);
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
            if (Embedkey.Length > 6 || Embedkey.Length < 0)
            {
                Assert.Fail("Key is out of range");
            }
            Assert.IsInstanceOfType(target.tmp2, typeof(string[]));
            Assert.IsInstanceOfType(target.b1,typeof(byte[]));
            if(target.b1.Length != target.temp4.Length)
            {
                Assert.Fail("B1 array does not have the correct lenght");
            }
            Assert.IsInstanceOfType(target.image1,typeof(Bitmap));
            Assert.IsInstanceOfType(target.sb,typeof(StringBuilder));
            if(target.sb.Length != target.tmp3.Length)
            {
                Assert.Fail("Issue with Stringbuilder sb. Lenght not equal to 'tmp3'!");
            }
            if(target.z != target.StringLenght)
            {
                Assert.Fail("z != StringLenght");
            }
            if (target.c != EmbedMessage.Length)
            {
                Assert.Fail("c is not the lenght of the Message!");
            }
            Assert.AreEqual(target.Mask0,254);
            Assert.AreEqual(target.Mask1, 1);
            Assert.IsInstanceOfType(target.NewBlue,typeof(byte));
            Assert.IsInstanceOfType(target.NewRed, typeof(byte));
            Assert.IsInstanceOfType(target.NewGreen, typeof(byte));
            Assert.IsInstanceOfType(target.pixelColor, typeof(Color));
            */
            /*
            Embedkey = ""; // TODO: Initialize to an appropriate value
            EmbedMessage = "";
            target.Embed(Embedkey, EmbedMessage, image3);
            if (Embedkey.Length != 0)
            {
                Assert.Fail("Key is out of range");
            }
            if (target.b1.Length != target.temp4.Length)
            {
                Assert.Fail("B1 array does not have the correct lenght");
            }
            Assert.IsInstanceOfType(target.image1, typeof(Bitmap));
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
            */
        }

        /// <summary>
        ///A test for RetreiveImageFn
        ///</summary>
        public void RetreiveImageFnTest()
        {
            StegApp target = new StegApp(); // TODO: Initialize to an appropriate value
            string username = "paul"; // TODO: Initialize to an appropriate value
            string password = "blah"; // TODO: Initialize to an appropriate value
            string ConnectionString = "metadata=res://*/DataAccess.DataModel.Database.csdl|res://*/DataAccess.DataModel.Database.ssdl|res://*/DataAccess.DataModel.Database.msl;provider=System.Data.SqlClient;provider connection string=\"data source=stem.arvixe.com;initial catalog=DavidFlynnDatabase;user id=DavidFlynn;password=$D4v1dpr0j3ct2012;multipleactiveresultsets=True;App=EntityFramework\"";
            using (var dataContext = new DatabaseEntities(ConnectionString))
            {
                var user = dataContext.Users.FirstOrDefault(u => u.Username.Equals(username) && u.Password.Equals(password));
                Assert.IsNotNull(user);
                //Assert.IsInstanceOfType(user,typeof());
                var u1 = from p in dataContext.Logs
                         where p.EndUserID == user.UserId
                         orderby p.SentDatetime descending
                         select p;
                var u2 = u1.FirstOrDefault();
                Assert.IsNotNull(u1);
                if (u2 != null)
                {
                    WindowsFormsApplication4.BusinessObjects.Log p5 = new WindowsFormsApplication4.BusinessObjects.Log()
                    {
                        LogId = u2.LogId,
                        UserId = user.UserId,
                        EndUserID = u2.EndUserID,
                        PictureId = Convert.ToInt32(u2.PictureId),
                        MessageKey = u2.MessageKey,
                        SentDateTime = u2.SentDatetime
                    };
                    Assert.IsNotNull(p5);
                    Assert.IsInstanceOfType(p5, typeof(WindowsFormsApplication4.BusinessObjects.Log));
                    MessageBox.Show("LogId = " + p5.LogId + "\n" +
                   "UserId = " + p5.UserId + "\n" +
                   "Message Key = " + p5.MessageKey + "\n" + "PictureId = " + p5.PictureId +
                   " Date & time = " + p5.SentDateTime);
                    //DisplayLogs.Visible = true;
                    Assert.IsNotNull(p5.PictureId);
                    if (p5.PictureId == 0)
                    {
                        MessageBox.Show("No Picture in Database, only key was stored");
                    }

                    var picture = dataContext.Pictures.FirstOrDefault(p => p.PictureId == p5.PictureId);
                    Assert.IsNotNull(picture, "1");

                    Assert.IsInstanceOfType(picture, typeof(WindowsFormsApplication4.DataAccess.DataModel.Picture));
                    WindowsFormsApplication4.BusinessObjects.Picture pic = new WindowsFormsApplication4.BusinessObjects.Picture()
                                        {
                                            PictureId = picture.PictureId,
                                            PictureName = picture.PictureName,
                                            PictureTypeId = picture.PictureTypeID,
                                            PictureStatus = picture.PictureStatus,
                                            PictureData = picture.PictureData,
                                            PictureTypeDescription = picture.PictureType.TypeDescription
                                        };
                    Assert.IsNotNull(pic, "2");
                    Assert.IsInstanceOfType(pic, typeof(WindowsFormsApplication4.BusinessObjects.Picture));
                    using (MemoryStream stream = new MemoryStream(pic.PictureData))
                    {
                        Assert.AreNotEqual(stream, new MemoryStream(pic.PictureData));
                        //Convert.ToInt32(RetreiveLogs.RetreiveMessages(p.UserId).PictureId)
                        //stream =RetreiveLogs.GetPicture(53).PictureData;
                        Image img = Image.FromStream(stream);
                        Bitmap a = new Bitmap(img);
                        Assert.IsInstanceOfType(stream, typeof(MemoryStream));
                        Assert.IsNotNull(pic.PictureData, "3");
                        Assert.IsInstanceOfType(img, typeof(Image));
                        Assert.IsNotNull(img, "4");
                        Assert.IsNotNull(a, "5");
                        Assert.IsInstanceOfType(a, typeof(Bitmap));
                        //Bitmap bmp = new Bitmap(stream);
                        //image2 = a;
                        //pictureBox2.Image = image2;
                    }

                }

                /*
                if (user == null) return null;
                CurrentUser = GetUser(user.UserId);
                return CurrentUser;*/
            }

        }


        
       
       

       

        /// <summary>
        ///A test for SaveKeyOnly
        ///</summary>
        public void SaveKeyOnlyTest()
        {
            StegApp target = new StegApp();
            WindowsFormsApplication4.BusinessObjects.User p = new WindowsFormsApplication4.BusinessObjects.User();

            string username = "david"; // TODO: Initialize to an appropriate value
            string password = "david1"; // TODO: Initialize to an appropriate value
            string messageKey = "123456";
            int endUserId = 4;
            Assert.IsInstanceOfType(username, typeof(string));
            Assert.IsInstanceOfType(password, typeof(string));
            Assert.IsInstanceOfType(messageKey, typeof(string));
            string ConnectionString = "metadata=res://*/DataAccess.DataModel.Database.csdl|res://*/DataAccess.DataModel.Database.ssdl|res://*/DataAccess.DataModel.Database.msl;provider=System.Data.SqlClient;provider connection string=\"data source=stem.arvixe.com;initial catalog=DavidFlynnDatabase;user id=DavidFlynn;password=$D4v1dpr0j3ct2012;multipleactiveresultsets=True;App=EntityFramework\"";
            using (var dataContext = new DatabaseEntities(ConnectionString))
            {
                var user = dataContext.Users.FirstOrDefault(u => u.Username.Equals(username) && u.Password.Equals(password));
                var log = new WindowsFormsApplication4.DataAccess.DataModel.Log
                {

                    PictureId = null,
                    SentDatetime = DateTime.Now,
                    MessageKey = messageKey,
                    UserId = user.UserId,
                    EndUserID = endUserId
                };
                Assert.IsNotNull(log);
                Assert.IsInstanceOfType(log, typeof(WindowsFormsApplication4.DataAccess.DataModel.Log));
                Assert.IsNull(log.PictureId);
                Assert.IsInstanceOfType(log.SentDatetime, typeof(DateTime));
                Assert.IsNotNull(log.SentDatetime);
                Assert.IsInstanceOfType(log.MessageKey, typeof(string));
                Assert.IsNotNull(log.MessageKey);
                Assert.IsInstanceOfType(log.UserId, typeof(int));
                Assert.IsNotNull(log.UserId);
                Assert.IsInstanceOfType(log.EndUserID, typeof(int));
                Assert.IsNotNull(log.EndUserID);
                dataContext.Logs.AddObject(log);
                dataContext.SaveChanges();
            }// TODO: Initialize to an appropriate value
            //target.SaveKeyOnly();
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Selectfilefn
        ///</summary>
        [TestMethod()]
        public void SelectfilefnTest()
        {
            /*The Selectfilefn allows a user to select a file from their hard drive. This test achieved 100% coverage. 
             * I test that the selection is not null and the image is of type Bitmap.
             */
            StegApp target = new StegApp(); // TODO: Initialize to an appropriate value
            target.Selectfilefn();
            Assert.IsInstanceOfType(target.image2, typeof(Bitmap));

            //Assert.AreEqual(target.result2,target.openFileDialog1.ShowDialog());
            Assert.IsNotNull(target.result2);
            //Assert.AreEqual(target.result2, target.DialogResult.OK);
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Retreive
        ///</summary>

        public void RetreiveTest()
        {
            /*
            StegApp target = new StegApp(); // TODO: Initialize to an appropriate value
            string KeyEntered = "123456"; // TODO: Initialize to an appropriate value
            Bitmap image4 = null; // TODO: Initialize to an appropriate value
            image4 = new Bitmap(@"C:\Users\Admin\Documents\dt265\Project\Testphoto_123456.bmp", true);
            target.Retreive(KeyEntered, image4);
            
            Assert.IsInstanceOfType(target.KeyMessage,typeof(StringBuilder));
            Assert.IsInstanceOfType(target.RetreivedMessage,typeof(StringBuilder));
            Assert.IsInstanceOfType(target.KeyRetreived, typeof(string));
            Assert.IsInstanceOfType(target.pixelColor,typeof(Color));
            Assert.IsInstanceOfType(target.binary1, typeof(string));
            Assert.IsInstanceOfType(target.binary2, typeof(string));
            Assert.IsInstanceOfType(target.binary3, typeof(string));
            if(target.KeyMessage.Length !=48)
            {
                Assert.Fail("KeyMessage should be of lenght 48");
            }
            */
            /*
            if (target.z != (80 + (8 * target.count3)))
            {
                Assert.Fail("z should be (80 + (8 * target.count3) after program run");
            }
            */
            /*
            Assert.IsInstanceOfType(target.count2,typeof(int));
            if (target.MessageLenght.Length != 32)
            {
                Assert.Fail("MessageLenght should be 32 after program run");
            }

            Assert.AreEqual(target.count2, (target.MessageLenght.Length)/8,"1");
            Assert.AreEqual(target.z, (80 + (8 * target.count3)),"2");
            Assert.AreEqual(Convert.ToInt16(target.FinalMessageLenght), target.count3, "3");
            Assert.AreEqual(target.RetreivedMessage.Length, target.c-80, "4");
            Assert.AreEqual(target.count1, target.FinalRetreivedMessage.Length / 8, "5");

            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
            */
        }





        /// <summary>
        ///A test for SaveImageDisk
        ///</summary>
        [TestMethod()]
        public void SaveImageDiskTest()
        {
            StegApp target = new StegApp(); // TODO: Initialize to an appropriate value
            target.image5 = new Bitmap(@"C:\Users\Admin\Documents\7-1541.bmp", true);
            target.SaveImageDisk();
            Assert.IsNotNull(target.image5);
            //Assert.AreEqual(target.saveFileDialog1.ShowDialog(),target.DialogResult.OK);
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SaveKeyOnly
        ///</summary>
        [TestMethod()]
        public void SaveKeyOnlyTest1()
        {
            StegApp target = new StegApp(); // TODO: Initialize to an appropriate value
            //DataAccess.DataAccess EndUserform = new DataAccess.DataAccess();

            target.SaveKeyOnly("david", "david1", "1", "123456");
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for RetreiveKeyFn
        ///</summary>
        [TestMethod()]
        public void RetreiveKeyFnTest1()
        {
            /*This test tests the RetrieveKeyFn in StegApp.cs which is responsible for retrieving the last log of the 
             * validated user from the database. I set the username and password  and test the function which achieves 
             * 100% code coverage. I test also that the values entered are of a certain type.
             */
            StegApp target = new StegApp(); // TODO: Initialize to an appropriate value
            string username = "david"; // TODO: Initialize to an appropriate value
            string password = "david1"; // TODO: Initialize to an appropriate value
            target.RetreiveKeyFn(username, password);
            Assert.IsInstanceOfType(username, typeof(string));
            Assert.IsInstanceOfType(password, typeof(string));

            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for RetreiveImageFn
        ///</summary>
        [TestMethod()]
        public void RetreiveImageFnTest1()
        {
            StegApp target = new StegApp(); // TODO: Initialize to an appropriate value
            string uname = "david"; // TODO: Initialize to an appropriate value
            string pword = "david1"; // TODO: Initialize to an appropriate value
            target.RetreiveImageFn(uname, pword);
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }


       

        

        /// <summary>
        ///A test for SaveImageFn
        ///</summary>
        [TestMethod()]
        public void SaveImageFnTest2()
        {
            //This is the code which tests the event to save an image with an embedded message in the Database. 
            //100% code coverage achieved.
            StegApp target = new StegApp(); // TODO: Initialize to an appropriate value
            string uname = "david"; // TODO: Initialize to an appropriate value
            string pword = "david1"; // TODO: Initialize to an appropriate value
            string ImageName = "test12"; // TODO: Initialize to an appropriate value
            string EndUser = "1"; // TODO: Initialize to an appropriate value
            target.image1 = new Bitmap(@"C:\Users\Admin\Documents\7-1541.bmp", true);
            target.SaveImageFn(uname, pword, ImageName, EndUser);
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SaveImageAndKeyFn
        ///</summary>
        [TestMethod()]
        public void SaveImageAndKeyFnTest2()
        {
            /*As the title of the function suggests we are testing the event to save both the image and the key on the 
             * database. I replicated the username, password, key and image and achieved 100% coverage in the results.
             */
            StegApp target = new StegApp(); // TODO: Initialize to an appropriate value
            string uname = "david"; // TODO: Initialize to an appropriate value
            string pword = "david1"; // TODO: Initialize to an appropriate value
            string ImageName = "test12"; // TODO: Initialize to an appropriate value
            string EndUser = "1"; // TODO: Initialize to an appropriate value
            string key = "123456"; // TODO: Initialize to an appropriate value
            target.image1 = new Bitmap(@"C:\Users\Admin\Documents\7-1541.bmp", true);
            target.SaveImageAndKeyFn(uname, pword, ImageName, EndUser, key);
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
