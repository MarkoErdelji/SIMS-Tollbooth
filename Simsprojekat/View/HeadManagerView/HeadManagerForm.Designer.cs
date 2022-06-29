
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
            this.tollStationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearlyGlobalIncomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.montlhyGlobalIncomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyGlobalIncomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTollStations = new System.Windows.Forms.Panel();
            this.dgwTollStations = new System.Windows.Forms.DataGridView();
            this.tollstationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tollstationCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tollstationZipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tollstationSection = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelPriceLists = new System.Windows.Forms.Panel();
            this.dgwPriceLists = new System.Windows.Forms.DataGridView();
            this.idPricelist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panelTollStations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTollStations)).BeginInit();
            this.panelPriceLists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPriceLists)).BeginInit();
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
            this.tollStationsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.workersToolStripMenuItem,
            this.priceListsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tollStationsToolStripMenuItem
            // 
            this.tollStationsToolStripMenuItem.Name = "tollStationsToolStripMenuItem";
            this.tollStationsToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.tollStationsToolStripMenuItem.Text = "Toll Stations";
            this.tollStationsToolStripMenuItem.Click += new System.EventHandler(this.tollStationsToolStripMenuItem_Click);
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
            this.workersToolStripMenuItem.Click += new System.EventHandler(this.workersToolStripMenuItem_Click);
            // 
            // priceListsToolStripMenuItem
            // 
            this.priceListsToolStripMenuItem.Name = "priceListsToolStripMenuItem";
            this.priceListsToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.priceListsToolStripMenuItem.Text = "Price Lists";
            this.priceListsToolStripMenuItem.Click += new System.EventHandler(this.priceListsToolStripMenuItem_Click);
            // 
            // panelTollStations
            // 
            this.panelTollStations.Controls.Add(this.dgwTollStations);
            this.panelTollStations.Location = new System.Drawing.Point(0, 31);
            this.panelTollStations.Name = "panelTollStations";
            this.panelTollStations.Size = new System.Drawing.Size(800, 418);
            this.panelTollStations.TabIndex = 3;
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
            // panelPriceLists
            // 
            this.panelPriceLists.Controls.Add(this.btnAdd);
            this.panelPriceLists.Controls.Add(this.dgwPriceLists);
            this.panelPriceLists.Location = new System.Drawing.Point(0, 31);
            this.panelPriceLists.Name = "panelPriceLists";
            this.panelPriceLists.Size = new System.Drawing.Size(800, 418);
            this.panelPriceLists.TabIndex = 1;
            // 
            // dgwPriceLists
            // 
            this.dgwPriceLists.AllowUserToAddRows = false;
            this.dgwPriceLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPriceLists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPricelist,
            this.lastUsed,
            this.isActive,
            this.editBtn,
            this.deleteBtn});
            this.dgwPriceLists.Location = new System.Drawing.Point(100, 25);
            this.dgwPriceLists.Name = "dgwPriceLists";
            this.dgwPriceLists.RowHeadersWidth = 51;
            this.dgwPriceLists.RowTemplate.Height = 29;
            this.dgwPriceLists.Size = new System.Drawing.Size(587, 323);
            this.dgwPriceLists.TabIndex = 0;
            this.dgwPriceLists.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPriceLists_CellContentClick);
            // 
            // idPricelist
            // 
            this.idPricelist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idPricelist.HeaderText = "Id";
            this.idPricelist.MinimumWidth = 6;
            this.idPricelist.Name = "idPricelist";
            // 
            // lastUsed
            // 
            this.lastUsed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastUsed.HeaderText = "Last used";
            this.lastUsed.MinimumWidth = 6;
            this.lastUsed.Name = "lastUsed";
            // 
            // isActive
            // 
            this.isActive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.isActive.HeaderText = "Is active price list";
            this.isActive.MinimumWidth = 6;
            this.isActive.Name = "isActive";
            // 
            // editBtn
            // 
            this.editBtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.editBtn.HeaderText = "Edit price list";
            this.editBtn.MinimumWidth = 6;
            this.editBtn.Name = "editBtn";
            this.editBtn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editBtn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // deleteBtn
            // 
            this.deleteBtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deleteBtn.HeaderText = "Delete price list";
            this.deleteBtn.MinimumWidth = 6;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deleteBtn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(100, 367);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 29);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add pricelist";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // HeadManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelPriceLists);
            this.Controls.Add(this.panelTollStations);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HeadManagerForm";
            this.Text = "HeadManagerForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelTollStations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTollStations)).EndInit();
            this.panelPriceLists.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPriceLists)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tollStationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearlyGlobalIncomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem montlhyGlobalIncomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyGlobalIncomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceListsToolStripMenuItem;
        private System.Windows.Forms.Panel panelTollStations;
        private System.Windows.Forms.DataGridView dgwTollStations;
        private System.Windows.Forms.DataGridViewTextBoxColumn tollstationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn tollstationCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn tollstationZipCode;
        private System.Windows.Forms.DataGridViewButtonColumn tollstationSection;
        private System.Windows.Forms.Panel panelPriceLists;
        private System.Windows.Forms.DataGridView dgwPriceLists;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPricelist;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn isActive;
        private System.Windows.Forms.DataGridViewButtonColumn editBtn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteBtn;
        private System.Windows.Forms.Button btnAdd;
    }
}