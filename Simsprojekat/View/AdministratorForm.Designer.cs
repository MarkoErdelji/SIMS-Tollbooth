namespace Simsprojekat.View
{
    partial class AdministratorForm
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
            this.tolLStationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tollStationDeleteBtn = new System.Windows.Forms.Button();
            this.tollStationUpdateBtn = new System.Windows.Forms.Button();
            this.tollStationCreateBtn = new System.Windows.Forms.Button();
            this.tollStationGridView = new System.Windows.Forms.DataGridView();
            this.tollstationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tollstationCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tollstationZipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tollBooths = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userDeleteBtn = new System.Windows.Forms.Button();
            this.userUpdateBtn = new System.Windows.Forms.Button();
            this.userCreateBtn = new System.Windows.Forms.Button();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tollStationGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tolLStationsToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tolLStationsToolStripMenuItem
            // 
            this.tolLStationsToolStripMenuItem.Name = "tolLStationsToolStripMenuItem";
            this.tolLStationsToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.tolLStationsToolStripMenuItem.Text = "Toll Stations";
            this.tolLStationsToolStripMenuItem.Click += new System.EventHandler(this.tolLStationsToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tollStationDeleteBtn);
            this.panel1.Controls.Add(this.tollStationUpdateBtn);
            this.panel1.Controls.Add(this.tollStationCreateBtn);
            this.panel1.Controls.Add(this.tollStationGridView);
            this.panel1.Location = new System.Drawing.Point(3, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 487);
            this.panel1.TabIndex = 1;
            // 
            // tollStationDeleteBtn
            // 
            this.tollStationDeleteBtn.Location = new System.Drawing.Point(578, 332);
            this.tollStationDeleteBtn.Name = "tollStationDeleteBtn";
            this.tollStationDeleteBtn.Size = new System.Drawing.Size(119, 39);
            this.tollStationDeleteBtn.TabIndex = 3;
            this.tollStationDeleteBtn.Text = "Delete";
            this.tollStationDeleteBtn.UseVisualStyleBackColor = true;
            // 
            // tollStationUpdateBtn
            // 
            this.tollStationUpdateBtn.Location = new System.Drawing.Point(366, 332);
            this.tollStationUpdateBtn.Name = "tollStationUpdateBtn";
            this.tollStationUpdateBtn.Size = new System.Drawing.Size(106, 39);
            this.tollStationUpdateBtn.TabIndex = 2;
            this.tollStationUpdateBtn.Text = "Update";
            this.tollStationUpdateBtn.UseVisualStyleBackColor = true;
            // 
            // tollStationCreateBtn
            // 
            this.tollStationCreateBtn.Location = new System.Drawing.Point(130, 331);
            this.tollStationCreateBtn.Name = "tollStationCreateBtn";
            this.tollStationCreateBtn.Size = new System.Drawing.Size(103, 41);
            this.tollStationCreateBtn.TabIndex = 1;
            this.tollStationCreateBtn.Text = "Create";
            this.tollStationCreateBtn.UseVisualStyleBackColor = true;
            // 
            // tollStationGridView
            // 
            this.tollStationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tollStationGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tollstationId,
            this.tollstationCity,
            this.tollstationZipCode,
            this.tollBooths});
            this.tollStationGridView.Location = new System.Drawing.Point(130, 23);
            this.tollStationGridView.Name = "tollStationGridView";
            this.tollStationGridView.RowTemplate.Height = 25;
            this.tollStationGridView.Size = new System.Drawing.Size(567, 282);
            this.tollStationGridView.TabIndex = 0;
            this.tollStationGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tollStationGridView_CellContentClick);
            // 
            // tollstationId
            // 
            this.tollstationId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tollstationId.HeaderText = "Id";
            this.tollstationId.Name = "tollstationId";
            this.tollstationId.ReadOnly = true;
            this.tollstationId.Width = 50;
            // 
            // tollstationCity
            // 
            this.tollstationCity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tollstationCity.FillWeight = 78.57143F;
            this.tollstationCity.HeaderText = "City";
            this.tollstationCity.Name = "tollstationCity";
            this.tollstationCity.ReadOnly = true;
            // 
            // tollstationZipCode
            // 
            this.tollstationZipCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tollstationZipCode.FillWeight = 78.57143F;
            this.tollstationZipCode.HeaderText = "Zip Code";
            this.tollstationZipCode.Name = "tollstationZipCode";
            this.tollstationZipCode.ReadOnly = true;
            // 
            // tollBooths
            // 
            this.tollBooths.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tollBooths.FillWeight = 1F;
            this.tollBooths.HeaderText = "Toll Booths";
            this.tollBooths.Name = "tollBooths";
            this.tollBooths.ReadOnly = true;
            this.tollBooths.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tollBooths.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tollBooths.Width = 70;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userDeleteBtn);
            this.panel2.Controls.Add(this.userUpdateBtn);
            this.panel2.Controls.Add(this.userCreateBtn);
            this.panel2.Controls.Add(this.userDataGridView);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(981, 484);
            this.panel2.TabIndex = 4;
            // 
            // userDeleteBtn
            // 
            this.userDeleteBtn.Location = new System.Drawing.Point(772, 394);
            this.userDeleteBtn.Name = "userDeleteBtn";
            this.userDeleteBtn.Size = new System.Drawing.Size(100, 40);
            this.userDeleteBtn.TabIndex = 3;
            this.userDeleteBtn.Text = "Delete";
            this.userDeleteBtn.UseVisualStyleBackColor = true;
            // 
            // userUpdateBtn
            // 
            this.userUpdateBtn.Location = new System.Drawing.Point(465, 396);
            this.userUpdateBtn.Name = "userUpdateBtn";
            this.userUpdateBtn.Size = new System.Drawing.Size(106, 39);
            this.userUpdateBtn.TabIndex = 2;
            this.userUpdateBtn.Text = "Update";
            this.userUpdateBtn.UseVisualStyleBackColor = true;
            // 
            // userCreateBtn
            // 
            this.userCreateBtn.Location = new System.Drawing.Point(150, 394);
            this.userCreateBtn.Name = "userCreateBtn";
            this.userCreateBtn.Size = new System.Drawing.Size(103, 41);
            this.userCreateBtn.TabIndex = 1;
            this.userCreateBtn.Text = "Create";
            this.userCreateBtn.UseVisualStyleBackColor = true;
            // 
            // userDataGridView
            // 
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.userFirstName,
            this.userLastName,
            this.userUsername,
            this.userPassword,
            this.userEmail,
            this.userType,
            this.userAdress,
            this.userCity});
            this.userDataGridView.Location = new System.Drawing.Point(78, 55);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.RowTemplate.Height = 25;
            this.userDataGridView.Size = new System.Drawing.Size(833, 287);
            this.userDataGridView.TabIndex = 0;
            this.userDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // userFirstName
            // 
            this.userFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userFirstName.HeaderText = "First Name";
            this.userFirstName.Name = "userFirstName";
            this.userFirstName.ReadOnly = true;
            this.userFirstName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // userLastName
            // 
            this.userLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userLastName.HeaderText = "Last Name";
            this.userLastName.Name = "userLastName";
            this.userLastName.ReadOnly = true;
            this.userLastName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // userUsername
            // 
            this.userUsername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userUsername.HeaderText = "Username";
            this.userUsername.Name = "userUsername";
            this.userUsername.ReadOnly = true;
            this.userUsername.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // userPassword
            // 
            this.userPassword.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userPassword.HeaderText = "Password";
            this.userPassword.Name = "userPassword";
            this.userPassword.ReadOnly = true;
            this.userPassword.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // userEmail
            // 
            this.userEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.userEmail.FillWeight = 1F;
            this.userEmail.HeaderText = "Email";
            this.userEmail.Name = "userEmail";
            this.userEmail.ReadOnly = true;
            this.userEmail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.userEmail.Width = 150;
            // 
            // userType
            // 
            this.userType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userType.HeaderText = "Type";
            this.userType.Name = "userType";
            this.userType.ReadOnly = true;
            this.userType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // userAdress
            // 
            this.userAdress.HeaderText = "Adress";
            this.userAdress.Name = "userAdress";
            this.userAdress.ReadOnly = true;
            this.userAdress.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // userCity
            // 
            this.userCity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userCity.HeaderText = "City";
            this.userCity.Name = "userCity";
            this.userCity.ReadOnly = true;
            this.userCity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdministratorForm";
            this.Text = "AdministratorForm";
            this.Load += new System.EventHandler(this.AdministratorForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tollStationGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tolLStationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button tollStationDeleteBtn;
        private System.Windows.Forms.Button tollStationUpdateBtn;
        private System.Windows.Forms.Button tollStationCreateBtn;
        private System.Windows.Forms.DataGridView tollStationGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button userUpdateBtn;
        private System.Windows.Forms.Button userCreateBtn;
        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.Button userDeleteBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tollstationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn tollstationCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn tollstationZipCode;
        private System.Windows.Forms.DataGridViewButtonColumn tollBooths;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn userEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn userType;
        private System.Windows.Forms.DataGridViewTextBoxColumn userAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn userCity;
    }
}