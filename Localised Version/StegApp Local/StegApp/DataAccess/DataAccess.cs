using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication4.DataAccess.DataModel;
using System.Configuration;
using BusinessObjects = WindowsFormsApplication4.BusinessObjects;
using System.IO;
using System.Drawing;


namespace WindowsFormsApplication4.DataAccess
{
    public class DataAccess
    {
        /*This class implements all the methods for accessing, updating and saving data to the database. I have created a 
         * private property ConnectionString which houses the connection string that any object which wants to connect to the 
         * database must use. The objects that do connect to the database are instances of the ‘DatabaseEntities’ Class which 
         * is the class that is created by the Entity Framework to handle communication between the database, the framework 
         * and any class which wishes to access the database.  Most of these methods are called from the relevant forms such 
         * StegApp, LoginRegister & Register which I will explain in a later section.
         */
        
        public BusinessObjects.User CurrentUser = new BusinessObjects.User();

        // I decided to hard code the connection string so it would not appear in the config file.
        //private string ConnectionString = "metadata=res://*/DataAccess.DataModel.Model.csdl|res://*/DataAccess.DataModel.Model.ssdl|res://*/DataAccess.DataModel.Model.msl;provider=System.Data.SqlClient;provider connection string=\"Data Source=ADMIN-PC\\SQLEXPRESS;Initial Catalog=DavidFlynnDatabase;Integrated Security=True\"";
        
        // I was going to use the below method to do encrytpyion on the config string, unfortunatley due to time constraints
        //i was not able to achieve this.
        public bool Decrypt()
        {

            // Open the configuration file and retrieve the connectionStrings section.
            Configuration configFile = ConfigurationManager.OpenExeConfiguration("WindowsFormsApplication4.exe");

            //get the section we wish to work with (in this case the connectionStrings section
            ConnectionStringsSection configSection = configFile.GetSection("connectionStrings") as ConnectionStringsSection;

            //check to see if the section is already encrypted
            if (configSection.SectionInformation.IsProtected)
            {
                //it is so we need to remove the encryption
                configSection.SectionInformation.UnprotectSection();
            }

            //re-save the configuration file
            configFile.Save(ConfigurationSaveMode.Full, true);

            //return true since we were successful
            return true;

        } 
        
        // Previously before hard coding i obtained the connection string from the configuration Manager. 
        private string ConnectionString
        {
            
            get
            {
               // string decrypted = Decrypt(ConfigurationManager.ConnectionStrings["leConnString"].ToString());
                
                //return Encrypt.DecryptString(Encrypt.EncryptString(ConfigurationManager.ConnectionStrings["DatabaseEntities"].ToString()));
                //Decrypt();
                return ConfigurationManager.ConnectionStrings["DatabaseEntities"].ToString();
            }
        }
        

        /* The first Method is AuthenicationCredentials which returns a Business User object and authenticates a user 
         * depending on two input arguments: username and password. I have a ‘using’ statement which declares a 
         * var dataContext = new DatabaseEntities(ConnectionString). ‘datacontext’ is the local object which is an instance 
         * of DatabaseEntities which connects to the database using ‘ConnectionString’. 
         * var user = dataContext.Users.FirstOrDefault(u => u.Username.Equals(username) && u.Password.Equals(password));
         * The above line declares another variable user; datacontext.Users is the User table in the database while 
         * dataContext.Users.FirstOrDefault() accesses the first or default row in table according to the condition set in 
         * the brackets. In the brackets I have the following statement:
         * u => u.Username.Equals(username) && u.Password.Equals(password) which specifies row u or object u returned where 
         * the username and password match what is passed to that linq statement, namely username & password. If no row is 
         * found which matches the requirements set by the linq statement; then null is returned which is what is returned 
         * to the function call. If a match is found CurrentUser( a Business.User object) is assigned the object returned 
         * by GetUser(userid)
         */
        public BusinessObjects.User AuthenitcateCredentials(string username, string password)
        {
            using(var dataContext = new DatabaseEntities(ConnectionString))
            {
                var user = dataContext.Users.FirstOrDefault(u => u.Username.Equals(username) && u.Password.Equals(password));
                if (user == null) return null;
                CurrentUser = GetUser(user.UserId);
                return CurrentUser;
            }
        }
       
        /* This function  uses the following statement: var user = dataContext.Users.FirstOrDefault(u => u.UserId == userId); 
         * To search and return the entry in the table that corresponds to that user id. If one is found then a 
         * new Business.User object is returned which correlates exactly with its counterpart in the database.
         */
        public BusinessObjects.User GetUser(int userId)
        {
            using (var dataContext = new DatabaseEntities(ConnectionString))
            {
                var user = dataContext.Users.FirstOrDefault(u => u.UserId == userId);
                if (user == null) return null;
                //BusinessObjects.User NowUser = new BusinessObjects.User();
                return new BusinessObjects.User
                {
                    UserId = user.UserId,
                    Username = user.Username,
                    Password = user.Password,
                    Firstname = user.Firstname,
                    Lastname = user.Lastname,
                    Town = user.Town,
                    County = user.County,
                    Country = user.Country


                };
            }
        }

        //‘ObtainUser’ is the same as ‘GetUser’ except identification is done by ‘username’
        public BusinessObjects.User ObtainUser(string username)
        {
            using (var dataContext = new DatabaseEntities(ConnectionString))
            {
                var user = dataContext.Users.FirstOrDefault(u => u.Username == username);
                if (user == null) return null;
                //BusinessObjects.User NowUser = new BusinessObjects.User();
                return new BusinessObjects.User
                {
                    UserId = user.UserId,
                    Username = user.Username,
                    Password = user.Password,
                    Firstname = user.Firstname,
                    Lastname = user.Lastname,
                    Town = user.Town,
                    County = user.County,
                    Country = user.Country


                };
            }
        }

