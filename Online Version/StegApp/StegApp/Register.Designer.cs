namespace WindowsFormsApplication4
{
    partial class Register
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
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Town = new System.Windows.Forms.Label();
            this.County = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.Label();
            this.CountyTextBox = new System.Windows.Forms.TextBox();
            this.TownTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox3 = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.Peru;
            this.Username.Location = new System.Drawing.Point(15, 126);
            this.Username.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(97, 24);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Peru;
            this.Password.Location = new System.Drawing.Point(15, 180);
            this.Password.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(92, 24);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            // 
            // Town
            // 
            this.Town.AutoSize = true;
            this.Town.BackColor = System.Drawing.Color.Peru;
            this.Town.Location = new System.Drawing.Point(385, 131);
            this.Town.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Town.Name = "Town";
            this.Town.Size = new System.Drawing.Size(58, 24);
            this.Town.TabIndex = 2;
            this.Town.Text = "Town";
            // 
            // County
            // 
            this.County.AutoSize = true;
            this.County.BackColor = System.Drawing.Color.Peru;
            this.County.Location = new System.Drawing.Point(385, 180);
            this.County.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.County.Name = "County";
            this.County.Size = new System.Drawing.Size(69, 24);
            this.County.TabIndex = 3;
            this.County.Text = "County";
            this.County.Click += new System.EventHandler(this.label4_Click);
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.BackColor = System.Drawing.Color.Peru;
            this.LastName.Location = new System.Drawing.Point(15, 288);
            this.LastName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(94, 24);
            this.LastName.TabIndex = 4;
            this.LastName.Text = "LastName";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.BackColor = System.Drawing.Color.Peru;
            this.FirstName.Location = new System.Drawing.Point(15, 239);
            this.FirstName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(96, 24);
            this.FirstName.TabIndex = 5;
            this.FirstName.Text = "FirstName";
            this.FirstName.Click += new System.EventHandler(this.label6_Click);
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.BackColor = System.Drawing.Color.Peru;
            this.Country.Location = new System.Drawing.Point(385, 236);
            this.Country.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(75, 24);
            this.Country.TabIndex = 6;
            this.Country.Text = "Country";
            // 
            // CountyTextBox
            // 
            this.CountyTextBox.Location = new System.Drawing.Point(574, 177);
            this.CountyTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.CountyTextBox.Name = "CountyTextBox";
            this.CountyTextBox.Size = new System.Drawing.Size(180, 29);
            this.CountyTextBox.TabIndex = 7;
            // 
            // TownTextBox
            // 
            this.TownTextBox.Location = new System.Drawing.Point(574, 131);
            this.TownTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.TownTextBox.Name = "TownTextBox";
            this.TownTextBox.Size = new System.Drawing.Size(180, 29);
            this.TownTextBox.TabIndex = 8;
            this.TownTextBox.TextChanged += new System.EventHandler(this.TownTextBox_TextChanged);
            // 
            // PasswordTextBox3
            // 
            this.PasswordTextBox3.Location = new System.Drawing.Point(115, 180);
            this.PasswordTextBox3.Margin = new System.Windows.Forms.Padding(6);
            this.PasswordTextBox3.Name = "PasswordTextBox3";
            this.PasswordTextBox3.Size = new System.Drawing.Size(180, 29);
            this.PasswordTextBox3.TabIndex = 9;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(115, 126);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(180, 29);
            this.UsernameTextBox.TabIndex = 10;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(115, 288);
            this.LastNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(180, 29);
            this.LastNameTextBox.TabIndex = 11;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(115, 239);
            this.FirstNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(180, 29);
            this.FirstNameTextBox.TabIndex = 12;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(573, 239);
            this.CountryTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(180, 29);
            this.CountryTextBox.TabIndex = 13;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(573, 288);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(6);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(138, 29);
            this.RegisterButton.TabIndex = 14;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(19, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(735, 105);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(778, 330);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.CountryTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.PasswordTextBox3);
            this.Controls.Add(this.TownTextBox);
            this.Controls.Add(this.CountyTextBox);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.County);
            this.Controls.Add(this.Town);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Register";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Town;
        private System.Windows.Forms.Label County;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.TextBox CountyTextBox;
        private System.Windows.Forms.TextBox TownTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox3;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}