namespace Simsprojekat.View.AdministratorView
{
    partial class UserCreationForm
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
            this.submitBtn = new System.Windows.Forms.Button();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.streetNameLabel = new System.Windows.Forms.Label();
            this.streetNumberLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.streetNameTextBox = new System.Windows.Forms.TextBox();
            this.streetNumberTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(146, 449);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(92, 44);
            this.submitBtn.TabIndex = 0;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(65, 37);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(67, 15);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "FirstName :";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(65, 78);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(69, 15);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name :";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(65, 119);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(66, 15);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Username :";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(65, 161);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(63, 15);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password :";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(65, 205);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(42, 15);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "Email :";
            this.emailLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // streetNameLabel
            // 
            this.streetNameLabel.AutoSize = true;
            this.streetNameLabel.Location = new System.Drawing.Point(65, 248);
            this.streetNameLabel.Name = "streetNameLabel";
            this.streetNameLabel.Size = new System.Drawing.Size(78, 15);
            this.streetNameLabel.TabIndex = 6;
            this.streetNameLabel.Text = "Street Name :";
            // 
            // streetNumberLabel
            // 
            this.streetNumberLabel.AutoSize = true;
            this.streetNumberLabel.Location = new System.Drawing.Point(65, 295);
            this.streetNumberLabel.Name = "streetNumberLabel";
            this.streetNumberLabel.Size = new System.Drawing.Size(90, 15);
            this.streetNumberLabel.TabIndex = 7;
            this.streetNumberLabel.Text = "Street Number :";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(65, 339);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(34, 15);
            this.cityLabel.TabIndex = 8;
            this.cityLabel.Text = "City :";
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(65, 383);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(61, 15);
            this.zipCodeLabel.TabIndex = 9;
            this.zipCodeLabel.Text = "Zip Code :";
            this.zipCodeLabel.Click += new System.EventHandler(this.label9_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(161, 37);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(150, 23);
            this.firstNameTextBox.TabIndex = 10;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(161, 75);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(150, 23);
            this.lastNameTextBox.TabIndex = 11;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(161, 116);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(150, 23);
            this.usernameTextBox.TabIndex = 12;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(161, 158);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(150, 23);
            this.passwordTextBox.TabIndex = 13;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(161, 202);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(150, 23);
            this.emailTextBox.TabIndex = 14;
            // 
            // streetNameTextBox
            // 
            this.streetNameTextBox.Location = new System.Drawing.Point(161, 245);
            this.streetNameTextBox.Name = "streetNameTextBox";
            this.streetNameTextBox.Size = new System.Drawing.Size(150, 23);
            this.streetNameTextBox.TabIndex = 15;
            // 
            // streetNumberTextBox
            // 
            this.streetNumberTextBox.Location = new System.Drawing.Point(161, 292);
            this.streetNumberTextBox.Name = "streetNumberTextBox";
            this.streetNumberTextBox.Size = new System.Drawing.Size(150, 23);
            this.streetNumberTextBox.TabIndex = 16;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(161, 336);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(150, 23);
            this.cityTextBox.TabIndex = 17;
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Location = new System.Drawing.Point(161, 380);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(150, 23);
            this.zipCodeTextBox.TabIndex = 18;
            // 
            // UserCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 549);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.streetNumberTextBox);
            this.Controls.Add(this.streetNameTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.zipCodeLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.streetNumberLabel);
            this.Controls.Add(this.streetNameLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.submitBtn);
            this.Name = "UserCreationForm";
            this.Text = "UserCreationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label streetNameLabel;
        private System.Windows.Forms.Label streetNumberLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox streetNameTextBox;
        private System.Windows.Forms.TextBox streetNumberTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
    }
}