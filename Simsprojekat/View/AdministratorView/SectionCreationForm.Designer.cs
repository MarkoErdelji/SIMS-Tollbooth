namespace Simsprojekat.View.AdministratorView
{
    partial class SectionCreationForm
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
            this.toLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.invalidInfoLabel = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(61, 35);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(25, 15);
            this.toLabel.TabIndex = 1;
            this.toLabel.Text = "To :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Distance :";
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(133, 32);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(100, 23);
            this.toTextBox.TabIndex = 4;
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Location = new System.Drawing.Point(133, 80);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(100, 23);
            this.distanceTextBox.TabIndex = 5;
            // 
            // invalidInfoLabel
            // 
            this.invalidInfoLabel.AutoSize = true;
            this.invalidInfoLabel.ForeColor = System.Drawing.Color.Crimson;
            this.invalidInfoLabel.Location = new System.Drawing.Point(63, 137);
            this.invalidInfoLabel.Name = "invalidInfoLabel";
            this.invalidInfoLabel.Size = new System.Drawing.Size(165, 15);
            this.invalidInfoLabel.TabIndex = 66;
            this.invalidInfoLabel.Text = "Entered information is invalid!";
            this.invalidInfoLabel.Visible = false;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(98, 166);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(92, 44);
            this.submitBtn.TabIndex = 65;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            // 
            // SectionCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 243);
            this.Controls.Add(this.invalidInfoLabel);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.distanceTextBox);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SectionCreationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SectionCreationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.Label invalidInfoLabel;
        private System.Windows.Forms.Button submitBtn;
    }
}