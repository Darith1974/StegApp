using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication4.DataAccess;
using System.Configuration;



namespace WindowsFormsApplication4
{
    /*This class implements the functionality behind the loginRegister form which is the first form the user is presented 
     * with. The user enters his/hers username and password. Please now refer
     * to line 25.
     */
    public partial class LoginRegister : Form  
    {
        // The following two functions are redundant. They were to be used as one approach to encrypt the connection string,
        // but i decided to go with hard coding the string instead. Please now refer to line 81.
        public bool Encrypt()
        {

            // Open the configuration file and retrieve the connectionStrings section.
            Configuration configFile = ConfigurationManager.OpenExeConfiguration("WindowsFormsApplication4.exe");

            //get the section we wish to work with (in this case the connectionStrings section
            ConnectionStringsSection configSection = configFile.GetSection("connectionStrings") as ConnectionStringsSection;

            //check to see if the section is already encrypted
            if (!configSection.SectionInformation.IsProtected)
            {
                //it is so we need to remove the encryption
                configSection.SectionInformation.ProtectSection("RSAProtectedConfigurationProvider");

                //re-save the configuration file
                configFile.Save(ConfigurationSaveMode.Full, true);


            }
            return true;
            //not encrypted so we need to encrypt it


            //return true since we were successful


        }
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

        public LoginRegister()
        {
            //I use the load function here to load a banner into the picture box. Please now refer to line 127.
            InitializeComponent();
            pictureBox1.Image = new Bitmap(@"C:\Users\Admin\Documents\Visual Studio 2010\Projects\StegApp\StegApp\Resources\MyBannerMaker_Banner.gif", true);
            //Encrypt();
            //Decrypt();
            /*
            Configuration conf = ConfigurationManager.OpenExeConfiguration(WindowsFormsApplication4);
            ConfigurationSection section = this.conf.GetSection("connectionStrings");
            if (!section.SectionInformation.IsProtected) 
            {
                section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                section.SectionInformation.ForceSave = true;conf.Save(ConfigurationSaveMode.Modified);
            }
            //To decrypt just do the oposite:
            if (section.SectionInformation.IsProtected) 
            {
                section.SectionInformation.UnprotectSection();
            }*/
        }

        private void LoginRegister_Load(object sender, EventArgs e)
        {

        }
        static int x = 200;
        static int y = 200;

        public void loginFn(string login, string password)
        {
            /*When the login button is clicked I create an instance of DataAccess.cs and call the AuthenticateCredentials 
             * function passing the username and password from the text boxes. If verified I make this form invisible and 
             * open a new instance of StegApp.cs form which is the main user interface. If not verified I present a message 
             * to enter correct details or press the register button to register.
             */
            DataAccess.DataAccess LoginAndRegister = new DataAccess.DataAccess();
            if (LoginAndRegister.AuthenitcateCredentials(login, password) != null)
            {
                StegApp form2 = new StegApp();
                form2.Visible = true;
                //LoginRegister.ActiveForm.Visible = false;
                //Close();

            }
            else
            {
                MessageBox.Show("Sorry, Login credentials incorrect,Please enter\n correct credentials or register");
                return;
            }

        }

        // This function is the event for clicking on the login button. It calls loginFn(string login, string password)
        //Please now refer to line 110.
        private void Login_Click(object sender, EventArgs e)
        {

            loginFn(UserTextBox.Text, PasswordTextBox.Text);
            
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            return;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Register form3 = new Register();
            form3.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        public string WindowsFormsApplication4 { get; set; }

        private void UserTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
