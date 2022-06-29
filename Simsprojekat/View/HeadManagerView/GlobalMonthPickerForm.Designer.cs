
namespace Simsprojekat.View.HeadManagerView
{
    partial class GlobalMonthPickerForm
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
            this.lblMonth = new System.Windows.Forms.Label();
            this.yearTxb = new System.Windows.Forms.TextBox();
            this.monthTxb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(105, 149);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(110, 31);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Create report";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(90, 103);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(40, 20);
            this.lblYear.TabIndex = 8;
            this.lblYear.Text = "Year:";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(74, 64);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(55, 20);
            this.lblMonth.TabIndex = 7;
            this.lblMonth.Text = "Month:";
            // 
            // yearTxb
            // 
            this.yearTxb.Location = new System.Drawing.Point(134, 92);
            this.yearTxb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yearTxb.Name = "yearTxb";
            this.yearTxb.Size = new System.Drawing.Size(55, 27);
            this.yearTxb.TabIndex = 6;
            // 
            // monthTxb
            // 
            this.monthTxb.Location = new System.Drawing.Point(134, 53);
            this.monthTxb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.monthTxb.Name = "monthTxb";
            this.monthTxb.Size = new System.Drawing.Size(55, 27);
            this.monthTxb.TabIndex = 5;
            // 
            // GlobalMonthPickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 215);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.yearTxb);
            this.Controls.Add(this.monthTxb);
            this.Name = "GlobalMonthPickerForm";
            this.Text = "GlobalMonthPickerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.TextBox yearTxb;
        private System.Windows.Forms.TextBox monthTxb;
    }
}