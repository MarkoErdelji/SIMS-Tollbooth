namespace Simsprojekat.View
{
    partial class WorkerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerForm));
            this.rampRaiseBtn = new Simsprojekat.View.RoundButton();
            this.submitTicketBtn = new System.Windows.Forms.Button();
            this.tbTicket = new System.Windows.Forms.TextBox();
            this.ticketIdLabel = new System.Windows.Forms.Label();
            this.tollBoothLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundRadioButton1 = new Simsprojekat.View.BackgroundRadioButton();
            this.backgroundRadioButton2 = new Simsprojekat.View.BackgroundRadioButton();
            this.backgroundRadioButton3 = new Simsprojekat.View.BackgroundRadioButton();
            this.backgroundRadioButton4 = new Simsprojekat.View.BackgroundRadioButton();
            this.backgroundRadioButton5 = new Simsprojekat.View.BackgroundRadioButton();
            this.vehicleRadioGroup = new System.Windows.Forms.GroupBox();
            this.lblRamp = new System.Windows.Forms.Label();
            this.lblCamera = new System.Windows.Forms.Label();
            this.vehicleRadioGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // rampRaiseBtn
            // 
            this.rampRaiseBtn.BackColor = System.Drawing.Color.Green;
            this.rampRaiseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rampRaiseBtn.ForeColor = System.Drawing.Color.Black;
            this.rampRaiseBtn.Location = new System.Drawing.Point(824, 238);
            this.rampRaiseBtn.Name = "rampRaiseBtn";
            this.rampRaiseBtn.Size = new System.Drawing.Size(124, 123);
            this.rampRaiseBtn.TabIndex = 1;
            this.rampRaiseBtn.Text = "Raise ramp";
            this.rampRaiseBtn.UseVisualStyleBackColor = false;
            this.rampRaiseBtn.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // submitTicketBtn
            // 
            this.submitTicketBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("submitTicketBtn.BackgroundImage")));
            this.submitTicketBtn.Location = new System.Drawing.Point(605, 284);
            this.submitTicketBtn.Name = "submitTicketBtn";
            this.submitTicketBtn.Size = new System.Drawing.Size(31, 30);
            this.submitTicketBtn.TabIndex = 2;
            this.submitTicketBtn.UseVisualStyleBackColor = true;
            this.submitTicketBtn.Click += new System.EventHandler(this.submitTicketBtn_Click);
            // 
            // tbTicket
            // 
            this.tbTicket.Location = new System.Drawing.Point(383, 287);
            this.tbTicket.Name = "tbTicket";
            this.tbTicket.Size = new System.Drawing.Size(216, 23);
            this.tbTicket.TabIndex = 3;
            // 
            // ticketIdLabel
            // 
            this.ticketIdLabel.AutoSize = true;
            this.ticketIdLabel.Location = new System.Drawing.Point(292, 292);
            this.ticketIdLabel.Name = "ticketIdLabel";
            this.ticketIdLabel.Size = new System.Drawing.Size(85, 15);
            this.ticketIdLabel.TabIndex = 4;
            this.ticketIdLabel.Text = "Enter ticket id :";
            // 
            // tollBoothLabel
            // 
            this.tollBoothLabel.AutoSize = true;
            this.tollBoothLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tollBoothLabel.Location = new System.Drawing.Point(417, 9);
            this.tollBoothLabel.Name = "tollBoothLabel";
            this.tollBoothLabel.Size = new System.Drawing.Size(182, 45);
            this.tollBoothLabel.TabIndex = 5;
            this.tollBoothLabel.Text = "TollBooth #";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.Location = new System.Drawing.Point(388, 87);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(134, 37);
            this.welcomeLabel.TabIndex = 6;
            this.welcomeLabel.Text = "Welcome ";
            this.welcomeLabel.Click += new System.EventHandler(this.welcomeLabel_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(905, 40);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(124, 32);
            this.logoutButton.TabIndex = 11;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select the vehicle type :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // backgroundRadioButton1
            // 
            this.backgroundRadioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.backgroundRadioButton1.AutoCheck = false;
            this.backgroundRadioButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backgroundRadioButton1.BackgroundImage")));
            this.backgroundRadioButton1.Location = new System.Drawing.Point(155, 22);
            this.backgroundRadioButton1.Name = "backgroundRadioButton1";
            this.backgroundRadioButton1.Size = new System.Drawing.Size(48, 48);
            this.backgroundRadioButton1.TabIndex = 7;
            this.backgroundRadioButton1.UseVisualStyleBackColor = true;
            // 
            // backgroundRadioButton2
            // 
            this.backgroundRadioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.backgroundRadioButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backgroundRadioButton2.BackgroundImage")));
            this.backgroundRadioButton2.Checked = true;
            this.backgroundRadioButton2.Location = new System.Drawing.Point(22, 22);
            this.backgroundRadioButton2.Name = "backgroundRadioButton2";
            this.backgroundRadioButton2.Size = new System.Drawing.Size(48, 48);
            this.backgroundRadioButton2.TabIndex = 9;
            this.backgroundRadioButton2.TabStop = true;
            this.backgroundRadioButton2.UseVisualStyleBackColor = true;
            // 
            // backgroundRadioButton3
            // 
            this.backgroundRadioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.backgroundRadioButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backgroundRadioButton3.BackgroundImage")));
            this.backgroundRadioButton3.Location = new System.Drawing.Point(279, 22);
            this.backgroundRadioButton3.Name = "backgroundRadioButton3";
            this.backgroundRadioButton3.Size = new System.Drawing.Size(48, 48);
            this.backgroundRadioButton3.TabIndex = 10;
            this.backgroundRadioButton3.UseVisualStyleBackColor = true;
            this.backgroundRadioButton3.CheckedChanged += new System.EventHandler(this.backgroundRadioButton3_CheckedChanged);
            // 
            // backgroundRadioButton4
            // 
            this.backgroundRadioButton4.Appearance = System.Windows.Forms.Appearance.Button;
            this.backgroundRadioButton4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.backgroundRadioButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backgroundRadioButton4.BackgroundImage")));
            this.backgroundRadioButton4.Location = new System.Drawing.Point(410, 23);
            this.backgroundRadioButton4.Name = "backgroundRadioButton4";
            this.backgroundRadioButton4.Size = new System.Drawing.Size(48, 48);
            this.backgroundRadioButton4.TabIndex = 11;
            this.backgroundRadioButton4.UseVisualStyleBackColor = false;
            // 
            // backgroundRadioButton5
            // 
            this.backgroundRadioButton5.Appearance = System.Windows.Forms.Appearance.Button;
            this.backgroundRadioButton5.BackgroundImage = global::Simsprojekat.Properties.Resources.icons8_question_mark_48;
            this.backgroundRadioButton5.Location = new System.Drawing.Point(528, 23);
            this.backgroundRadioButton5.Name = "backgroundRadioButton5";
            this.backgroundRadioButton5.Size = new System.Drawing.Size(48, 48);
            this.backgroundRadioButton5.TabIndex = 12;
            this.backgroundRadioButton5.UseVisualStyleBackColor = true;
            // 
            // vehicleRadioGroup
            // 
            this.vehicleRadioGroup.Controls.Add(this.backgroundRadioButton5);
            this.vehicleRadioGroup.Controls.Add(this.backgroundRadioButton4);
            this.vehicleRadioGroup.Controls.Add(this.backgroundRadioButton3);
            this.vehicleRadioGroup.Controls.Add(this.backgroundRadioButton2);
            this.vehicleRadioGroup.Controls.Add(this.backgroundRadioButton1);
            this.vehicleRadioGroup.Location = new System.Drawing.Point(195, 431);
            this.vehicleRadioGroup.Name = "vehicleRadioGroup";
            this.vehicleRadioGroup.Size = new System.Drawing.Size(596, 99);
            this.vehicleRadioGroup.TabIndex = 10;
            this.vehicleRadioGroup.TabStop = false;
            // 
            // lblRamp
            // 
            this.lblRamp.AutoSize = true;
            this.lblRamp.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRamp.Location = new System.Drawing.Point(20, 149);
            this.lblRamp.Name = "lblRamp";
            this.lblRamp.Size = new System.Drawing.Size(67, 30);
            this.lblRamp.TabIndex = 12;
            this.lblRamp.Text = "Ramp";
            // 
            // lblCamera
            // 
            this.lblCamera.AutoSize = true;
            this.lblCamera.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCamera.Location = new System.Drawing.Point(20, 201);
            this.lblCamera.Name = "lblCamera";
            this.lblCamera.Size = new System.Drawing.Size(84, 30);
            this.lblCamera.TabIndex = 13;
            this.lblCamera.Text = "Camera";
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 601);
            this.Controls.Add(this.lblCamera);
            this.Controls.Add(this.lblRamp);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.vehicleRadioGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.tollBoothLabel);
            this.Controls.Add(this.ticketIdLabel);
            this.Controls.Add(this.tbTicket);
            this.Controls.Add(this.submitTicketBtn);
            this.Controls.Add(this.rampRaiseBtn);
            this.Name = "WorkerForm";
            this.Text = "Worker";
            this.Load += new System.EventHandler(this.WorkerForm_Load);
            this.vehicleRadioGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RoundButton rampRaiseBtn;
        private System.Windows.Forms.Button submitTicketBtn;
        private System.Windows.Forms.TextBox tbTicket;
        private System.Windows.Forms.Label ticketIdLabel;
        private System.Windows.Forms.Label tollBoothLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label label1;
        private BackgroundRadioButton backgroundRadioButton1;
        private BackgroundRadioButton backgroundRadioButton2;
        private BackgroundRadioButton backgroundRadioButton3;
        private BackgroundRadioButton backgroundRadioButton4;
        private BackgroundRadioButton backgroundRadioButton5;
        private System.Windows.Forms.GroupBox vehicleRadioGroup;
        private System.Windows.Forms.Label lblRamp;
        private System.Windows.Forms.Label lblCamera;
    }
}