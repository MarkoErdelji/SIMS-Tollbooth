
namespace Simsprojekat.View.HeadManagerView
{
    partial class GlobalYearPickerForm
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblYear = new System.Windows.Forms.Label();
            this.yearTxb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(77, 123);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(126, 31);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create report";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(72, 65);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(40, 20);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "Year:";
            // 
            // yearTxb
            // 
            this.yearTxb.Location = new System.Drawing.Point(119, 55);
            this.yearTxb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yearTxb.Name = "yearTxb";
            this.yearTxb.Size = new System.Drawing.Size(50, 27);
            this.yearTxb.TabIndex = 2;
            // 
            // GlobalYearPickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 193);
            this.Controls.Add(this.yearTxb);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.btnCreate);
            this.Name = "GlobalYearPickerForm";
            this.Text = "GlobalYearPickerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox yearTxb;
    }
}