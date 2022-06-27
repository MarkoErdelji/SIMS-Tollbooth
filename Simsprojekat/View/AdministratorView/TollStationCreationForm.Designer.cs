namespace Simsprojekat.View.AdministratorView
{
    partial class TollStationCreationForm
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
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.invalidInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Location = new System.Drawing.Point(156, 112);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(150, 23);
            this.zipCodeTextBox.TabIndex = 22;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(156, 68);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(150, 23);
            this.cityTextBox.TabIndex = 21;
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(60, 115);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(61, 15);
            this.zipCodeLabel.TabIndex = 20;
            this.zipCodeLabel.Text = "Zip Code :";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(60, 71);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(34, 15);
            this.cityLabel.TabIndex = 19;
            this.cityLabel.Text = "City :";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(134, 187);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(92, 44);
            this.submitBtn.TabIndex = 23;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // invalidInfoLabel
            // 
            this.invalidInfoLabel.AutoSize = true;
            this.invalidInfoLabel.ForeColor = System.Drawing.Color.Crimson;
            this.invalidInfoLabel.Location = new System.Drawing.Point(100, 154);
            this.invalidInfoLabel.Name = "invalidInfoLabel";
            this.invalidInfoLabel.Size = new System.Drawing.Size(165, 15);
            this.invalidInfoLabel.TabIndex = 65;
            this.invalidInfoLabel.Text = "Entered information is invalid!";
            this.invalidInfoLabel.Visible = false;
            // 
            // TollStationCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 243);
            this.Controls.Add(this.invalidInfoLabel);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.zipCodeLabel);
            this.Controls.Add(this.cityLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TollStationCreationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TollStationCreationForm";
            this.Load += new System.EventHandler(this.TollStationCreationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label invalidInfoLabel;
    }
}