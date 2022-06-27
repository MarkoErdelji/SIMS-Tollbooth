namespace Simsprojekat.View.AdministratorView
{
    partial class CreationChoiceForm
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
            this.userTypeSelectionLabel = new System.Windows.Forms.Label();
            this.adminCreateBtn = new System.Windows.Forms.Button();
            this.headManagerCreateBtn = new System.Windows.Forms.Button();
            this.stationManagerCreateBtn = new System.Windows.Forms.Button();
            this.workerCreateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userTypeSelectionLabel
            // 
            this.userTypeSelectionLabel.AutoSize = true;
            this.userTypeSelectionLabel.Location = new System.Drawing.Point(210, 41);
            this.userTypeSelectionLabel.Name = "userTypeSelectionLabel";
            this.userTypeSelectionLabel.Size = new System.Drawing.Size(92, 15);
            this.userTypeSelectionLabel.TabIndex = 9;
            this.userTypeSelectionLabel.Text = "Select user type:";
            // 
            // adminCreateBtn
            // 
            this.adminCreateBtn.Location = new System.Drawing.Point(82, 102);
            this.adminCreateBtn.Name = "adminCreateBtn";
            this.adminCreateBtn.Size = new System.Drawing.Size(109, 50);
            this.adminCreateBtn.TabIndex = 8;
            this.adminCreateBtn.Text = "Administrator";
            this.adminCreateBtn.UseVisualStyleBackColor = true;
            this.adminCreateBtn.Click += new System.EventHandler(this.adminCreateBtn_Click);
            // 
            // headManagerCreateBtn
            // 
            this.headManagerCreateBtn.Location = new System.Drawing.Point(82, 192);
            this.headManagerCreateBtn.Name = "headManagerCreateBtn";
            this.headManagerCreateBtn.Size = new System.Drawing.Size(109, 50);
            this.headManagerCreateBtn.TabIndex = 7;
            this.headManagerCreateBtn.Text = "Head Manager";
            this.headManagerCreateBtn.UseVisualStyleBackColor = true;
            this.headManagerCreateBtn.Click += new System.EventHandler(this.headManagerCreateBtn_Click);
            // 
            // stationManagerCreateBtn
            // 
            this.stationManagerCreateBtn.Location = new System.Drawing.Point(324, 102);
            this.stationManagerCreateBtn.Name = "stationManagerCreateBtn";
            this.stationManagerCreateBtn.Size = new System.Drawing.Size(109, 50);
            this.stationManagerCreateBtn.TabIndex = 6;
            this.stationManagerCreateBtn.Text = "Station Manager";
            this.stationManagerCreateBtn.UseVisualStyleBackColor = true;
            this.stationManagerCreateBtn.Click += new System.EventHandler(this.stationManagerCreateBtn_Click);
            // 
            // workerCreateBtn
            // 
            this.workerCreateBtn.Location = new System.Drawing.Point(324, 192);
            this.workerCreateBtn.Name = "workerCreateBtn";
            this.workerCreateBtn.Size = new System.Drawing.Size(109, 50);
            this.workerCreateBtn.TabIndex = 5;
            this.workerCreateBtn.Text = "Worker";
            this.workerCreateBtn.UseVisualStyleBackColor = true;
            this.workerCreateBtn.Click += new System.EventHandler(this.workerCreateBtn_Click);
            // 
            // CreationChoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 314);
            this.Controls.Add(this.userTypeSelectionLabel);
            this.Controls.Add(this.adminCreateBtn);
            this.Controls.Add(this.headManagerCreateBtn);
            this.Controls.Add(this.stationManagerCreateBtn);
            this.Controls.Add(this.workerCreateBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreationChoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreationChoiceForm";
            this.Load += new System.EventHandler(this.CreationChoiceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userTypeSelectionLabel;
        private System.Windows.Forms.Button adminCreateBtn;
        private System.Windows.Forms.Button headManagerCreateBtn;
        private System.Windows.Forms.Button stationManagerCreateBtn;
        private System.Windows.Forms.Button workerCreateBtn;
    }
}