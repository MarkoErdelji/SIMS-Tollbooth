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
            this.lblRamp = new System.Windows.Forms.Label();
            this.lblCamera = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rampRaiseBtn
            // 
            this.rampRaiseBtn.BackColor = System.Drawing.Color.Green;
            this.rampRaiseBtn.Enabled = false;
            this.rampRaiseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rampRaiseBtn.ForeColor = System.Drawing.Color.Black;
            this.rampRaiseBtn.Location = new System.Drawing.Point(834, 191);
            this.rampRaiseBtn.Name = "rampRaiseBtn";
            this.rampRaiseBtn.Size = new System.Drawing.Size(124, 123);
            this.rampRaiseBtn.TabIndex = 1;
            this.rampRaiseBtn.Text = "Ramp is lowered.";
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
            this.ClientSize = new System.Drawing.Size(1064, 432);
            this.Controls.Add(this.lblCamera);
            this.Controls.Add(this.lblRamp);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.tollBoothLabel);
            this.Controls.Add(this.ticketIdLabel);
            this.Controls.Add(this.tbTicket);
            this.Controls.Add(this.submitTicketBtn);
            this.Controls.Add(this.rampRaiseBtn);
            this.Name = "WorkerForm";
            this.Text = "Worker";
            this.Load += new System.EventHandler(this.WorkerForm_Load);
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
        private System.Windows.Forms.Label lblRamp;
        private System.Windows.Forms.Label lblCamera;
    }
}