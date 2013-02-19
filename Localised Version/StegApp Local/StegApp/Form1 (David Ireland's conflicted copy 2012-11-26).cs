using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        private DataAccess.DataAccess dataAccess;
        Bitmap image1;
        StringBuilder sb = new StringBuilder();
        string a = "te";

        public Form1()
        {
            InitializeComponent();
            dataAccess = new DataAccess.DataAccess();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void eventBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eventBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

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

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            //string bitString = GetBits("Blue Box");

            try
            {
                DialogResult result = openFileDialog1.ShowDialog();
                if (result != DialogResult.OK) return;
                
                string filename = openFileDialog1.FileName;
                // Retrieve the image.

                //image1 = new Bitmap(@"C:\Users\Admin\Documents\7-1541.jpg", true);
                image1 = new Bitmap(filename, true);

                int x, y,z=0;
                //string a = "test";
                string imageFormat = image1.PixelFormat.ToString();
                //StringBuilder sb = new StringBuilder();
                foreach (byte b in Encoding.Unicode.GetBytes(a))
                {
                    sb.Append(Convert.ToString(b, 2));
                }
                int c = sb.Length;
                //z= c+1;
                byte Mask0 = 254;
                byte Mask1 = 1;
                byte NewRed=0, NewGreen=0, NewBlue=0;
                // Loop through the images pixels to reset color.
                for (x = 0, y = 0; x < image1.Width && z < c; x++)
                {
                    for (y = 0; y < image1.Height && z<c; y++)
                    {
                        Color pixelColor = image1.GetPixel(x, y);
                        //byte NewRed, NewGreen, NewBlue;
                        if (sb[z] == '0')
                        {
                            NewRed = Convert.ToByte(pixelColor.R & Mask0);
                            //Color newColor = Color.FromArgb(NewRed, pixelColor.G, pixelColor.B);
                            //image1.SetPixel(x, y, newColor);
                            z++;
                            if (z == c)
                            {
                                break;
                            }
                           
                        }
                        else
                        {
                            NewRed = Convert.ToByte(pixelColor.R | Mask1);
                            //Color newColor = Color.FromArgb(NewRed, pixelColor.G, pixelColor.B);
                            //image1.SetPixel(x, y, newColor);
                            z++;
                            if (z == c)
                            {
                                break;
                            }
                            
                        }
                        if (sb[z] == '0')
                        {
                            NewGreen = Convert.ToByte(pixelColor.G & Mask0);
                            //Color newColor = Color.FromArgb(pixelColor.R, NewGreen, pixelColor.B);
                            //image1.SetPixel(x, y, newColor);
                            z++;
                            if (z == c)
                            {
                                break;
                            }                           
                        }
                        else
                        {
                            NewGreen = Convert.ToByte(pixelColor.G | Mask1);
                            //Color newColor = Color.FromArgb(pixelColor.R, NewGreen, pixelColor.B);
                            //image1.SetPixel(x, y, newColor);
                            z++;
                            if (z == c)
                            {
                                break;
                            }
                        }
                        if (sb[z] == '0')
                        {
                            NewBlue = Convert.ToByte(pixelColor.B & Mask0);
                            Color newColor = Color.FromArgb(NewRed, NewGreen, NewBlue);
                            image1.SetPixel(x, y, newColor);
                            z++;
                            if (z == c)
                            {
                                break;
                            }
                           
                        }
                        else
                        {
                            NewBlue = Convert.ToByte(pixelColor.B | Mask1);
                            Color newColor = Color.FromArgb(NewRed, NewGreen, NewBlue);
                            image1.SetPixel(x, y, newColor);
                            z++;
                            if (z == c)
                            {
                                break;
                            }
                        }
                        //string binary1 = Convert.ToString(pixelColor.R, 2);
                        //char last1 = binary1[binary1.Length - 1];
                       }
                }
                //Color newColor = Color.FromArgb(NewRed, NewGreen, NewBlue);
                //image1.SetPixel(x, y, newColor);
                // Set the PictureBox to display the image.
                pictureBox1.Image = image1;

                // Display the pixel format in Label1.
                label1.Text = "Pixel format: " + image1.PixelFormat.ToString();

            }
            catch (ArgumentException)
            {
                MessageBox.Show("There was an error." +
                    "Check the path to the image file.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "paul";
            string password = "blah";

            if(dataAccess.AuthenitcateCredentials(username,password))
            {
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int c = sb.Length,x,y,z=0;
            char[] Message= new char[c];
            StringBuilder RetreivedMessage = new StringBuilder();
            for (x = 0, y = 0; x < image1.Width && z < c; x++)
            {
                for (y = 0; y < image1.Height && z < c; y++)
                {
                    Color pixelColor = image1.GetPixel(x, y);
                    string binary1 = Convert.ToString(pixelColor.R, 2);
                    //byte NewRed, NewGreen, NewBlue;
                    if (binary1[binary1.Length -1] == '0')
                    {
                        RetreivedMessage.Append('0');
                        z++;
                        if (z == c)
                        {
                            break;
                        }

                    }
                    else
                    {
                        RetreivedMessage.Append('1');
                        z++;
                        if (z == c)
                        {
                            break;
                        }

                    }
                    binary1 = Convert.ToString(pixelColor.G, 2);
                    //byte NewRed, NewGreen, NewBlue;
                    if (binary1[binary1.Length - 1] == '0')
                    {
                        RetreivedMessage.Append('0');
                        z++;
                        if (z == c)
                        {
                            break;
                        }

                    }
                    else
                    {
                        RetreivedMessage.Append('1');
                        z++;
                        if (z == c)
                        {
                            break;
                        }

                    }
                    binary1 = Convert.ToString(pixelColor.B, 2);
                    //byte NewRed, NewGreen, NewBlue;
                    if (binary1[binary1.Length - 1] == '0')
                    {
                        RetreivedMessage.Append('0');
                        z++;
                        if (z == c)
                        {
                            break;
                        }

                    }
                    else
                    {
                        RetreivedMessage.Append('1');
                        z++;
                        if (z == c)
                        {
                            break;
                        }

                    }
                    //string binary1 = Convert.ToString(pixelColor.R, 2);
                    //char last1 = binary1[binary1.Length - 1];
                }
            }
            string FinalRetreivedMessage  = RetreivedMessage.ToString();
            //Byte[] buf = Encoding.Unicode.GetBytes(RetreivedMessage.ToString());
            Byte[] buf = Encoding.Unicode.GetBytes(RetreivedMessage.ToString());
            string result = System.Text.Encoding.Unicode.GetString(buf);
            //String result = Encoding.Unicode.GetString(buf);
            StringBuilder r2 = new StringBuilder();
            foreach (Byte b in Encoding.Unicode.GetBytes(buf))
            {
               r2.Append(Convert.ToString(b,8));
            }
        }
    }
}