        /*’InsertUser’ will create a new entry in the user table in the database using the arguments that it is called with. 
         * It creates a new datacontext object and a new Business User object which is assigned the values passed into the 
         * function.  Then this object is added to the Users table by calling AddObject() and SaveChanges() to save it.
         */
        public int InsertUser(string username, string password, string firstname, string lastname, string Town, string County, string Country)
        {
            using (var dataContext = new DatabaseEntities(ConnectionString))
            {
                var user = new User
                {
                    Username = username,
                    Password = password,
                    Firstname = firstname,
                    Lastname = lastname,
                    Town = Town,
                    County = County,
                    Country = Country
                };

                dataContext.Users.AddObject(user);
                dataContext.SaveChanges();
                return user.UserId;
            }
        }

        /*‘UpdateUser’ will insert the contents of the Business User object passed to it into the database table User again a 
         * datacontext variable and linq statements. 
         */
        public void UpdateUser(BusinessObjects.User user)
        {
            using (var dataContext = new DatabaseEntities(ConnectionString))
            {
                var u = dataContext.Users.FirstOrDefault(t => t.UserId == user.UserId);
                if (u != null)
                { 
                    u.Firstname = user.Firstname;
                    u.Lastname = user.Lastname;
                    //u.MessageKey = user.MesageKey;
                    u.Town = user.Town;
                    u.County = user.County;
                    u.Country = user.Country;
                    dataContext.SaveChanges();
                }
            }
        }


        /*‘InsertLog’ is used to insert a log entry into the log table in the database. A new Log object is created which 
         * values are set to what has been passed to the function. Then the object is added to the database and saved. I 
         * have two different insert log functions for the case that three of four arguments are passed to the function.
         */
        public void InsertLog(BusinessObjects.User user, int endUserId, string messageKey)
        {
            using (var dataContext = new DatabaseEntities(ConnectionString))
            {
                var log = new Log
                {

                    PictureId = null,
                    SentDatetime = DateTime.Now,
                    MessageKey = messageKey,
                    UserId = user.UserId,
                    EndUserID = endUserId
                };
                dataContext.Logs.AddObject(log);
                dataContext.SaveChanges();

            }
        }

        public void InsertLog(BusinessObjects.User user, int endUserId, string messageKey, int PicId)
        {
            using (var dataContext = new DatabaseEntities(ConnectionString))
            {
                var log = new Log
                {

                    PictureId = PicId,
                    SentDatetime = DateTime.Now,
                    MessageKey = messageKey,
                    UserId = user.UserId,
                    EndUserID = endUserId
                };
                dataContext.Logs.AddObject(log);
                dataContext.SaveChanges();

            }
        }

        /*This function will return the log object corresponding the relevant log entry in the log which corresponds to the 
         * userid passed to the function
         */
        public BusinessObjects.Log RetreiveMessages(int userid)
        {
            using (var dataContext = new DatabaseEntities(ConnectionString))
            {
                /*I wanted to be able to pull the last or default entry which corresponds to that user id but DatabaseEntities 
                 * objects does not have the option to use LastOrDefault even if it is listed!? So I had to use the code shown 
                 * below. To retrieve the last entry in the log table which corresponds to that user id.  I get around this 
                 * by sorting the relevant logs by descending date and assigning the first entry of that list to a new 
                 * variable u1. Then I proceed as before and return the correct log object requested
                 */
                var u = from p in dataContext.Logs
                        where p.EndUserID == userid
                        orderby p.SentDatetime descending
                        select p;
                var u1 = u.FirstOrDefault();
                if (u1 == null) return null;
                return new BusinessObjects.Log
                    {
                        LogId = u1.LogId,
                        UserId = userid,
                        EndUserID = u1.EndUserID,
                        PictureId = Convert.ToInt32(u1.PictureId),
                        MessageKey = u1.MessageKey,
                        SentDateTime = u1.SentDatetime
                    };

            }
        }

        /*‘SaveImage’ will save the image passed to it in the Picture table in the database. Notice that I had a different 
         * approach in using the following: var u = dataContext.Pictures.CreateObject(); To create the actual object and 
         * modify its elements directly and then add and save them. 
         */
        public int SaveImage(string filename, byte[] imagePath, BusinessObjects.PictureType pictureType)
        {
            using (var dataContext = new DatabaseEntities(ConnectionString))
            {
               
                var u = dataContext.Pictures.CreateObject();
                //var p = dataContext.Logs;
                u.PictureName = filename;
                //u.PictureData = File.ReadAllBytes(imagePath);
                u.PictureData = imagePath;
                u.PictureStatus = true;
                u.PictureTypeID = (int)pictureType;
                //u.PictureId = dataContext.Logs;

                dataContext.Pictures.AddObject(u);
                dataContext.SaveChanges();
                return u.PictureId;
            }
            
        }

        //‘GetPicture’ returns picture object when known Picture Id is passed to it. 
        public BusinessObjects.Picture GetPicture(int pictureId)
        {
            using (var dataContext = new DatabaseEntities(ConnectionString))
            {
                var picture = dataContext.Pictures.FirstOrDefault(p => p.PictureId == pictureId);
                if (picture == null) return null;

                BusinessObjects.Picture pic =  new BusinessObjects.Picture()
                {
                    PictureId = picture.PictureId,
                    PictureName = picture.PictureName,
                    PictureTypeId = picture.PictureTypeID,
                    PictureStatus = picture.PictureStatus,
                    PictureData = picture.PictureData,
                    PictureTypeDescription = picture.PictureType.TypeDescription
                };
                return pic;
            }
        }
    }
}
