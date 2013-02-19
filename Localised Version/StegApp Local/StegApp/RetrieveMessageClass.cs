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
    class RetrieveMessageClass
    {
        /*This class has one method: Retrieve which takes the arguments: the key entered by the end user and image they are 
         * trying to retrieve the message from. This code is very similar to that which has been explained in EmbedClass.
         * Please refer to this class and its comments if you have not done already. There are three nested for loops because 
         * the key and message length has to be retrieved along with the message itself. Please to refer to line 156 for 
         * next comment.
         */
        
        public byte Mask0 = 254, Mask1 = 1;
        public byte NewRed = 0, NewGreen = 0, NewBlue = 0;
        public string binary1, binary2, binary3, FinalMessageLenght, FinalRetreivedMessage, FinalResult;
        public StringBuilder KeyMessage = new StringBuilder();
        System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
        UTF8Encoding enc = new UTF8Encoding();
        public StringBuilder RetreivedMessage = new StringBuilder();
        public StringBuilder MessageLenght = new StringBuilder();
        public string KeyRetreived;
        public int count3, StringLenght = 0;
        public int x1, y1, c, z = 0, count2, count1;
        public Color pixelColor = new Color();
        public string MessageRet;
        //Crypto Encrypt2 = new Crypto();


        public string Retrieve(String KeyEntered, Bitmap image4)
        {
            int x = 0, y = 0;
            KeyMessage.Clear();
            RetreivedMessage.Clear();
            KeyRetreived = "";


            pixelColor = image4.GetPixel(x, y);
            binary1 = Convert.ToString(pixelColor.R, 2);
            binary2 = Convert.ToString(pixelColor.G, 2);
            binary3 = Convert.ToString(pixelColor.B, 2);
           
            if (binary1[binary1.Length - 1] == '0' && binary2[binary2.Length - 1] == '0')
            {
                if (binary3[binary3.Length - 1] == '0')
                {
                    KeyMessage.Append('0');
                    z++;


                }
                else
                {
                    KeyMessage.Append('1');
                    z++;


                }
                for (x = 0, y = 1; x < image4.Width && z < 48; x++)
                {
                    for (y = 1; y < image4.Height && z < 48; y++)
                    {
                        pixelColor = image4.GetPixel(x, y);
                        binary1 = Convert.ToString(pixelColor.R, 2);
                        //byte NewRed, NewGreen, NewBlue;
                        if (binary1[binary1.Length - 1] == '0')
                        {
                            KeyMessage.Append('0');
                            z++;
                            if (z == 48)
                            {
                                break;
                            }

                        }
                        else
                        {
                            KeyMessage.Append('1');
                            z++;
                            if (z == 48)
                            {
                                break;
                            }

                        }
                        binary1 = Convert.ToString(pixelColor.G, 2);
                        //byte NewRed, NewGreen, NewBlue;
                        if (binary1[binary1.Length - 1] == '0')
                        {
                            KeyMessage.Append('0');
                            z++;
                            if (z == 48)
                            {
                                break;
                            }

                        }
                        else
                        {
                            KeyMessage.Append('1');
                            z++;
                            if (z == 48)
                            {
                                break;
                            }

                        }
                        binary1 = Convert.ToString(pixelColor.B, 2);
                        //byte NewRed, NewGreen, NewBlue;
                        if (binary1[binary1.Length - 1] == '0')
                        {
                            KeyMessage.Append('0');
                            z++;
                            if (z == 48)
                            {
                                break;
                            }

                        }
                        else
                        {
                            KeyMessage.Append('1');
                            z++;
                            if (z == 48)
                            {
                                break;
                            }

                        }
                        
                    }
                }

                //z = 50;
                y = 17;
                pixelColor = image4.GetPixel(0, 16);
                binary1 = Convert.ToString(pixelColor.B, 2);
                if (binary1[binary1.Length - 1] == '0')
                {
                    MessageLenght.Append('0');
                    z++;
                }
                else
                {
                    MessageLenght.Append('1');
                    z++;
                }
                /*The conversion from binary string back to ascii is code which is unique to this method. An example is given 
                 * below: In the above piece of code ‘KeyRetreived’ is the string builder from which the binary string 
                 * representing the key is retrieved form the carrier file. It is converted to a string. ‘count’ is the 
                 * number of eight bit strings in sequence in the said string. ‘StringBytes’ is a bytes array of length count. 
                 * I then have a for loop which iterates through StringBytes converts each eight bits in sequence to a byte. 
                 * I use the substring function to access the eight bits in sequence. I then use the encoding class in .net to 
                 * turn StringBytes back to a string.
                 */
                KeyRetreived = KeyMessage.ToString();
                int count = KeyMessage.Length / 8;
                var StringBytes = new byte[count];
                for (int i = 0; i < count; i++)
                    StringBytes[i] = Convert.ToByte(KeyRetreived.Substring(i * 8, 8), 2);
               
                string FinalKey = enc.GetString(StringBytes);

                /*I follow the same procedure to attain the message length and the actual message. The key attained from the 
                 * image is compared with what the user has entered into the text box. If they are the same proceed; otherwise 
                 * try again. If the keys match; attain the message as described above and return this string to the function 
                 * call in the form which displays the message. 
                 */
                if (FinalKey != KeyEntered)
                {
                    MessageBox.Show("Error, please enter correct six character key and then press 'Retreive Message'");
                    return null;
                }
                else
                {
                    for (x = 0; x < image4.Width && z < 80; x++)
                    {
                        for (; y < image4.Height && z < 80; y++)
                        {
                            pixelColor = image4.GetPixel(x, y);
                            binary1 = Convert.ToString(pixelColor.R, 2);
                            //byte NewRed, NewGreen, NewBlue;
                            if (binary1[binary1.Length - 1] == '0')
                            {
                                MessageLenght.Append('0');
                                z++;
                                if (z == 80)
                                {
                                    break;
                                }

                            }
                            else
                            {
                                MessageLenght.Append('1');
                                z++;
                                if (z == 80)
                                {
                                    break;
                                }

                            }
                            binary1 = Convert.ToString(pixelColor.G, 2);
                            //byte NewRed, NewGreen, NewBlue;
                            if (binary1[binary1.Length - 1] == '0')
                            {
                                MessageLenght.Append('0');
                                z++;
                                if (z == 80)
                                {
                                    break;
                                }

                            }
                            else
                            {
                                MessageLenght.Append('1');
                                z++;
                                if (z == 80)
                                {
                                    break;
                                }

                            }
                            binary1 = Convert.ToString(pixelColor.B, 2);
                            //byte NewRed, NewGreen, NewBlue;
                            if (binary1[binary1.Length - 1] == '0')
                            {
                                MessageLenght.Append('0');
                                z++;
                                if (z == 80)
                                {
                                    break;
                                }

                            }
                            else
                            {
                                MessageLenght.Append('1');
                                z++;
                                if (z == 80)
                                {
                                    break;
                                }

                            }
                            
                        }
                    }
                    count2 = MessageLenght.Length / 8;
                    FinalMessageLenght = MessageLenght.ToString();
                    var StringBytes2 = new byte[count2];
                    for (int i = 0; i < count2; i++)
                        StringBytes2[i] = Convert.ToByte(FinalMessageLenght.Substring(i * 8, 8), 2);
                    
                    FinalMessageLenght = enc.GetString(StringBytes2);
                    count3 = Convert.ToInt16(FinalMessageLenght);
                }


            }
            else
            {
                z = 2;
                y = 1;
                if (binary3[binary3.Length - 1] == '0')
                {
                    RetreivedMessage.Append('0');


                }
                else
                {
                    RetreivedMessage.Append('1');


                }
            }
            char[] Message = new char[c];
            c = 80 + (8 * count3);
            pixelColor = image4.GetPixel(0, y);
            binary1 = Convert.ToString(pixelColor.G, 2);
            
            if (binary1[binary1.Length - 1] == '0')
            {
                RetreivedMessage.Append('0');
                z++;

            }
            else
            {
                RetreivedMessage.Append('1');
                z++;
            }
            binary1 = Convert.ToString(pixelColor.B, 2);
            
            if (binary1[binary1.Length - 1] == '0')
            {
                RetreivedMessage.Append('0');
                z++;

            }
            else
            {
                RetreivedMessage.Append('1');
                z++;

            }
            
            for (y++, x = 0; x < image4.Width && z < (c); x++)
            {
                for (; y < image4.Height && z < (c); y++)
                {
                    pixelColor = image4.GetPixel(x, y);
                    binary1 = Convert.ToString(pixelColor.R, 2);
                    //byte NewRed, NewGreen, NewBlue;
                    if (binary1[binary1.Length - 1] == '0')
                    {
                        RetreivedMessage.Append('0');
                        z++;
                        if (z == (c))
                        {
                            break;
                        }

                    }
                    else
                    {
                        RetreivedMessage.Append('1');
                        z++;
                        if (z == (c))
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
                        if (z == (c))
                        {
                            break;
                        }

                    }
                    else
                    {
                        RetreivedMessage.Append('1');
                        z++;
                        if (z == (c))
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
                        if (z == (c))
                        {
                            break;
                        }

                    }
                    else
                    {
                        RetreivedMessage.Append('1');
                        z++;
                        if (z == (c))
                        {
                            break;
                        }

                    }
                   
                }
            }
            
            FinalRetreivedMessage = RetreivedMessage.ToString();
            count1 = FinalRetreivedMessage.Length / 8;
            var String1Bytes = new byte[count1];
            for (int i = 0; i < count1; i++)
                String1Bytes[i] = Convert.ToByte(FinalRetreivedMessage.Substring(i * 8, 8), 2);
            
            FinalResult = enc.GetString(String1Bytes);
            MessageRet = enc.GetString(String1Bytes);
            return MessageRet;

        }
    }
}
