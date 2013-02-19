namespace WindowsFormsApplication4
{
    partial class StegApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.stegAppBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.davidFlynnDatabaseDataSet = new WindowsFormsApplication4.DavidFlynnDatabaseDataSet();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.stegAppTableAdapter = new WindowsFormsApplication4.DavidFlynnDatabaseDataSetTableAdapters.StegAppTableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApplication4.DavidFlynnDatabaseDataSetTableAdapters.TableAdapterManager();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SendMessage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.EmbedMessage = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PasswordtextBox1 = new System.Windows.Forms.TextBox();
            this.Passwordlabel2 = new System.Windows.Forms.Label();
            this.ImageNametextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EndUserId = new System.Windows.Forms.Label();
            this.SaveImage = new System.Windows.Forms.Button();
            this.SaveImageAndKey = new System.Windows.Forms.Button();
            this.EndUsertextBox1 = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.UserId = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RetreiveImage = new System.Windows.Forms.Button();
            this.RetreiveKey = new System.Windows.Forms.Button();
            this.Passwlabel2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DisplayLogs = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.UserNtextBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stegAppBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.stegAppBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.davidFlynnDatabaseDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SendMessage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stegAppBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // stegAppBindingSource
            // 
            this.stegAppBindingSource.DataMember = "StegApp";
            this.stegAppBindingSource.DataSource = this.davidFlynnDatabaseDataSet;
            // 
            // davidFlynnDatabaseDataSet
            // 
            this.davidFlynnDatabaseDataSet.DataSetName = "DavidFlynnDatabaseDataSet";
            this.davidFlynnDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // stegAppTableAdapter
            // 
            this.stegAppTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.MyFirstTableTableAdapter = null;
            this.tableAdapterManager1.StegAppTableAdapter = this.stegAppTableAdapter;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApplication4.DavidFlynnDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SendMessage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1206, 706);
            this.tabControl1.TabIndex = 26;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // SendMessage
            // 
            this.SendMessage.BackColor = System.Drawing.Color.Tan;
            this.SendMessage.Controls.Add(this.groupBox3);
            this.SendMessage.Controls.Add(this.groupBox2);
            this.SendMessage.Controls.Add(this.button5);
            this.SendMessage.Controls.Add(this.pictureBox1);
            this.SendMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendMessage.Location = new System.Drawing.Point(4, 33);
            this.SendMessage.Name = "SendMessage";
            this.SendMessage.Padding = new System.Windows.Forms.Padding(3);
            this.SendMessage.Size = new System.Drawing.Size(1198, 669);
            this.SendMessage.TabIndex = 0;
            this.SendMessage.Text = "Send Message";
            this.SendMessage.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnSelectFile);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.EmbedMessage);
            this.groupBox3.Location = new System.Drawing.Point(8, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(693, 365);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(619, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Select below from Dropbox which Categorey of Database Photo";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(6, 19);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(454, 32);
            this.btnSelectFile.TabIndex = 8;
            this.btnSelectFile.Text = "Select File to store Message From Computer";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Animals",
            "Earth",
            "Sea",
            "Sky"});
            this.comboBox1.Location = new System.Drawing.Point(8, 123);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(8, 181);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(356, 32);
            this.button6.TabIndex = 28;
            this.button6.Text = "Get Image from Database";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // EmbedMessage
            // 
            this.EmbedMessage.Location = new System.Drawing.Point(8, 265);
            this.EmbedMessage.Name = "EmbedMessage";
            this.EmbedMessage.Size = new System.Drawing.Size(367, 54);
            this.EmbedMessage.TabIndex = 10;
            this.EmbedMessage.Text = "Embed Message in Selected Image";
            this.EmbedMessage.UseVisualStyleBackColor = true;
            this.EmbedMessage.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(8, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(693, 72);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // textBox5
            // 
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox5.Location = new System.Drawing.Point(180, 27);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(169, 31);
            this.textBox5.TabIndex = 16;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(3, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Message to send";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(517, 30);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(162, 31);
            this.textBox4.TabIndex = 15;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Key to send";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(8, 566);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(452, 40);
            this.button5.TabIndex = 25;
            this.button5.Text = "Save image for Transport , e.g email etc.";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Tan;
            this.pictureBox1.Location = new System.Drawing.Point(747, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 452);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Tan;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1198, 669);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Save Image/Key in Database";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox1.Controls.Add(this.PasswordtextBox1);
            this.groupBox1.Controls.Add(this.Passwordlabel2);
            this.groupBox1.Controls.Add(this.ImageNametextBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.EndUserId);
            this.groupBox1.Controls.Add(this.SaveImage);
            this.groupBox1.Controls.Add(this.SaveImageAndKey);
            this.groupBox1.Controls.Add(this.EndUsertextBox1);
            this.groupBox1.Controls.Add(this.UsernameTextBox);
            this.groupBox1.Controls.Add(this.UserId);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(32, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1135, 489);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // PasswordtextBox1
            // 
            this.PasswordtextBox1.Location = new System.Drawing.Point(385, 200);
            this.PasswordtextBox1.Name = "PasswordtextBox1";
            this.PasswordtextBox1.Size = new System.Drawing.Size(228, 31);
            this.PasswordtextBox1.TabIndex = 32;
            // 
            // Passwordlabel2
            // 
            this.Passwordlabel2.AutoSize = true;
            this.Passwordlabel2.Location = new System.Drawing.Point(27, 200);
            this.Passwordlabel2.Name = "Passwordlabel2";
            this.Passwordlabel2.Size = new System.Drawing.Size(279, 25);
            this.Passwordlabel2.TabIndex = 31;
            this.Passwordlabel2.Text = "Please enter your password";
            // 
            // ImageNametextBox1
            // 
            this.ImageNametextBox1.Location = new System.Drawing.Point(748, 270);
            this.ImageNametextBox1.Name = "ImageNametextBox1";
            this.ImageNametextBox1.Size = new System.Drawing.Size(231, 31);
            this.ImageNametextBox1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Please enter name of Image for Database storage";
            // 
            // EndUserId
            // 
            this.EndUserId.AutoSize = true;
            this.EndUserId.Location = new System.Drawing.Point(27, 27);
            this.EndUserId.Name = "EndUserId";
            this.EndUserId.Size = new System.Drawing.Size(321, 25);
            this.EndUserId.TabIndex = 11;
            this.EndUserId.Text = "Please enter UserId of Recipient";
            // 
            // SaveImage
            // 
            this.SaveImage.Location = new System.Drawing.Point(385, 354);
            this.SaveImage.Name = "SaveImage";
            this.SaveImage.Size = new System.Drawing.Size(273, 62);
            this.SaveImage.TabIndex = 28;
            this.SaveImage.Text = "Save Image only in Database";
            this.SaveImage.UseVisualStyleBackColor = true;
            this.SaveImage.Click += new System.EventHandler(this.SaveImage_Click);
            // 
            // SaveImageAndKey
            // 
            this.SaveImageAndKey.Location = new System.Drawing.Point(748, 354);
            this.SaveImageAndKey.Name = "SaveImageAndKey";
            this.SaveImageAndKey.Size = new System.Drawing.Size(300, 62);
            this.SaveImageAndKey.TabIndex = 27;
            this.SaveImageAndKey.Text = "Save Both Key and  Image in Database";
            this.SaveImageAndKey.UseVisualStyleBackColor = true;
            this.SaveImageAndKey.Click += new System.EventHandler(this.SaveImageAndKey_Click);
            // 
            // EndUsertextBox1
            // 
            this.EndUsertextBox1.Location = new System.Drawing.Point(385, 27);
            this.EndUsertextBox1.Name = "EndUsertextBox1";
            this.EndUsertextBox1.Size = new System.Drawing.Size(228, 31);
            this.EndUsertextBox1.TabIndex = 10;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(385, 109);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(228, 31);
            this.UsernameTextBox.TabIndex = 27;
            // 
            // UserId
            // 
            this.UserId.AutoSize = true;
            this.UserId.Location = new System.Drawing.Point(27, 109);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(285, 25);
            this.UserId.TabIndex = 26;
            this.UserId.Text = "Please enter your Username";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 60);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save Key only in Database";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Tan;
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1198, 669);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Receive Message";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.RetreiveImage);
            this.groupBox4.Controls.Add(this.RetreiveKey);
            this.groupBox4.Controls.Add(this.Passwlabel2);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.DisplayLogs);
            this.groupBox4.Controls.Add(this.Username);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.UserNtextBox);
            this.groupBox4.Location = new System.Drawing.Point(6, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1132, 239);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Tan;
            this.label3.Location = new System.Drawing.Point(34, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(510, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "Remember to take note of key when Message Box appears.";
            // 
            // RetreiveImage
            // 
            this.RetreiveImage.Location = new System.Drawing.Point(794, 141);
            this.RetreiveImage.Name = "RetreiveImage";
            this.RetreiveImage.Size = new System.Drawing.Size(325, 65);
            this.RetreiveImage.TabIndex = 31;
            this.RetreiveImage.Text = "Retreive log(which might contain Key) and Image only from Database";
            this.RetreiveImage.UseVisualStyleBackColor = true;
            this.RetreiveImage.Click += new System.EventHandler(this.RetreiveImage_Click);
            // 
            // RetreiveKey
            // 
            this.RetreiveKey.Location = new System.Drawing.Point(419, 141);
            this.RetreiveKey.Name = "RetreiveKey";
            this.RetreiveKey.Size = new System.Drawing.Size(340, 65);
            this.RetreiveKey.TabIndex = 25;
            this.RetreiveKey.Text = "Retreive log(which might contain Key) from Database";
            this.RetreiveKey.UseVisualStyleBackColor = true;
            this.RetreiveKey.Click += new System.EventHandler(this.RetreiveKey_Click);
            // 
            // Passwlabel2
            // 
            this.Passwlabel2.AutoSize = true;
            this.Passwlabel2.Location = new System.Drawing.Point(568, 84);
            this.Passwlabel2.Name = "Passwlabel2";
            this.Passwlabel2.Size = new System.Drawing.Size(244, 24);
            this.Passwlabel2.TabIndex = 29;
            this.Passwlabel2.Text = "Please enter your Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(925, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 29);
            this.textBox1.TabIndex = 30;
            // 
            // DisplayLogs
            // 
            this.DisplayLogs.AutoSize = true;
            this.DisplayLogs.BackColor = System.Drawing.Color.Tan;
            this.DisplayLogs.Location = new System.Drawing.Point(34, 18);
            this.DisplayLogs.Name = "DisplayLogs";
            this.DisplayLogs.Size = new System.Drawing.Size(995, 24);
            this.DisplayLogs.TabIndex = 26;
            this.DisplayLogs.Text = "You input/or retreive your key and/or picture from Database. Also one can load th" +
    "eir image directly from your Hardrive. ";
            this.DisplayLogs.Click += new System.EventHandler(this.label1_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(34, 87);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(249, 24);
            this.Username.TabIndex = 28;
            this.Username.Text = "Please enter your Username";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(38, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(355, 68);
            this.button3.TabIndex = 23;
            this.button3.Text = "Select file From Computer containing Message";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // UserNtextBox
            // 
            this.UserNtextBox.Location = new System.Drawing.Point(365, 84);
            this.UserNtextBox.Name = "UserNtextBox";
            this.UserNtextBox.Size = new System.Drawing.Size(167, 29);
            this.UserNtextBox.TabIndex = 27;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox5.Controls.Add(this.textBox7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(6, 427);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(551, 100);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(341, 35);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(139, 29);
            this.textBox7.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(266, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Enter Key to retreive message:";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox6.Controls.Add(this.button4);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.textBox6);
            this.groupBox6.Location = new System.Drawing.Point(6, 559);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1171, 89);
            this.groupBox6.TabIndex = 32;
            this.groupBox6.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 66);
            this.button4.TabIndex = 24;
            this.button4.Text = "Retrieve Message";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "Retreived Message :";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(394, 41);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(754, 29);
            this.textBox6.TabIndex = 17;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Tan;
            this.pictureBox2.Location = new System.Drawing.Point(647, 281);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(491, 246);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataMember = "Event";
            // 
            // logBindingSource
            // 
            this.logBindingSource.DataSource = typeof(WindowsFormsApplication4.DataAccess.DataModel.Log);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(WindowsFormsApplication4.DataAccess.DataModel.User);
            // 
            // stegAppBindingSource1
            // 
            this.stegAppBindingSource1.DataSource = typeof(WindowsFormsApplication4.StegApp);
            // 
            // StegApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(1234, 786);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StegApp";
            this.Text = "StegApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stegAppBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.davidFlynnDatabaseDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.SendMessage.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stegAppBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource eventBindingSource;
        //private Database1DataSetTableAdapters.EventTableAdapter eventTableAdapter;
        //private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DavidFlynnDatabaseDataSet davidFlynnDatabaseDataSet;
        private System.Windows.Forms.BindingSource stegAppBindingSource;
        private DavidFlynnDatabaseDataSetTableAdapters.StegAppTableAdapter stegAppTableAdapter;
        private DavidFlynnDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource stegAppBindingSource1;
        private System.Windows.Forms.BindingSource logBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox UserNtextBox;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label DisplayLogs;
        private System.Windows.Forms.Button RetreiveKey;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage SendMessage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SaveImage;
        private System.Windows.Forms.Button SaveImageAndKey;
        private System.Windows.Forms.TextBox EndUsertextBox1;
        private System.Windows.Forms.Label EndUserId;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label UserId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button EmbedMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox ImageNametextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordtextBox1;
        private System.Windows.Forms.Label Passwordlabel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button RetreiveImage;
        private System.Windows.Forms.Label Passwlabel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

