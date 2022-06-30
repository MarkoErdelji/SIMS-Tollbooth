
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
            this.btnSetActive = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgwPriceLists = new System.Windows.Forms.DataGridView();
            this.idPricelist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelWorkers = new System.Windows.Forms.Panel();
            this.dgwWorkers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panelTollStations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTollStations)).BeginInit();
            this.panelPriceLists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPriceLists)).BeginInit();
            this.panelWorkers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwWorkers)).BeginInit();
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
            this.panelPriceLists.Controls.Add(this.btnSetActive);
            this.panelPriceLists.Controls.Add(this.btnAdd);
            this.panelPriceLists.Controls.Add(this.dgwPriceLists);
            this.panelPriceLists.Location = new System.Drawing.Point(0, 31);
            this.panelPriceLists.Name = "panelPriceLists";
            this.panelPriceLists.Size = new System.Drawing.Size(800, 418);
            this.panelPriceLists.TabIndex = 1;
            // 
            // btnSetActive
            // 
            this.btnSetActive.Location = new System.Drawing.Point(255, 367);
            this.btnSetActive.Name = "btnSetActive";
            this.btnSetActive.Size = new System.Drawing.Size(94, 29);
            this.btnSetActive.TabIndex = 2;
            this.btnSetActive.Text = "Set active";
            this.btnSetActive.UseVisualStyleBackColor = true;
            this.btnSetActive.Click += new System.EventHandler(this.btnSetActive_Click);
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
            this.dgwPriceLists.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPriceLists_CellClick);
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
            // panelWorkers
            // 
            this.panelWorkers.Controls.Add(this.btnDelete);
            this.panelWorkers.Controls.Add(this.btnUpdate);
            this.panelWorkers.Controls.Add(this.btnCreate);
            this.panelWorkers.Controls.Add(this.dgwWorkers);
            this.panelWorkers.Location = new System.Drawing.Point(0, 31);
            this.panelWorkers.Name = "panelWorkers";
            this.panelWorkers.Size = new System.Drawing.Size(800, 418);
            this.panelWorkers.TabIndex = 3;
            // 
            // dgwWorkers
            // 
            this.dgwWorkers.AllowUserToAddRows = false;
            this.dgwWorkers.AllowUserToDeleteRows = false;
            this.dgwWorkers.AllowUserToResizeColumns = false;
            this.dgwWorkers.AllowUserToResizeRows = false;
            this.dgwWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwWorkers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.userFirstName,
            this.userLastName,
            this.userUsername,
            this.userPassword,
            this.userEmail,
            this.userType,
            this.userAdress,
            this.userCity});
            this.dgwWorkers.Location = new System.Drawing.Point(12, 16);
            this.dgwWorkers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgwWorkers.Name = "dgwWorkers";
            this.dgwWorkers.RowHeadersWidth = 51;
            this.dgwWorkers.RowTemplate.Height = 25;
            this.dgwWorkers.Size = new System.Drawing.Size(776, 288);
            this.dgwWorkers.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // userFirstName
            // 
            this.userFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userFirstName.HeaderText = "First Name";
            this.userFirstName.MinimumWidth = 6;
            this.userFirstName.Name = "userFirstName";
            this.userFirstName.ReadOnly = true;
            this.userFirstName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // userLastName
            // 
            this.userLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userLastName.HeaderText = "Last Name";
            this.userLastName.MinimumWidth = 6;
            this.userLastName.Name = "userLastName";
            this.userLastName.ReadOnly = true;
            this.userLastName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // userUsername
            // 
            this.userUsername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userUsername.HeaderText = "Username";
            this.userUsername.MinimumWidth = 6;
            this.userUsername.Name = "userUsername";
            this.userUsername.ReadOnly = true;
            this.userUsername.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // userPassword
            // 
            this.userPassword.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userPassword.HeaderText = "Password";
            this.userPassword.MinimumWidth = 6;
            this.userPassword.Name = "userPassword";
            this.userPassword.ReadOnly = true;
            this.userPassword.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // userEmail
            // 
            this.userEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.userEmail.FillWeight = 1F;
            this.userEmail.HeaderText = "Email";
            this.userEmail.MinimumWidth = 6;
            this.userEmail.Name = "userEmail";
            this.userEmail.ReadOnly = true;
            this.userEmail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.userEmail.Width = 150;
            // 
            // userType
            // 
            this.userType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userType.HeaderText = "Type";
            this.userType.MinimumWidth = 6;
            this.userType.Name = "userType";
            this.userType.ReadOnly = true;
            this.userType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // userAdress
            // 
            this.userAdress.HeaderText = "Adress";
            this.userAdress.MinimumWidth = 6;
            this.userAdress.Name = "userAdress";
            this.userAdress.ReadOnly = true;
            this.userAdress.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.userAdress.Width = 125;
            // 
            // userCity
            // 
            this.userCity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userCity.HeaderText = "City";
            this.userCity.MinimumWidth = 6;
            this.userCity.Name = "userCity";
            this.userCity.ReadOnly = true;
            this.userCity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(580, 335);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 52);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(339, 335);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 52);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(68, 332);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(118, 55);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // HeadManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelWorkers);
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
            this.panelWorkers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwWorkers)).EndInit();
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
        private System.Windows.Forms.Button btnSetActive;
        private System.Windows.Forms.Panel panelWorkers;
        private System.Windows.Forms.DataGridView dgwWorkers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn userEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn userType;
        private System.Windows.Forms.DataGridViewTextBoxColumn userAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn userCity;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
    }
}