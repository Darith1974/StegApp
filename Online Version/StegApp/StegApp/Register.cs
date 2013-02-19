using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication4.DataAccess;


namespace WindowsFormsApplication4
{
    public partial class Register : Form
    {
        public Register()
        {
            // //I use the load function here to load a banner into the picture box. Please now refer to line 39.
            InitializeComponent();
            pictureBox1.Image = new Bitmap(@"C:\Users\Admin\Documents\Visual Studio 2010\Projects\StegApp\StegApp\Resources\MyBannerMaker_Banner.gif", true);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void RegisterFn(string username, string password, string firstname, string surname, string town,string county, string country)
        {
            /*When the register button is clicked on the login form, a new form is open which allows a new user to enter their 
             * details.  The register button calls the RegisterFn. Inside this function I declare an object of DataAccess and 
             * I call the InserUser function passing all the information in the relevant text boxes.
             */
            DataAccess.DataAccess Registration = new DataAccess.DataAccess();
            int userid = Registration.InsertUser(username, password, firstname, surname, town, county, country);
            MessageBox.Show("Your Userid is : " + userid + ". Remember other users need your Id to store keys or images for you in the Database");
            StegApp form1 = new StegApp();
            form1.Visible = true;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            // This function is the event for clicking on the login button. It calls RegisterFn
            //Please now refer to line 30.
            RegisterFn(UsernameTextBox.Text, PasswordTextBox3.Text, FirstNameTextBox.Text, LastNameTextBox.Text, TownTextBox.Text, CountryTextBox.Text, CountryTextBox.Text);
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TownTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
