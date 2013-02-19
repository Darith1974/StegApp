using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication4.DataAccess;
using WindowsFormsApplication4.BusinessObjects;
using System.IO;

namespace WindowsFormsApplication4
{
    public partial class StegApp : Form
    {
        /*The vast majority of the code which implements the steganography, i.e. actually encodes the message inside the 
         * image and retrieves the message from a carrier file is code associated with the events of pressing two buttons: 
         * ‘Embed Message’ in the send screen and ‘Retrieve Message’ in the ‘Receive Message’ tab. I start off by declaring 
         * variables which will be used in both methods within both classes. These include string builders, strings, and 
         * ints’ and byte arrays. Some of these are declared within the StepApp.cs or within EmbedClass.cs or 
         * RetreiveMessageClass respectively.  ‘button2_Click’(line 118) is the function which implements the embed functionality. 
         * It declares an object of the EmbedClass and accesses the method Embed. The code behind the ‘Retrieve Message’ 
         * button is implemented in the function button4_Click(object sender, EventArgs e);line 166. It declares an object of 
         * RetrieveMessageClass. Please now refer to line 68. 

         */
        private DataAccess.DataAccess dataAccess;
        public Bitmap image1,image2,image5;
        public DataAccess.DataAccess RetreiveLogs = new DataAccess.DataAccess();
        public DialogResult result2;

        public StegApp()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            dataAccess = new DataAccess.DataAccess();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void eventBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eventBindingSource.EndEdit();
           // this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'davidFlynnDatabaseDataSet.StegApp' table. You can move, or remove it, as needed.
            //this.stegAppTableAdapter.Fill(this.davidFlynnDatabaseDataSet.StegApp);
            // TODO: This line of code loads data into the 'database1DataSet.Event' table. You can move, or remove it, as needed.
            //this.eventTableAdapter.Fill(this.database1DataSet.Event);
        }

        private void eventDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        /*‘btnSelectFile_Click(object sender, EventArgs e)’ is the function which allows the user to select a file in 
         * order to be used as the carrier for the message. I use the dialog class to open a simple user interface 
         * for the user to select a file from their hard drive and I then set this image to display in the picture box.
         * Please now refer to line 227.
         */
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            //string bitString = GetBits("Blue Box");

