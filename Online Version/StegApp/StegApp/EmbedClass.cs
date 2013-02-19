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
    class EmbedClass
    {
        /*EmbedClass.cs is a class I created specifically for embedding a message inside a image. Within this class I have a 
         * public method: public int Embed(string Embedkey, string EmbedMessage, Bitmap image3) 
         * Which takes as parameters the Key, the message and the image as a bitmap object.
         */
        public StringBuilder sb = new StringBuilder();
        public byte Mask0 = 254, Mask1 = 1;
        public byte NewRed = 0, NewGreen = 0, NewBlue = 0;
        public string[] tmp2;
        public string tmp;
        public string tmp3,temp4, temp5;
        bool key = false;
        public byte[] b1;
        public StringBuilder binaryString = new StringBuilder();
        public int StringLenght = 0;
        public int x1, y1, c, z = 0;
        public Color pixelColor = new Color();
        


        public int Embed(string Embedkey, string EmbedMessage, Bitmap image3)
        {
            try
            {
                /* Firstly, there is a while loop which forces the user to enter a key if one is not present plus makes sure 
                 * it is no longer than six characters. I then create a four character string(temp5) which contains the length 
                 * of the message in decimal format, e.g. if the message is say 20 characters, then temp5 would be ‘0020’. 
                 * Finally I concatenate the key, the message length and the message into one string temp4. Now I must convert 
                 * this string to a byte array b1. I then have a for loop which iterates through each byte of the b1 array: 
                 * Each element of the array ‘b1’ contains the decimal ascii of each character in temp4. The while loop will 
                 * convert each element of the byte array to its equivalent binary string and store it in the string:’ tmp’. 
                 * Each value of tmp is sequentially stored in the string array tmp2.
                 */
                //image1 = image3;
                //EmbedMessage = Encrypt1.EncryptString(EmbedMessage,Embeykey);
                while (!key)
                {
                    if ((Embedkey == "") ||  (Embedkey.Length < 6))
                    {
                        //b1 = ASCIIEncoding.ASCII.GetBytes(textBox5.Text);
                        key = false;
                        //MessageBox.Show("Error, enter your six digit key!");
                        return 1;
                    }
                    else if (Embedkey.Length > 6)
                    {
                        //MessageBox.Show("Error, Key too long, try again!");
                        return 2;
                    }
                    else
                    {
                        //temp4 = textBox4.Text[0] + textBox4.Text[1] + textBox4.Text[2] + textBox4.Text[3] + textBox4.Text[4] + textBox4.Text[5] + textBox5.Text;
                        c = EmbedMessage.Length;
                        temp5 = c.ToString();
                        if (c <= 9)
                        {
                            temp5 = "000" + temp5;
                        }
                        else if (c <= 99)
                        {
                            temp5 = "00" + temp5;
                        }
                        else if (c <= 999)
                        {
                            temp5 = "0" + temp5;
                        }
                        else if (c <= 9999)
                        {

                        }
                        else
                        {
                            //MessageBox.Show("Message too long for this tool,try again");
                            return 3;
                        }
                        temp4 = Embedkey + temp5 + EmbedMessage;
                        b1 = ASCIIEncoding.ASCII.GetBytes(temp4);
                        key = true;
                    }

                }

                tmp2 = new string[b1.Length];
                /* The next for loop concatenates each element in tmp2 to tmp3. What follows is redundant piece of code which 
                 * appends either ‘00’ or ‘01’ to start of the binary string tmp3 depending on whether a key is used or not. 
                 * However I have changed the piece of code to only accept a key so ‘00’ is just appended at the beginning of 
                 * tmp3 anyway. ‘tmp2’ is then appended to ‘sb’ the string builder which is initialised as zero. ‘stringlenght’
                 * is the length of ‘sb’
                 */
                //Interate through each byte
                for (int i = 0; i < b1.Length; i++)
                {
                    int x = b1[i];
                    tmp = "";
                    while (true)
                    {
                        if ((x % 2) == 1)
                        {
                            tmp = "1" + tmp;
                        }
                        else
                        {
                            tmp = "0" + tmp;
                        }
                        x /= 2;
                        if (x < 1) break;
                    }

                    //Make sure the value is 8 chars long.
                    tmp2[i] = tmp.PadLeft(8, '0');

                }
                //string a="";
                for (int i = 0; i < b1.Length; i++)
                {
                    //a = tmp2[i];
                    tmp3 = tmp3 + tmp2[i];
                }
                if (key)
                {
                    tmp3 = "00" + tmp3;
                }
                else
                {
                    tmp3 = "10" + tmp3;
                }
                //tmp3 = Encrypt1.EncryptString(tmp3);

                sb.Append(tmp3);
                //temp5 = c.ToString();
                //z= c+1;
                StringLenght = sb.Length;

                /* What follows next is a nested for loop whereby the first for loop counts the number of columns and the next 
                 * for loop counts the number of rows. These for loops will naturally stop when the each pixel has been 
                 * accessed in the image and also when the nested loop has iterated the same number of times as the length 
                 * of the string. The loop will determine whether the current bit in sb is either a zero or one. If zero then 
                 * the relevant pixel in sequence is and-ed with Mask0 and when it is a one; then the relevant pixel is or-ed 
                 * with Mask1. The pixels are accessed in sequence by red, green and blue. This method returns a int to its 
                 * call which determines if a message box must be displayed indicating the key is of the wrong length or the 
                 * message is too long.
                 */
                // Loop through the images pixels to reset color.
                for (x1 = 0, y1 = 0; x1 < image3.Width && z < StringLenght; x1++)
                {
                    for (y1 = 0; y1 < image3.Height && z < StringLenght; y1++)
                    {
                        pixelColor = image3.GetPixel(x1, y1);
                        //byte NewRed, NewGreen, NewBlue;
                        if (sb[z] == '0')
                        {
                            NewRed = Convert.ToByte(pixelColor.R & Mask0);
                            Color newColor = Color.FromArgb(NewRed, pixelColor.G, pixelColor.B);
                            image3.SetPixel(x1, y1, newColor);
                            pixelColor = image3.GetPixel(x1, y1);

                            z++;
                            if (z == StringLenght)
                            {
                                break;
                            }

                        }
                        else
                        {
                            NewRed = Convert.ToByte(pixelColor.R | Mask1);
                            Color newColor = Color.FromArgb(NewRed, pixelColor.G, pixelColor.B);
                            image3.SetPixel(x1, y1, newColor);
                            pixelColor = image3.GetPixel(x1, y1);

                            z++;
                            if (z == StringLenght)
                            {
                                break;
                            }

                        }
                        if (sb[z] == '0')
                        {
                            NewGreen = Convert.ToByte(pixelColor.G & Mask0);
                            Color newColor = Color.FromArgb(pixelColor.R, NewGreen, pixelColor.B);
                            image3.SetPixel(x1, y1, newColor);
                            pixelColor = image3.GetPixel(x1, y1);

                            z++;
                            if (z == StringLenght)
                            {
                                break;
                            }
                        }
                        else
                        {
                            NewGreen = Convert.ToByte(pixelColor.G | Mask1);
                            Color newColor = Color.FromArgb(pixelColor.R, NewGreen, pixelColor.B);
                            image3.SetPixel(x1, y1, newColor);
                            pixelColor = image3.GetPixel(x1, y1);

                            z++;
                            if (z == StringLenght)
                            {
                                break;
                            }
                        }
                        if (sb[z] == '0')
                        {
                            NewBlue = Convert.ToByte(pixelColor.B & Mask0);
                            Color newColor = Color.FromArgb(pixelColor.R, pixelColor.G, NewBlue);
                            image3.SetPixel(x1, y1, newColor);
                            pixelColor = image3.GetPixel(x1, y1);

                            z++;
                            if (z == StringLenght)
                            {
                                break;
                            }

                        }
                        else
                        {
                            NewBlue = Convert.ToByte(pixelColor.B | Mask1);
                            Color newColor = Color.FromArgb(pixelColor.R, pixelColor.G, NewBlue);
                            image3.SetPixel(x1, y1, newColor);
                            pixelColor = image3.GetPixel(x1, y1);

                            z++;
                            if (z == StringLenght)
                            {
                                break;
                            }
                        }

                    }
                }
                //return image1;
                MessageBox.Show("Message embedded");


            }
            catch (ArgumentException)
            {
                MessageBox.Show("There was an error." +
                    "Check the path to the image file.");
            }
            return 4;
        }
    }
}
