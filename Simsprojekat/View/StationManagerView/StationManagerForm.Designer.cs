namespace Simsprojekat.View
{
    partial class StationManagerForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listTollboothsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearlyLocalIncomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyLocalIncomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyLocalIncomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListTollBoothPanel = new System.Windows.Forms.Panel();
            this.listOfTollBoothsGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devices = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tollStationNameLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.ListTollBoothPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfTollBoothsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listTollboothsToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listTollboothsToolStripMenuItem
            // 
            this.listTollboothsToolStripMenuItem.Name = "listTollboothsToolStripMenuItem";
            this.listTollboothsToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.listTollboothsToolStripMenuItem.Text = "List toll booths";
            this.listTollboothsToolStripMenuItem.Click += new System.EventHandler(this.listTollboothsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yearlyLocalIncomeToolStripMenuItem,
            this.monthlyLocalIncomeToolStripMenuItem,
            this.dailyLocalIncomeToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // yearlyLocalIncomeToolStripMenuItem
            // 
            this.yearlyLocalIncomeToolStripMenuItem.Name = "yearlyLocalIncomeToolStripMenuItem";
            this.yearlyLocalIncomeToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.yearlyLocalIncomeToolStripMenuItem.Text = "Yearly local income";
            this.yearlyLocalIncomeToolStripMenuItem.Click += new System.EventHandler(this.yearlyLocalIncomeToolStripMenuItem_Click);
            // 
            // monthlyLocalIncomeToolStripMenuItem
            // 
            this.monthlyLocalIncomeToolStripMenuItem.Name = "monthlyLocalIncomeToolStripMenuItem";
            this.monthlyLocalIncomeToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.monthlyLocalIncomeToolStripMenuItem.Text = "Monthly local income";
            this.monthlyLocalIncomeToolStripMenuItem.Click += new System.EventHandler(this.monthlyLocalIncomeToolStripMenuItem_Click);
            // 
            // dailyLocalIncomeToolStripMenuItem
            // 
            this.dailyLocalIncomeToolStripMenuItem.Name = "dailyLocalIncomeToolStripMenuItem";
            this.dailyLocalIncomeToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.dailyLocalIncomeToolStripMenuItem.Text = "Daily local income";
            this.dailyLocalIncomeToolStripMenuItem.Click += new System.EventHandler(this.dailyLocalIncomeToolStripMenuItem_Click);
            // 
            // ListTollBoothPanel
            // 
            this.ListTollBoothPanel.Controls.Add(this.listOfTollBoothsGridView);
            this.ListTollBoothPanel.Controls.Add(this.tollStationNameLabel);
            this.ListTollBoothPanel.Location = new System.Drawing.Point(102, 65);
            this.ListTollBoothPanel.Name = "ListTollBoothPanel";
            this.ListTollBoothPanel.Size = new System.Drawing.Size(580, 344);
            this.ListTollBoothPanel.TabIndex = 1;
            this.ListTollBoothPanel.Visible = false;
            this.ListTollBoothPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ListTollBoothPanel_Paint);
            // 
            // listOfTollBoothsGridView
            // 
            this.listOfTollBoothsGridView.AllowUserToAddRows = false;
            this.listOfTollBoothsGridView.AllowUserToDeleteRows = false;
            this.listOfTollBoothsGridView.AllowUserToResizeColumns = false;
            this.listOfTollBoothsGridView.AllowUserToResizeRows = false;
            this.listOfTollBoothsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfTollBoothsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.devices});
            this.listOfTollBoothsGridView.Location = new System.Drawing.Point(67, 72);
            this.listOfTollBoothsGridView.Name = "listOfTollBoothsGridView";
            this.listOfTollBoothsGridView.RowTemplate.Height = 25;
            this.listOfTollBoothsGridView.Size = new System.Drawing.Size(451, 228);
            this.listOfTollBoothsGridView.TabIndex = 1;
            this.listOfTollBoothsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listOfTollBoothsGridView_CellContentClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // devices
            // 
            this.devices.FillWeight = 1F;
            this.devices.HeaderText = "Devices";
            this.devices.Name = "devices";
            this.devices.Width = 70;
            // 
            // tollStationNameLabel
            // 
            this.tollStationNameLabel.AutoSize = true;
            this.tollStationNameLabel.Location = new System.Drawing.Point(272, 14);
            this.tollStationNameLabel.Name = "tollStationNameLabel";
            this.tollStationNameLabel.Size = new System.Drawing.Size(38, 15);
            this.tollStationNameLabel.TabIndex = 0;
            this.tollStationNameLabel.Text = "label1";
            // 
            // StationManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 457);
            this.Controls.Add(this.ListTollBoothPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Text = "StationManager";
            this.Load += new System.EventHandler(this.StationManagerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ListTollBoothPanel.ResumeLayout(false);
            this.ListTollBoothPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfTollBoothsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listTollboothsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearlyLocalIncomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyLocalIncomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyLocalIncomeToolStripMenuItem;
        private System.Windows.Forms.Panel ListTollBoothPanel;
        private System.Windows.Forms.DataGridView listOfTollBoothsGridView;
        private System.Windows.Forms.Label tollStationNameLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewButtonColumn devices;
    }
}