
namespace Simsprojekat.View.StationManagerView
{
    partial class HeadManagerForm
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pricelistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearlyGlobalIncomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.montlhyGlobalIncomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyGlobalIncomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tollStationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceListsPanel = new System.Windows.Forms.Panel();
            this.dgwTollStations = new System.Windows.Forms.DataGridView();
            this.tollstationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tollstationCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tollstationZipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tollstationSection = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1.SuspendLayout();
            this.priceListsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTollStations)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pricelistsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.workersToolStripMenuItem,
            this.tollStationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pricelistsToolStripMenuItem
            // 
            this.pricelistsToolStripMenuItem.Name = "pricelistsToolStripMenuItem";
            this.pricelistsToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.pricelistsToolStripMenuItem.Text = "Toll Stations";
            this.pricelistsToolStripMenuItem.Click += new System.EventHandler(this.pricelistsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yearlyGlobalIncomeToolStripMenuItem,
            this.montlhyGlobalIncomeToolStripMenuItem,
            this.dailyGlobalIncomeToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // yearlyGlobalIncomeToolStripMenuItem
            // 
            this.yearlyGlobalIncomeToolStripMenuItem.Name = "yearlyGlobalIncomeToolStripMenuItem";
            this.yearlyGlobalIncomeToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.yearlyGlobalIncomeToolStripMenuItem.Text = "Yearly global income";
            this.yearlyGlobalIncomeToolStripMenuItem.Click += new System.EventHandler(this.yearlyGlobalIncomeToolStripMenuItem_Click);
            // 
            // montlhyGlobalIncomeToolStripMenuItem
            // 
            this.montlhyGlobalIncomeToolStripMenuItem.Name = "montlhyGlobalIncomeToolStripMenuItem";
            this.montlhyGlobalIncomeToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.montlhyGlobalIncomeToolStripMenuItem.Text = "Montlhy global income";
            this.montlhyGlobalIncomeToolStripMenuItem.Click += new System.EventHandler(this.montlhyGlobalIncomeToolStripMenuItem_Click);
            // 
            // dailyGlobalIncomeToolStripMenuItem
            // 
            this.dailyGlobalIncomeToolStripMenuItem.Name = "dailyGlobalIncomeToolStripMenuItem";
            this.dailyGlobalIncomeToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.dailyGlobalIncomeToolStripMenuItem.Text = "Daily global income";
            this.dailyGlobalIncomeToolStripMenuItem.Click += new System.EventHandler(this.dailyGlobalIncomeToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // workersToolStripMenuItem
            // 
            this.workersToolStripMenuItem.Name = "workersToolStripMenuItem";
            this.workersToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.workersToolStripMenuItem.Text = "Workers";
            // 
            // tollStationsToolStripMenuItem
            // 
            this.tollStationsToolStripMenuItem.Name = "tollStationsToolStripMenuItem";
            this.tollStationsToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.tollStationsToolStripMenuItem.Text = "Price Lists";
            // 
            // priceListsPanel
            // 
            this.priceListsPanel.Controls.Add(this.dgwTollStations);
            this.priceListsPanel.Location = new System.Drawing.Point(0, 31);
            this.priceListsPanel.Name = "priceListsPanel";
            this.priceListsPanel.Size = new System.Drawing.Size(800, 418);
            this.priceListsPanel.TabIndex = 3;
            // 
            // dgwTollStations
            // 
            this.dgwTollStations.AllowUserToAddRows = false;
            this.dgwTollStations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTollStations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tollstationId,
            this.tollstationCity,
            this.tollstationZipCode,
            this.tollstationSection});
            this.dgwTollStations.Location = new System.Drawing.Point(100, 25);
            this.dgwTollStations.Name = "dgwTollStations";
            this.dgwTollStations.RowHeadersWidth = 51;
            this.dgwTollStations.RowTemplate.Height = 29;
            this.dgwTollStations.Size = new System.Drawing.Size(587, 323);
            this.dgwTollStations.TabIndex = 0;
            this.dgwTollStations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwTollStations_CellContentClick);
            // 
            // tollstationId
            // 
            this.tollstationId.HeaderText = "Id";
            this.tollstationId.MinimumWidth = 6;
            this.tollstationId.Name = "tollstationId";
            this.tollstationId.Width = 125;
            // 
            // tollstationCity
            // 
            this.tollstationCity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tollstationCity.HeaderText = "City";
            this.tollstationCity.MinimumWidth = 6;
            this.tollstationCity.Name = "tollstationCity";
            // 
            // tollstationZipCode
            // 
            this.tollstationZipCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tollstationZipCode.HeaderText = "Zip Code";
            this.tollstationZipCode.MinimumWidth = 6;
            this.tollstationZipCode.Name = "tollstationZipCode";
            // 
            // tollstationSection
            // 
            this.tollstationSection.HeaderText = "Section";
            this.tollstationSection.MinimumWidth = 6;
            this.tollstationSection.Name = "tollstationSection";
            this.tollstationSection.Width = 125;
            // 
            // HeadManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.priceListsPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HeadManagerForm";
            this.Text = "HeadManagerForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.priceListsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTollStations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pricelistsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearlyGlobalIncomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem montlhyGlobalIncomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyGlobalIncomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tollStationsToolStripMenuItem;
        private System.Windows.Forms.Panel priceListsPanel;
        private System.Windows.Forms.DataGridView dgwTollStations;
        private System.Windows.Forms.DataGridViewTextBoxColumn tollstationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn tollstationCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn tollstationZipCode;
        private System.Windows.Forms.DataGridViewButtonColumn tollstationSection;
    }
}