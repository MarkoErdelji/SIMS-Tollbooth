namespace Simsprojekat.View.AdministratorView
{
    partial class TollBoothAdminForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tollBoothId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tollBoothNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tollBoothDevices = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tollBoothNumberLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.tollStationDeleteBtn = new System.Windows.Forms.Button();
            this.tollStationUpdateBtn = new System.Windows.Forms.Button();
            this.tollStationCreateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.tollBoothNumber,
            this.tollBoothDevices});
            this.dataGridView1.Location = new System.Drawing.Point(125, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(435, 276);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tollBoothId
            // 
            this.tollBoothId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tollBoothId.HeaderText = "Id";
            this.tollBoothId.Name = "tollBoothId";
            this.tollBoothId.ReadOnly = true;
            this.tollBoothId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tollBoothNumber
            // 
            this.tollBoothNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tollBoothNumber.HeaderText = "Name";
            this.tollBoothNumber.Name = "tollBoothNumber";
            this.tollBoothNumber.ReadOnly = true;
            this.tollBoothNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tollBoothDevices
            // 
            this.tollBoothDevices.HeaderText = "Devices";
            this.tollBoothDevices.Name = "tollBoothDevices";
            this.tollBoothDevices.ReadOnly = true;
            this.tollBoothDevices.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tollBoothDevices.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tollBoothDevices.Width = 70;
            // 
            // tollBoothNumberLabel
            // 
            this.tollBoothNumberLabel.AutoSize = true;
            this.tollBoothNumberLabel.Location = new System.Drawing.Point(305, 23);
            this.tollBoothNumberLabel.Name = "tollBoothNumberLabel";
            this.tollBoothNumberLabel.Size = new System.Drawing.Size(75, 15);
            this.tollBoothNumberLabel.TabIndex = 1;
            this.tollBoothNumberLabel.Text = "Toll Station #";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(287, 48);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(59, 15);
            this.locationLabel.TabIndex = 2;
            this.locationLabel.Text = "Location :";
            // 
            // tollStationDeleteBtn
            // 
            this.tollStationDeleteBtn.Location = new System.Drawing.Point(441, 373);
            this.tollStationDeleteBtn.Name = "tollStationDeleteBtn";
            this.tollStationDeleteBtn.Size = new System.Drawing.Size(119, 39);
            this.tollStationDeleteBtn.TabIndex = 6;
            this.tollStationDeleteBtn.Text = "Delete";
            this.tollStationDeleteBtn.UseVisualStyleBackColor = true;
            // 
            // tollStationUpdateBtn
            // 
            this.tollStationUpdateBtn.Location = new System.Drawing.Point(287, 373);
            this.tollStationUpdateBtn.Name = "tollStationUpdateBtn";
            this.tollStationUpdateBtn.Size = new System.Drawing.Size(106, 39);
            this.tollStationUpdateBtn.TabIndex = 5;
            this.tollStationUpdateBtn.Text = "Update";
            this.tollStationUpdateBtn.UseVisualStyleBackColor = true;
            // 
            // tollStationCreateBtn
            // 
            this.tollStationCreateBtn.Location = new System.Drawing.Point(125, 372);
            this.tollStationCreateBtn.Name = "tollStationCreateBtn";
            this.tollStationCreateBtn.Size = new System.Drawing.Size(103, 41);
            this.tollStationCreateBtn.TabIndex = 4;
            this.tollStationCreateBtn.Text = "Create";
            this.tollStationCreateBtn.UseVisualStyleBackColor = true;
            // 
            // TollBoothAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 442);
            this.Controls.Add(this.tollStationDeleteBtn);
            this.Controls.Add(this.tollStationUpdateBtn);
            this.Controls.Add(this.tollStationCreateBtn);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.tollBoothNumberLabel);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TollBoothAdminForm";
            this.Text = "TollBoothAdminForm";
            this.Load += new System.EventHandler(this.TollBoothAdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label tollBoothNumberLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Button tollStationDeleteBtn;
        private System.Windows.Forms.Button tollStationUpdateBtn;
        private System.Windows.Forms.Button tollStationCreateBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tollBoothId;
        private System.Windows.Forms.DataGridViewTextBoxColumn tollBoothNumber;
        private System.Windows.Forms.DataGridViewButtonColumn tollBoothDevices;
    }
}