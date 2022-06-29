
namespace Simsprojekat.View.HeadManagerView
{
    partial class SectionHeadManagerForm
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
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblTollStationName = new System.Windows.Forms.Label();
            this.dgwSection = new System.Windows.Forms.DataGridView();
            this.tollBoothId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionExit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSection)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(342, 61);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(73, 20);
            this.lblLocation.TabIndex = 12;
            this.lblLocation.Text = "Location :";
            // 
            // lblTollStationName
            // 
            this.lblTollStationName.AutoSize = true;
            this.lblTollStationName.Location = new System.Drawing.Point(362, 28);
            this.lblTollStationName.Name = "lblTollStationName";
            this.lblTollStationName.Size = new System.Drawing.Size(97, 20);
            this.lblTollStationName.TabIndex = 11;
            this.lblTollStationName.Text = "Toll Station #";
            // 
            // dgwSection
            // 
            this.dgwSection.AllowUserToAddRows = false;
            this.dgwSection.AllowUserToDeleteRows = false;
            this.dgwSection.AllowUserToResizeColumns = false;
            this.dgwSection.AllowUserToResizeRows = false;
            this.dgwSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tollBoothId,
            this.sectionExit,
            this.sectionDistance});
            this.dgwSection.Location = new System.Drawing.Point(157, 107);
            this.dgwSection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgwSection.Name = "dgwSection";
            this.dgwSection.RowHeadersWidth = 51;
            this.dgwSection.RowTemplate.Height = 25;
            this.dgwSection.Size = new System.Drawing.Size(497, 368);
            this.dgwSection.TabIndex = 10;
            // 
            // tollBoothId
            // 
            this.tollBoothId.HeaderText = "Id";
            this.tollBoothId.MinimumWidth = 6;
            this.tollBoothId.Name = "tollBoothId";
            this.tollBoothId.ReadOnly = true;
            this.tollBoothId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tollBoothId.Width = 40;
            // 
            // sectionExit
            // 
            this.sectionExit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sectionExit.HeaderText = "Exit";
            this.sectionExit.MinimumWidth = 6;
            this.sectionExit.Name = "sectionExit";
            this.sectionExit.ReadOnly = true;
            this.sectionExit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // sectionDistance
            // 
            this.sectionDistance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sectionDistance.HeaderText = "Distance";
            this.sectionDistance.MinimumWidth = 6;
            this.sectionDistance.Name = "sectionDistance";
            this.sectionDistance.ReadOnly = true;
            this.sectionDistance.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SectionHeadManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 589);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblTollStationName);
            this.Controls.Add(this.dgwSection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SectionHeadManagerForm";
            this.Text = "SectionHeadManagerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgwSection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblTollStationName;
        private System.Windows.Forms.DataGridView dgwSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn tollBoothId;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDistance;
    }
}