            try
            {
                DialogResult result = openFileDialog1.ShowDialog();
                if (result != DialogResult.OK) return;
                
                string filename = openFileDialog1.FileName;
                // Retrieve the image.
                //New code 28dec12
                pictureBox1.Image = Image.FromFile(filename);
                image1 = (Bitmap)pictureBox1.Image;
               
              
            }
            catch (ArgumentException)
            {
                MessageBox.Show("There was an error." +
                    "Check the path to the image file.");
            }
        }

        public void SaveKeyOnly(string uname, string pword,string key,string euser)
        {
            /* SaveKeyOnly function. The arguments it takes is the user’s username, password; the key and the UserId of the 
             * intended of the recipient. When a user decides to send a key, image or both via the database, it must be 
             * recorded somewhere for whom the actual key is for; so the UserId of the recipient must be entered in one 
             * of the text boxes shown. A Business user object p is declared and a DatabaseEntities object is declared. 
             * Using this object; AuthenicateCredentials is called to verify the user and the result is stored in the local 
             * Business User Object. If the user is valid then the InsertLog function is called; the version which takes 
             * three arguments: the user, the key and the id of the end user. If the user credentials are invalid; then a 
             * message box appears informing the user to enter the correct details. Refer next to line 439.
             */
            DataAccess.DataAccess EndUserform = new DataAccess.DataAccess();
            BusinessObjects.User p = new BusinessObjects.User();
            p = EndUserform.AuthenitcateCredentials(uname,pword);
            if (p != null)
            {
                //int Pid = u.SaveImage(ImageNametextBox1.Text, BitmapToByteArray(image1), BusinessObjects.PictureType.UserImages);
                EndUserform.InsertLog(p, Convert.ToInt32(euser), key);
                MessageBox.Show("Key saved.");
            }
            else
            {
                MessageBox.Show("Please enter your correct username and password in order to save either key, image or both in Databse");
            }
            //EndUserform.InsertLog(EndUserform.AuthenitcateCredentials(UsernameTextBox.Text,PasswordtextBox1.Text), Convert.ToInt32(EndUsertextBox1.Text), textBox4.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //The next event to consider is ‘Save Key in Database’. This will call the SaveKeyOnly function. Refer to line 99.
            SaveKeyOnly(UsernameTextBox.Text, PasswordtextBox1.Text, textBox4.Text, EndUsertextBox1.Text);
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            EmbedClass embed1 = new EmbedClass();
            int Embed3 = embed1.Embed(textBox4.Text, textBox5.Text, image1);
            if(Embed3 == 1)
            {
                MessageBox.Show("Error, enter your six digit key!");
                //return;
            }
            else if(Embed3 == 2)
            {
                MessageBox.Show("Error, Key too long, try again!");
                //return;
            }
            else if(Embed3 == 3)
            {
                MessageBox.Show("Message too long for this tool,try again");
                //return;
            }
            else if (Embed3 == 4)
            {

            }
            // Embed(textBox4.Text,textBox5.Text,image1);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        public void textBox5_TextChanged(object sender, EventArgs e)
        {
            this.Text = textBox5.Text;
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            RetrieveMessageClass Retrieve1 = new RetrieveMessageClass();
            string result4 =Retrieve1.Retrieve(textBox7.Text, image2);
            if (result4 == null)
            {
                MessageBox.Show("Error, please enter correct six character key and then press 'Retreive Message'");
            }
            else
            {
                textBox6.Text = result4;
            }
            // Retreive(textBox7.Text,image2);
        }

        public void SaveImageDisk()
        {
            
           
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            try
            {
                if (image5 != null)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show(saveFileDialog1.FileName, "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        string s;
                        s = ".bmp";
                        //if (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.LastIndexOf('.')).Equals(s))
                        //{

                       image5.Save(saveFileDialog1.FileName.ToString());
                        //BitmapFile.Dispose();
                        //}
                        // else
                        // {
                        //     MessageBox.Show("Not a BMP file!");
                        // }

                    }
                }
                else
                {
                    MessageBox.Show("My PicBox is empty!");
                }
                //EndUser form3 = new EndUser(textBox4.Text);
                //form3.Visible = true;
            }
            catch (Exception) { MessageBox.Show("Cannot save file, error!"); }
          
        }


        /*button5_Click(object sender, EventArgs e) is the function I use to save the carrier file with the embedded message.
         * I use the saveFileDialog class to allow the user to save the file to disk. The event handler calls the function 
         * SaveImageDisk() which handles the dialog. Next comment at line 361.
         */
        private void button5_Click(object sender, EventArgs e)
        {
            image5 = new Bitmap(pictureBox1.Image);
            SaveImageDisk();
           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        
        public void Selectfilefn()
        {
           

            
            result2 = openFileDialog1.ShowDialog();
            if (result2 != DialogResult.OK) return;

            string filename2 = openFileDialog1.FileName;
            // Retrieve the image.

            //image1 = new Bitmap(@"C:\Users\Admin\Documents\7-1541.jpg", true);
            image2 = new Bitmap(filename2, true);
            pictureBox2.Image = image2;
            //new code 28dec12 1321
            pictureBox2.Image = Image.FromFile(filename2);
            image2 = (Bitmap)pictureBox2.Image;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Selectfilefn();
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DisplayLogs.Visible = false;
        }

        public void RetreiveKeyFn(string username, string password)
        {
            /*Using the object Retreivelogs( a DatabseEntities object) declared outside this function I authenticate the user 
             * using AuthenicateCredentials. If this returns valid I then proceed to check if there are any logs in the 
             * database for the user Id of the validated user. The most recent log is the one attained. If no logs exist, 
             * then a message appears and informs the user of such; other the log is printed to a message box. Finally if 
             * a user is not validated;  then a message box is shown for this also. Next comment at line: 543.
             */
            BusinessObjects.User p = RetreiveLogs.AuthenitcateCredentials(username,password);
            if (p != null)
            {
                if (RetreiveLogs.RetreiveMessages(p.UserId) == null)
                {
                    DisplayLogs.Text = "Sorry No messages for you recorded in Database, your correspondant might have chose not to record the entry";
                }
                else
                {
                    MessageBox.Show("LogId = " + RetreiveLogs.RetreiveMessages(p.UserId).LogId + "\n" +
                    "UserId = " + RetreiveLogs.RetreiveMessages(p.UserId).UserId + "\n" +
                    "Message Key = " + RetreiveLogs.RetreiveMessages(p.UserId).MessageKey + "\n" + "PictureId = " + RetreiveLogs.RetreiveMessages(p.UserId).PictureId +
                    " Date & time = " + RetreiveLogs.RetreiveMessages(p.UserId).SentDateTime);
                    DisplayLogs.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Please enter your correct username and password in order to retreive either key, image or both from Databse");
            }
            
                                        
        }

        private void RetreiveKey_Click(object sender, EventArgs e)
        {
            /* In the receive tab of the form called StegApp.cs; there are two events which must be accounted for. The 
             * first such event is ‘Retrieve log (which might contain key) from Database’. This event is directed to the 
             * function:
             * Next comment : line 292.
             */
            RetreiveKeyFn(UserNtextBox.Text, textBox1.Text);

        }
        /* code for uploading of photos directly by admin.
        private void button2_Click_1(object sender, EventArgs e)
        {
            DataAccess.DataAccess u = new DataAccess.DataAccess();


          //  u.SaveImage("cloud", @"C:\Users\Admin\Documents\dt265\Project\Sky\sky-and-cloud.bmp", BusinessObjects.PictureType.Sky);


        }*/
       
        static int RandomPicture(int c, int d)
        {
            Random a = new Random();
            int e = a.Next(c, d);
            return e;
        }

        
        private Bitmap GetPictureFromDataBase(string pic)
        {
            /*A picture Entity Business object is declared and depending on the text of the drop down box a picture is pulled 
         * from the Database. This is done using GetPicture, a method of DataAccess.cs. As an argument it takes the 
         * picture id which is generated using the static function RandomPicture which picks an Id within the range 
         * that that particular category of photo is stored. This function will return a picture object which is assigned 
         * to the local picture Entity Object.  The actual picture is a byte array stored in ‘picture.PictureData’. This 
         * is passed from memory stream to image to bitmap and finally to the Picturebox in the ‘Send’ tab. Next comment 
         * at line 118.
         */
            var picture = new BusinessObjects.Picture();
            if (pic == "Animals")
            {
                picture = dataAccess.GetPicture(RandomPicture(30, 35));
            }
            else if (pic == "Earth")
            {
                picture = dataAccess.GetPicture(RandomPicture(35, 41));
            }
            else if (pic == "Sea")
            {
                picture = dataAccess.GetPicture(RandomPicture(45, 50));
            }
            else if (pic == "Sky")
            {
                picture = dataAccess.GetPicture(RandomPicture(54, 58));
            }
            MemoryStream ms = new MemoryStream(picture.PictureData);
            Image img = Image.FromStream(ms);
            Bitmap a = new Bitmap(img);

            
            image1 = a;
            return image1;
        }

        //“Get Image from Database” button on the send tab of the StegApp.cs form. It calls the function: 
        //GetPictureFromDataBase(comboBox1.Text). Refer to line 336.

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = GetPictureFromDataBase(comboBox1.Text);
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private byte[] BitmapToByteArray(System.Drawing.Image image3, System.Drawing.Imaging.ImageFormat format)
        {
          /*  Rectangle rect = new Rectangle(0, 0, image3.Width, image3.Height);
            System.Drawing.Imaging.BitmapData bmpData =
                image3.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                image3.PixelFormat);

            // Get the address of the first line.
            IntPtr ptr = bmpData.Scan0;

            // Declare an array to hold the bytes of the bitmap. 
            int bytes = Math.Abs(bmpData.Stride) * image3.Height;
            byte[] rgbValues = new byte[bytes];
            return rgbValues;*/
            byte[] Ret;
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    image3.Save(ms, format);
                    Ret = ms.ToArray();
                }
            }
            catch (Exception) { throw; }
            return Ret;

        }

        public void SaveImageFn(string uname, string pword, string ImageName, string EndUser)
        {
            /*The function is virtually the same as 'SaveKeyOnly' except it will call the four argument version of the 
             * InsertLog function which takes the pid, i.e. the picture id of the image stored in the Picture table of 
             * the database. This id is a primary in that table and a foreign key in the log table
             */
            DataAccess.DataAccess u = new DataAccess.DataAccess();
            BusinessObjects.User p = new BusinessObjects.User();
            p = u.AuthenitcateCredentials(uname, pword);
            if (p != null)
            {
                //The picture id is obtained by the following piece of code:
                /* Pid’ is returned by calling the SaveImage function via the DatabaseEntities object u. It takes the name of 
                 * the image which was passed to SaveImageFn. The image is converted to a byte array for storage by the 
                 * function BitmapToByteArray. Finally the enum BusinessObjects.PictureType.General is passed also which 
                 * is a category I gave to all images stored in the Database by Users. I simply put “Nokey” where the key 
                 * is normally stored in the log. Next comment at line at line 474
                 */
                int Pid = u.SaveImage(ImageName, BitmapToByteArray(image1, System.Drawing.Imaging.ImageFormat.Bmp), BusinessObjects.PictureType.General);
                u.InsertLog(p, Convert.ToInt32(EndUser), "NoKey", Pid);
                MessageBox.Show("Image Saved");
            }
            else
            {
                MessageBox.Show("Please enter your correct username and password in order to save either key, image or both in Databse");
            }
        }

        private void SaveImage_Click(object sender, EventArgs e)
        {
            //The button ‘Save Image in Database’ calls the function below. Refer to line 422.
            SaveImageFn(UsernameTextBox.Text, PasswordtextBox1.Text, ImageNametextBox1.Text, EndUsertextBox1.Text);
            
        }

        public void SaveImageAndKeyFn(string uname, string pword, string ImageName, string EndUser, string key)
        {
            //Which will store the key and image in the database. It is virtually the same as the function: SaveKeyFn except 
            //that the key is stored in the relevant log. Next comment at line 320.
            DataAccess.DataAccess u = new DataAccess.DataAccess();
            BusinessObjects.User p = new BusinessObjects.User();
            p = u.AuthenitcateCredentials(uname, pword);
            if (p != null)
            {
                int Pid = u.SaveImage(ImageName, BitmapToByteArray(image1, System.Drawing.Imaging.ImageFormat.Bmp), BusinessObjects.PictureType.General);
                u.InsertLog(p, Convert.ToInt32(EndUser), key, Pid);
                MessageBox.Show("Image and Key Saved");
            }
            else
            {
                MessageBox.Show("Please enter your correct username and password in order to save either key, image or both in Databse");
            }
        }

        private void SaveImageAndKey_Click(object sender, EventArgs e)
        {
            //Then we have the button “Save both Key and Image in Database”. This will call the function:
            SaveImageAndKeyFn(UsernameTextBox.Text, PasswordtextBox1.Text, ImageNametextBox1.Text, EndUsertextBox1.Text, textBox4.Text);
           //Refer to line 457.
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        public void RetreiveImageFn(string uname, string pword)
        {
            /* This function is similar to RetreiveKeyFn except for the following. An extra if else statement is added which 
             * checks if there is a picture Id in the retrieved log: RetreiveLogs.RetreiveMessages(p.UserId).PictureId 
             * The above statement is evaluated to ‘0’. If it is zero, then a message box is displayed which informs the 
             * user that there is picture associated with the most recent log. Otherwise a’using’ statement is implemented 
             * that uses both the RetrieveMessages function to get the picture id and pass it to GetPicture; the returned 
             * byte array is put into a memory stream which is converted to a bitmap object and displayed in the relevant 
             * picture box.

             */
            DataAccess.DataAccess RetreiveLogs = new DataAccess.DataAccess();
            BusinessObjects.User p = RetreiveLogs.AuthenitcateCredentials(uname, pword);
            if (p != null)
            {
                if (RetreiveLogs.RetreiveMessages(p.UserId) == null)
                {
                    DisplayLogs.Text = "Sorry No messages for you recorded in Database, your correspondant might have chose not to record the entry";
                    return;
                }
                else
                {
                    MessageBox.Show("LogId = " + RetreiveLogs.RetreiveMessages(p.UserId).LogId + "\n" +
                    "UserId = " + RetreiveLogs.RetreiveMessages(p.UserId).UserId + "\n" +
                    "Message Key = " + RetreiveLogs.RetreiveMessages(p.UserId).MessageKey + "\n" + "PictureId = " + RetreiveLogs.RetreiveMessages(p.UserId).PictureId +
                    " Date & time = " + RetreiveLogs.RetreiveMessages(p.UserId).SentDateTime);
                    DisplayLogs.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Please enter your correct username and password in order to retreive either key, image or both from Databse");
                return;
            }
            if (RetreiveLogs.RetreiveMessages(p.UserId).PictureId == 0)
            {
                MessageBox.Show("No Picture in Database, only key was stored");
            }
            else
            {
                using (MemoryStream stream = new MemoryStream(RetreiveLogs.GetPicture(RetreiveLogs.RetreiveMessages(p.UserId).PictureId).PictureData))
                {
                    //Convert.ToInt32(RetreiveLogs.RetreiveMessages(p.UserId).PictureId)
                    //stream =RetreiveLogs.GetPicture(53).PictureData;
                    Image img = Image.FromStream(stream);
                    Bitmap a = new Bitmap(img);

                    //Bitmap bmp = new Bitmap(stream);
                    image2 = a;
                    pictureBox2.Image = image2;
                }
            }
        }

        private void RetreiveImage_Click(object sender, EventArgs e)
        {
            //This event is passed to the function: RetreiveImageFn. Refer to line 498 for next comment.
            RetreiveImageFn(UserNtextBox.Text, textBox1.Text);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RetrievePictureBn_Click(object sender, EventArgs e)
        {

        }
    }
}
