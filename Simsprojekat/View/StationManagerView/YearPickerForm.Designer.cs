namespace Simsprojekat.View.StationManagerView
{
    partial class YearPickerForm
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
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.createReportButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(104, 41);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(44, 23);
            this.yearTextBox.TabIndex = 0;
            // 
            // createReportButton
            // 
            this.createReportButton.Location = new System.Drawing.Point(67, 92);
            this.createReportButton.Name = "createReportButton";
            this.createReportButton.Size = new System.Drawing.Size(110, 23);
            this.createReportButton.TabIndex = 1;
            this.createReportButton.Text = "Create report";
            this.createReportButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Year: ";
            // 
            // YearPickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 145);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createReportButton);
            this.Controls.Add(this.yearTextBox);
            this.Name = "YearPickerForm";
            this.Text = "YearPickerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Button createReportButton;
        private System.Windows.Forms.Label label1;
    }
}