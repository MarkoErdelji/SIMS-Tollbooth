namespace Simsprojekat.View.AdministratorView
{
    partial class SectionAdminForm
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
            this.sectionDeleteBtn = new System.Windows.Forms.Button();
            this.sectionCreateBtn = new System.Windows.Forms.Button();
            this.locationLabel = new System.Windows.Forms.Label();
            this.tollBoothNumberLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tollBoothId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionExit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sectionDeleteBtn
            // 
            this.sectionDeleteBtn.Location = new System.Drawing.Point(453, 370);
            this.sectionDeleteBtn.Name = "sectionDeleteBtn";
            this.sectionDeleteBtn.Size = new System.Drawing.Size(119, 39);
            this.sectionDeleteBtn.TabIndex = 11;
            this.sectionDeleteBtn.Text = "Delete";
            this.sectionDeleteBtn.UseVisualStyleBackColor = true;
            this.sectionDeleteBtn.Click += new System.EventHandler(this.sectionDeleteBtn_Click);
            // 
            // sectionCreateBtn
            // 
            this.sectionCreateBtn.Location = new System.Drawing.Point(137, 369);
            this.sectionCreateBtn.Name = "sectionCreateBtn";
            this.sectionCreateBtn.Size = new System.Drawing.Size(103, 41);
            this.sectionCreateBtn.TabIndex = 10;
            this.sectionCreateBtn.Text = "Create";
            this.sectionCreateBtn.UseVisualStyleBackColor = true;
            this.sectionCreateBtn.Click += new System.EventHandler(this.sectionCreateBtn_Click);
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(299, 46);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(59, 15);
            this.locationLabel.TabIndex = 9;
            this.locationLabel.Text = "Location :";
            // 
            // tollBoothNumberLabel
            // 
            this.tollBoothNumberLabel.AutoSize = true;
            this.tollBoothNumberLabel.Location = new System.Drawing.Point(317, 21);
            this.tollBoothNumberLabel.Name = "tollBoothNumberLabel";
            this.tollBoothNumberLabel.Size = new System.Drawing.Size(75, 15);
            this.tollBoothNumberLabel.TabIndex = 8;
            this.tollBoothNumberLabel.Text = "Toll Station #";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tollBoothId,
            this.sectionExit,
            this.sectionDistance});
            this.dataGridView1.Location = new System.Drawing.Point(137, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(435, 276);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tollBoothId
            // 
            this.tollBoothId.HeaderText = "Id";
            this.tollBoothId.Name = "tollBoothId";
            this.tollBoothId.ReadOnly = true;
            this.tollBoothId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tollBoothId.Width = 40;
            // 
            // sectionExit
            // 
            this.sectionExit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sectionExit.HeaderText = "Exit";
            this.sectionExit.Name = "sectionExit";
            this.sectionExit.ReadOnly = true;
            this.sectionExit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // sectionDistance
            // 
            this.sectionDistance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sectionDistance.HeaderText = "Distance";
            this.sectionDistance.Name = "sectionDistance";
            this.sectionDistance.ReadOnly = true;
            this.sectionDistance.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // sectionUpdate
            // 
            this.sectionUpdate.Location = new System.Drawing.Point(299, 369);
            this.sectionUpdate.Name = "sectionUpdate";
            this.sectionUpdate.Size = new System.Drawing.Size(119, 39);
            this.sectionUpdate.TabIndex = 12;
            this.sectionUpdate.Text = "Update";
            this.sectionUpdate.UseVisualStyleBackColor = true;
            this.sectionUpdate.Click += new System.EventHandler(this.sectionUpdate_Click);
            // 
            // SectionAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 450);
            this.Controls.Add(this.sectionUpdate);
            this.Controls.Add(this.sectionDeleteBtn);
            this.Controls.Add(this.sectionCreateBtn);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.tollBoothNumberLabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SectionAdminForm";
            this.Text = "SectionAdminForm";
            this.Load += new System.EventHandler(this.SectionAdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sectionDeleteBtn;
        private System.Windows.Forms.Button sectionCreateBtn;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label tollBoothNumberLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button sectionUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn tollBoothId;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDistance;
    }
}